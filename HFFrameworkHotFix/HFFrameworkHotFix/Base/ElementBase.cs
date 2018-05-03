﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HFFramework;

namespace HotFix
{
    public class ElementBase
    {
        /// <summary>
        ///  全局控制 标记
        /// </summary>
        static long GlobalID = 0;

        /// <summary>
        ///  标记每一个元素 的 id  通过GlobalIdControl 每次创建都+1
        /// </summary>
        public long elementID;

        /// <summary>
        ///  element 对应的 游戏物体
        /// </summary>
        public GameObject gameObject;

        /// <summary>
        ///  gameObject 的 transform
        /// </summary>
        public Transform transform;

        /// <summary>
        ///  父element
        /// </summary>
        public ElementBase parent;

        /// <summary>
        ///  管理子物体的字典
        /// </summary>
        private Dictionary<long, ElementBase> subElementDic;
        public Dictionary<long, ElementBase> SubElementDic
        {
            set
            {
                subElementDic = value;
            }
            get
            {
                if (subElementDic == null)
                {
                    subElementDic = new Dictionary<long, ElementBase>();
                }
                return subElementDic;
            }
        }

        /// <summary>
        ///  注册的消息 字典   destory会自动销毁
        /// </summary>
        public Dictionary<int, object> messageTypeDic = new Dictionary<int, object>();
        public Dictionary<int, object> MessageTypeDic
        {
            set
            {
                messageTypeDic = value;
            }
            get
            {
                if (messageTypeDic == null)
                {
                    messageTypeDic = new Dictionary<int, object>();
                }
                return messageTypeDic;
            }
        }


        public List<IEnumerator> coroutineList = new List<IEnumerator>();

        private bool isShow;
        public virtual bool IsShow
        {
            set
            {
                isShow = value;
                if (gameObject != null && gameObject.activeSelf != value)
                {
                    gameObject.SetActive(isShow);
                }
                if (value == true)
                {
                    ElementDidAppear();
                }
                else
                {
                    ElementDidDisAppear();
                }
            }
            get
            {
                return isShow;
            }
        }

        private static long GetGlobalID()
        {
            return GlobalID++;
        }

        public ElementBase()
        {

        }

        public static T CreateElementWithGameObject<T>(GameObject g = null) where T : ElementBase, new()
        {
            T t1 = new T();
            t1.elementID = GetGlobalID();
            t1.gameObject = g;
            t1.transform = g.transform;
            t1.Awake();
            return t1;
        }


        public static T CreateElementWithGameObjectAndParent<T>(GameObject g = null, ElementBase parent = null) where T : ElementBase, new()
        {
            T t1 = new T();
            t1.elementID = GetGlobalID();
            t1.parent = parent;
            t1.gameObject = g;
            t1.transform = g.transform;
            t1.Awake();
            return t1;
        }

        public static T CreateElement<T>() where T : ElementBase, new()
        {
            T t1 = new T();
            t1.elementID = GetGlobalID();
            t1.Awake();
            return t1;
        }


        /// <summary>
        ///  脚本被生成重载方法
        /// </summary>
        public virtual void Awake()
        {

        }

        /// <summary>
        ///  对应接收消息的 重载方法
        /// </summary>
        public virtual void ReceiveMessage()
        {

        }

        /// <summary>
        ///  成员变量初始化对应重载方法
        /// </summary>
        public virtual void ElementInit()
        {

        }

        /// <summary>
        ///  加载资源 重载方法
        /// </summary>
        public virtual void LoadResources()
        {

        }

        /// <summary>
        /// 寻找子物体 重载方法
        /// </summary>
        public virtual void FindElement()
        {

        }

        public GameObject Instantiate(GameObject p)
        {
            if (p != null)
            {
                gameObject = GameObject.Instantiate(p);
                gameObject.name = p.name;
                transform = gameObject.transform;
            }
            return gameObject;
        }

