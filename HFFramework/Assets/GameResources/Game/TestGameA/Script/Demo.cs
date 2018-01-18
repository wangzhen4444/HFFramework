﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HFFramework;
using System.Reflection;
using System;

public class Demo : BaseMonoBehaviour
{
    public UICanvas myCanvas;

    public List<UIController> testList = new List<UIController>();

    public bool isOpenUpdate = false;

    public void AssetBundleTest()
    {
        GameObject prefab = HAResourceManager.self.GetGameObject("Prefab", "Cube");
        GameObject.Instantiate(prefab);

        AssetBundlePackage ab = HAResourceManager.self.LoadAssetBundleFromFile("Prefab");
        GameObject g = ab.LoadAssetWithCache<GameObject>("Sphere");
        GameObject.Instantiate(g);

        HAResourceManager.self.UnloadAssetBundle(ab, false);

    }

    public void HotFixJump()
    {
        HFFramework.AppDomainManager.self.Jump(0, "HotFixDll", "HFFrameworkHotFix", "HotFixEnter");
    }

    public void OpenUpdate()
    {
        IsNeedUpdate = !IsNeedUpdate;
    }

    public void OpenFixedUpdate()
    {
        IsNeedFixedUpdate = !IsNeedFixedUpdate;
    }

    public void OpenLateUpdate()
    {
        IsNeedLateUpdate = !IsNeedLateUpdate;
    }

    public override void MyUpdate()
    {
        base.MyUpdate();
        Debug.Log("MyUpdate");
    }

    public override void MyFixedUpdate()
    {
        base.MyFixedUpdate();
        Debug.Log("MyFixedUpdate");
    }

    public override void MyLateUpdate()
    {
        base.MyLateUpdate();
        Debug.Log("MyLateUpdate");
    }

    public void 添加观察者()
    {
        ReceiveNotificationMessage(this, 100, delegate (NotificationMessage msg)
        {
            Debug.Log("拿到的信息是" + msg.obj as string);
        });
    }

    public void 发送消息()
    {
        SendNotificationMessage(100, "天下无敌");
    }

    public void 代码添加Canvas()
    {
        myCanvas = UIManager.self.AddCanvas(0);
    }

    public void push添加ViewController()
    {
        GameObject prefab = HAResourceManager.self.GetGameObject("Prefab", "VC");
        GameObject gx = GameObject.Instantiate(prefab);
        UIController testController = UIManager.GameObjectBindUIController<TestController, TestView, TestModel>(gx);
        myCanvas.PushController(testController,PushType.Navigation);
        testList.Add(testController);
    }

    public void pop移除ViewController()
    {
        if (testList.Count - 1>=0)
        {
            myCanvas.PopController(testList[testList.Count - 1], PopType.Cache);
            testList.RemoveAt(testList.Count - 1);
        }
    }

}