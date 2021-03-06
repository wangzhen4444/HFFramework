﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFFramework
{
    public class BaseMonoBehaviour : MonoBehaviour
    {
        /// <summary>
        ///  每一个gameObject 独有的 id
        /// </summary>
        [HideInInspector]
        public int myInstanceID;

        /// <summary>
        ///  缓存的transform
        /// </summary>
        [HideInInspector]
        public Transform myTransform;

        [HideInInspector]
        public string gameObjectName;

        [HideInInspector]
        public string gameObjectTag;

        /// <summary>
        ///  注册的消息 字典   Destroy会自动销毁
        /// </summary>
        public Dictionary<ulong, object> messageTypeDic;
        public Dictionary<ulong, object> MessageTypeDic
        {
            set
            {
                messageTypeDic = value;
            }
            get
            {
                if (messageTypeDic == null)
                {
                    messageTypeDic = new Dictionary<ulong, object>();
                }
                return messageTypeDic;
            }
        }

        private bool isActive;
        public virtual bool IsActive
        {
            set
            {
                if (gameObject.activeSelf != value)
                {
                    isActive = value;
                    gameObject.SetActive(isActive);

                    if (value == true)
                    {
                        ElementDidAppear();
                    }
                    else
                    {
                        ElementDidDisAppear();
                    }
                }
            }
            get
            {
                return isActive;
            }
        }

        public void Awake()
        {
            OnAwake();
        }

        public virtual void OnAwake()
        {
            myTransform = gameObject.transform;
            myInstanceID = gameObject.GetInstanceID();
            gameObjectName = gameObject.name;
            gameObjectTag = gameObject.tag;
        }

        public virtual void FindElement()
        {

        }

        /// <summary>
        ///  发送消息
        /// </summary>
        public void SendNotificationMessage(ushort moduleID, int msgID, object obj)
        {
            NotificationCenter.PostNotification(new NotificationMessage(moduleID, msgID, this, obj));
        }

        /// <summary>
        ///  发送网络请求 
        /// </summary>
        /// <param name="messageType"></param>
        /// <param name="msg"></param>
        public virtual void SendNetworkRequest(int messageType, object msg)
        {

        }

        /// <summary>
        ///  寻找子物体组件方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        public T FindChild<T>(string path)
        {
            return myTransform.Find(path).GetComponent<T>();
        }

        public T AutoFind<T>(string path = null)
        {
            if (String.IsNullOrEmpty(path))
            {
                return gameObject.GetComponent<T>();
            }
            else
            {
                return myTransform.Find(path).GetComponent<T>();
            }
        }

        /// <summary>
        ///  寻找 子游戏物体 
        /// </summary>
        /// <param name="path">路径</param>
        /// <returns></returns>
        public GameObject FindChild(string path)
        {
            return myTransform.Find(path).gameObject;
        }

        /// <summary>
        ///  设置父物体
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="worldPositionStays"></param>
        public void SetParent(GameObject parent, bool worldPositionStays = false)
        {
            myTransform.SetParent(parent.transform, worldPositionStays);
        }

        public void SetParent(MonoBehaviour parent, bool worldPositionStays = false)
        {
            myTransform.SetParent(parent.transform, worldPositionStays);
        }

        bool isNeedUpdate = false;
        /// <summary>
        ///  是否需要开启Update
        /// </summary>
        public bool IsNeedUpdate
        {
            set
            {
                if (isNeedUpdate != value)
                {
                    isNeedUpdate = value;
                    GameLooper.PrepareForUpdate(this);
                }
            }
            get
            {
                return isNeedUpdate;
            }
        }

        bool isNeedFixedUpdate = false;
        /// <summary>
        ///  是否需要开启FixedUpdate
        /// </summary>
        public bool IsNeedFixedUpdate
        {
            set
            {
                if (value != isNeedFixedUpdate)
                {
                    isNeedFixedUpdate = value;
                    GameLooper.PrepareForFixedUpdate(this);
                }
            }
            get
            {
                return isNeedFixedUpdate;
            }
        }

        bool isNeedLateUpdate = false;
        /// <summary>
        ///  是否需要 开启 LateUpdate
        /// </summary>
        public bool IsNeedLateUpdate
        {
            set
            {
                if (value != isNeedLateUpdate)
                {
                    isNeedLateUpdate = value;
                    GameLooper.PrepareForLateUpdate(this);
                }
            }
            get
            {
                return isNeedLateUpdate;
            }
        }

        public void ReceiveNotificationMessage(object receiver, ushort moduleID, int msgID, Action<NotificationMessage> callback)
        {
            object temp;
            ulong key = NotificationCenter.ConvertToKey(moduleID, msgID);
            if (!MessageTypeDic.TryGetValue(key, out temp))
            {
                MessageTypeDic.Add(key, null);
                NotificationCenter.Instance.AddObserver(receiver, moduleID, msgID, callback);
            }
        }

        public virtual void OnUpdate(float deltaTime)
        {

        }

        public virtual void OnFixedUpdate(float deltaTime)
        {

        }

        public virtual void OnLateUpdate(float deltaTime)
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

        public void BringSelfToFront()
        {
            myTransform.SetAsLastSibling();
        }

        public void BringSelfToBack()
        {
            myTransform.SetAsFirstSibling();
        }

        public void OnDestroy()
        {
            Destroy();
        }

        /// <summary>
        ///  销毁对应的重载方法 具体是否销毁对象自行决定 
        ///  OnDestroy（Unity反射方法） 会自动调用一次 Destroy
        ///  也可以手动调用
        /// </summary>
        public virtual void Destroy()
        {
            IsNeedUpdate = false;
            IsNeedLateUpdate = false;
            IsNeedFixedUpdate = false;

            if (messageTypeDic != null&& NotificationCenter.Instance!=null)
            {
                foreach (var item in messageTypeDic)
                {
                    NotificationCenter.Instance.RemoveObserver(this, item.Key);
                }
                messageTypeDic.Clear();
                messageTypeDic = null;
            }
        }
    }
}
