﻿using UnityEngine;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;

namespace HFFramework
{
    public class GameLooper : MonoBehaviour, IManager
    {
        public static GameLooper Instance;

        /// <summary>
        /// 锁
        /// </summary>
        private static object lockObj = new object();

        /// <summary>
        ///  主线程上下文
        /// </summary>
        private static SynchronizationContext mainThreadContext;

        /// <summary>
        /// 即将在下一帧被update的列表
        /// </summary>
        private List<BaseMonoBehaviour> prepareUpdateList = new List<BaseMonoBehaviour>();
        /// <summary>
        ///  本帧执行的update的列表
        /// </summary>
        private List<BaseMonoBehaviour> updateList = new List<BaseMonoBehaviour>();

        /// <summary>
        ///  即将在下一帧被fixedUpdate的列表
        /// </summary>
        private List<BaseMonoBehaviour> prepareFixedUpdateList = new List<BaseMonoBehaviour>();
        /// <summary>
        ///  本帧执行fixedUpdate的列表
        /// </summary>
        private List<BaseMonoBehaviour> fixedUpdateList = new List<BaseMonoBehaviour>();

        /// <summary>
        /// 即将在下一帧被LateUpdate的列表
        /// </summary>
        private List<BaseMonoBehaviour> prepareLateUpdateList = new List<BaseMonoBehaviour>();
        /// <summary>
        ///  本帧执行lateUpdate的列表
        /// </summary>
        private List<BaseMonoBehaviour> lateUpdateList = new List<BaseMonoBehaviour>();

        /// <summary>
        ///  event队列
        /// </summary>
        private Queue<Action> eventQueue = new Queue<Action>();

        void Awake()
        {
            Instance = this;
            mainThreadContext = SynchronizationContext.Current;
        }
    
        void Update()
        {
            lock (lockObj)
            {
                //执行事件队列
                while (eventQueue.Count > 0)
                {
                    Action e = eventQueue.Dequeue();
                    e();
                }
            }

            for (int i = 0; i < prepareUpdateList.Count; i++)
            {
                BaseMonoBehaviour temp = prepareUpdateList[i];
                if (temp.IsNeedUpdate)
                {
                    updateList.Add(temp);
                }
                else
                {
                    updateList.Remove(temp);
                }
            }
            prepareUpdateList.Clear();

            for (int i = 0; i < updateList.Count; i++)
            {
                updateList[i].OnUpdate(Time.deltaTime);
            }
        }

        void FixedUpdate()
        {
            for (int i = 0; i < prepareFixedUpdateList.Count; i++)
            {
                BaseMonoBehaviour temp = prepareFixedUpdateList[i];
                if (temp.IsNeedFixedUpdate)
                {
                    fixedUpdateList.Add(temp);
                }
                else
                {
                    fixedUpdateList.Remove(temp);
                }
            }
            prepareFixedUpdateList.Clear();

            for (int i = 0; i < fixedUpdateList.Count; i++)
            {
                fixedUpdateList[i].OnFixedUpdate(Time.deltaTime);
            }
        }

        void LateUpdate()
        {
            for (int i = 0; i < prepareLateUpdateList.Count; i++)
            {
                BaseMonoBehaviour temp = prepareLateUpdateList[i];
                if (temp.IsNeedLateUpdate)
                {
                    lateUpdateList.Add(temp);
                }
                else
                {
                    lateUpdateList.Remove(temp);
                }
            }
            prepareLateUpdateList.Clear();

            for (int i = 0; i < lateUpdateList.Count; i++)
            {
                lateUpdateList[i].OnLateUpdate(Time.deltaTime);
            }
        }

        public void DestroyManager()
        {
            prepareUpdateList.Clear();
            updateList.Clear();
            prepareFixedUpdateList.Clear();
            fixedUpdateList.Clear();
            prepareLateUpdateList.Clear();
            lateUpdateList.Clear();
            eventQueue.Clear();
            mainThreadContext = null;
            Instance = null;
        }

        public static void BackToMainThread(Action e)
        {
            lock (lockObj)
            {
                if (e != null && Instance != null)
                {
                    Instance.eventQueue.Enqueue(e);
                }
            }
        }

        /// <summary>
        ///  子线程回到主线程带参数方法
        /// </summary>
        /// <param name="d"></param>
        /// <param name="state">传给主线程的对象</param>
        public static void BackToMainThread(SendOrPostCallback d, object state)
        {
            mainThreadContext.Send(d, state);
        }

        public static void PrepareForUpdate(BaseMonoBehaviour mono)
        {
            if (Instance != null)
            {
                if (Instance.prepareUpdateList.Contains(mono) ==false)
                {
                    Instance.prepareUpdateList.Add(mono);
                }
            }
        }

        public static void PrepareForFixedUpdate(BaseMonoBehaviour mono)
        {
            if (Instance != null)
            {
                if (Instance.prepareFixedUpdateList.Contains(mono) == false)
                {
                    Instance.prepareFixedUpdateList.Add(mono);
                }
            }
        }

        public static void PrepareForLateUpdate(BaseMonoBehaviour mono)
        {
            if (Instance != null)
            {
                if (Instance.prepareLateUpdateList.Contains(mono) == false)
                {
                    Instance.prepareLateUpdateList.Add(mono);
                }
            }
        }
    }
}