        /// <summary>
        ///  寻找 子游戏物体 
        /// </summary>
        /// <param name="path">路径</param>
        /// <returns></returns>
        public GameObject FindChild(string path)
        {
            return transform.Find(path).gameObject;
        }

        /// <summary>
        ///  寻找子物体组件方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        public T FindChild<T>(string path)
        {
            return transform.Find(path).GetComponent<T>();
        }

        public void BringSelfToFront()
        {
            if (gameObject != null)
            {
                transform.SetAsLastSibling();
            }
        }

        public void BringSelfToBack()
        {
            if (gameObject != null)
            {
                transform.SetAsFirstSibling();
            }
        }

        /// <summary>
        ///  设置物体在父元素内的位置
        /// </summary>
        /// <param name="i"></param>
        public void SetSiblingIndex(int i)
        {
            if (gameObject != null)
            {
                transform.SetSiblingIndex(i);
            }
        }

        /// <summary>
        ///  添加子元素 方法
        /// </summary>
        /// <param name="ele"></param>
        public void AddSubElement(ElementBase ele)
        {
            if (!SubElementDic.ContainsKey(ele.elementID))
            {
                SubElementDic.Add(ele.elementID, ele);
            }
        }

        public void SetParent(GameObject g)
        {
            transform.SetParent(g.transform, false);
        }

        public void SetParent(ElementBase g)
        {
            parent = g;
            transform.SetParent(g.transform, false);
        }

        /// <summary>
        ///  显示一个 element  并且把他 作为自己的子物体
        /// </summary>
        /// <param name="e"></param>
        public void SetChild(ElementBase child)
        {
            AddSubElement(child);
            child.transform.SetParent(transform, false);
        }

        /// <summary>
        ///  显示一个 element  并且把他 作为自己的子物体
        /// </summary>
        /// <param name="e"></param>
        public void SetChild(GameObject child)
        {
            child.transform.SetParent(transform, false);
        }

        /// <summary>
        ///  开启协程
        /// </summary>
        /// <param name="coroutine"></param>
        public Coroutine StartCoroutine(IEnumerator c)
        {
            return GameLooper.self.StartCoroutine(c);
        }

        /// <summary>
        ///  关闭协程
        /// </summary>
        /// <param name="coroutine"></param>
        public void StopCoroutine(IEnumerator c)
        {
            if (c != null)
            {
                GameLooper.self.StopCoroutine(c);
            }
        }

        public void StopCoroutine(Coroutine c)
        {
            if (c != null)
            {
                GameLooper.self.StopCoroutine(c);
            }
        }

        bool isNeedUpdate = false;
        public bool IsNeedUpdate
        {
            set
            {
                if (value != isNeedUpdate)
                {
                    isNeedUpdate = value;
                    if (value == true)
                    {
                        //GameUpdate.AddUpdate(this);
                    }
                    else
                    {
                        //GameUpdate.SubUpdate(this);
                    }
                }
            }
            get
            {
                return isNeedUpdate;
            }
        }

        public void Update(float deltaTime)
        {
            MyUpdate(deltaTime);
        }

        bool isNeedFixedUpdate = false;
        public bool IsNeedFixedUpdate
        {
            set
            {
                if (value != isNeedFixedUpdate)
                {
                    isNeedFixedUpdate = value;
                    if (value == true)
                    {
                        //GameUpdate.AddFixedUpdate(this);
                    }
                    else
                    {
                        //GameUpdate.SubFixedUpdate(this);
                    }
                }
            }
            get
            {
                return isNeedFixedUpdate;
            }
        }

        public void FixedUpdate(float deltaTime)
        {
            MyFixedUpdate(deltaTime);
        }

        bool isNeedLateUpdate = false;
        public bool IsNeedLateUpdate
        {
            set
            {
                if (value != isNeedLateUpdate)
                {
                    isNeedLateUpdate = value;
                    if (value == true)
                    {
                        //GameUpdate.AddLateUpdate(this);
                    }
                    else
                    {
                        //GameUpdate.SubLateUpdate(this);
                    }
                }
            }
            get
            {
                return isNeedLateUpdate;
            }
        }

        public void LateUpdate(float deltaTime)
        {
            MyLateUpdate(deltaTime);
        }

        public virtual void M_Start()
        {

        }

        /// <summary>
        ///  如果需要 开启update 方法 只需要设置 IsNeedLateUpdate=true 并且重载M_Update 方法
        /// </summary>
        public virtual void MyUpdate(float deltaTime)
        {

        }

        /// <summary>
        ///  同理 update 
        /// </summary>
        public virtual void MyFixedUpdate(float deltaTime)
        {

        }

        /// <summary>
        /// 同理 update
        /// </summary>
        public virtual void MyLateUpdate(float deltaTime)
        {

        }

        /// <summary>
        ///  元素被显示出来
        /// </summary>
        public virtual void ElementDidAppear()
        {

        }

        /// <summary>
        ///  元素被隐藏
        /// </summary>
        public virtual void ElementDidDisAppear()
        {

        }

        /// <summary>
        ///  发送网络请求 
        /// </summary>
        /// <param name="messageType"></param>
        /// <param name="msg"></param>
        public void SendNetworkRequest(int messageType, object msg)
        {

        }

        /// <summary>
        ///  发送通知
        /// </summary>
        public void SendNotificationMessage(int messageType, object obj)
        {
            NotificationCenter.self.PostNotification(new NotificationMessage(messageType, null, obj));
        }


        public void PlayMusic(string assetBundlePackageName, string musicName)
        {
            AudioPlayer player = AudioManager.self.GetFreeAudioPlayer();
            player.SetAudioClipAndPlay(assetBundlePackageName, musicName);
        }


        /// <summary>
        ///  接收 通知中心 信息   对应发送消息 和 发送通知
        /// </summary>
        /// <param name="receiver">this</param>
        /// <param name="messageType"> 消息类型 int  </param>
        /// <param name="callback"> 信息回调 </param>
        public void ReceiveNotificationMessage(object receiver, int messageType, Action<NotificationMessage> callback)
        {
            if (!MessageTypeDic.ContainsKey(messageType))
            {
                MessageTypeDic.Add(messageType, null);
                NotificationCenter.self.AddObserver(receiver, messageType, callback);
            }
        }

        public void ShowToast(string text)
        {

        }

        /// <summary>
        ///  销毁elementBase 重载方法
        /// </summary>
        public virtual void Destory()
        {
            if (coroutineList != null)
            {
                for (int i = 0; i < coroutineList.Count; i++)
                {
                    StopCoroutine(coroutineList[i]);
                }
                coroutineList.Clear();
                coroutineList = null;
            }

            if (SubElementDic != null)
            {
                if (SubElementDic.Values.Count != 0)
                {
                    foreach (ElementBase val in SubElementDic.Values)
                    {
                        val.Destory();
                    }
                }
                SubElementDic.Clear();
                SubElementDic = null;
            }

            if (MessageTypeDic != null)
            {
                if (MessageTypeDic.Keys.Count != 0)
                {
                    foreach (var item in MessageTypeDic.Keys)
                    {
                        NotificationCenter.self.RemoveObserver(this, item);
                    }
                }
                MessageTypeDic.Clear();
                MessageTypeDic = null;
            }

            parent = null;
            gameObject = null;


            if (IsNeedUpdate == true)
            {
                IsNeedUpdate = false;
            }

            if (IsNeedFixedUpdate == true)
            {
                IsNeedFixedUpdate = false;
            }

            if (IsNeedLateUpdate == true)
            {
                IsNeedLateUpdate = false;
            }
        }

        /// <summary>
        ///  销毁游戏物体
        /// </summary>
        public void DestoryGameObject()
        {
            GameObject.Destroy(gameObject);
        }
    }
}



