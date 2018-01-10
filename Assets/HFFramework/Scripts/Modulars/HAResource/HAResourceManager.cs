﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using System.IO;
using Mono.Cecil.Pdb;

public class HAResourceManager : MonoBehaviour
{

    //注意  所有的 AssetBundlePackage读取 只能同步读取 因为牵扯到递归加载 
    //但是 AssetBundlePackage的每一个 具体的 asset资源 可以使用异步加载 

    public static HAResourceManager self;

    /// <summary>
    ///  assetbundle位置的根目录   默认的是所有的assetbundle 都放在一个文件夹下   
    /// </summary>
    public string ResourceRootPath;
    public string ResourceSpareRootPath;
    public string MainfestName;

    /// <summary>
    /// 上一个场景的ab
    /// </summary>
    private AssetBundle lastSceneBundle = null;

    /// <summary>
    ///  缓存AssetBundlePackage字典
    /// </summary>
    public Dictionary<string, AssetBundlePackage> allAssetBundleDic = new Dictionary<string, AssetBundlePackage>();

    /// <summary>
    ///  主要记录AssetBundle 之间的互相引用
    /// </summary>
    private AssetBundleManifest manifest;

    public void Awake()
    {
        self = this;
    }

    /// <summary>
    ///  自动寻找Assetbundle 在 persistentDataPath文件夹下（优先）  或者 StreamingAssets 文件夹下
    /// </summary>
    /// <param name="path"> 基础路径 </param>
    /// <param name="isWWW"> 是否通过www读取</param>
    /// <returns></returns>
    public string AutoGetResourcePath(string path, bool isWWW)
    {
        string newPath;
        if (isWWW)
        {
            //如果持久化路径有 就直接用
            if (File.Exists(ResourceRootPath + path))
            {
                newPath = "file://" + ResourceRootPath + path;
            }
            //否则使用 StreamingAssets 文件夹下的
            else
            {
                if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
                {
                    newPath = ResourceSpareRootPath + path;
                }
                else
                {
                    newPath = "file://" + ResourceSpareRootPath + path;
                }
            }
        }
        else
        {
            //如果持久化路径有 就直接用
            if (File.Exists(ResourceRootPath + path))
            {
                newPath = ResourceRootPath + path;
            }
            //否则使用 StreamingAssets 文件夹下的
            else
            {
                newPath = ResourceSpareRootPath + path;
            }
        }

        return newPath;
    }

    /// <summary>
    ///  初始化方法 一般只执行一次
    /// </summary>
    /// <param name="path"></param>
    public void InitWithRootPath(string resourceRootPath, string resourceSpareRootPath, string mainfestName)
    {

        Debug.Log("正式资源地址" + resourceRootPath);
        Debug.Log("备用资源地址" + resourceSpareRootPath);
        Caching.CleanCache();

        if (!string.IsNullOrEmpty(resourceRootPath) && !string.IsNullOrEmpty(resourceSpareRootPath))
        {
            if (!string.Equals(resourceRootPath.Substring(resourceRootPath.Length - 1), @"/"))
            {
                resourceRootPath = resourceRootPath + @"/";
            }

            if (!string.Equals(resourceSpareRootPath.Substring(resourceSpareRootPath.Length - 1), @"/"))
            {
                resourceSpareRootPath = resourceSpareRootPath + @"/";
            }

            ResourceRootPath = resourceRootPath;
            ResourceSpareRootPath = resourceSpareRootPath;
            MainfestName = mainfestName;
            GetAssetBundleManifest();
        }
    }

    /// <summary>
    ///  拿到AssetBundleManifest 以便于收集 所有的assetbundle 依赖
    /// </summary>
    private void GetAssetBundleManifest()
    {
        AssetBundle manifestAB = AssetBundle.LoadFromFile(AutoGetResourcePath(MainfestName, false));  // 加载总ManifestAssetBundle
        if (manifestAB != null)
        {
            manifest = (AssetBundleManifest)manifestAB.LoadAsset("AssetBundleManifest");
            manifestAB.Unload(false);  // 释放AssetBundle
        }
    }

    /// <summary>
    ///  拿到具体的某一个Assetbundle 的所有依赖  很多情况需要递归加载
    /// </summary>
    /// <param name="assetbundleName"></param>
    /// <returns></returns>
    public string[] GetAssetBundleDependencies(string assetbundleName)
    {
        return manifest.GetAllDependencies(assetbundleName);  // 结果 sprite1.ab 
    }


    /// <summary>
    /// 获取 GameObject 通过缓存 不会自动销毁
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public GameObject GetGameObject(string packageName, string abName)
    {
        AssetBundlePackage ab = HAResourceManager.self.LoadAssetBundleFromFile(packageName);
        GameObject g = ab.LoadAssetWithCache<GameObject>(abName);
        return g;
    }

    public Material GetMatial(string packageName, string abName)
    {
        AssetBundlePackage ab = HAResourceManager.self.LoadAssetBundleFromFile(packageName);
        Material g = ab.LoadAssetWithCache<Material>(abName);
        return g;
    }

    /// <summary>
    /// 获取 Sprite 通过缓存 不会自动卸载
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public Sprite GetSprite(string packageName, string abName)
    {
        AssetBundlePackage ab = HAResourceManager.self.LoadAssetBundleFromFile(packageName);
        Sprite sp = ab.LoadAssetWithCache<Sprite>(abName);
        return sp;
    }

    /// <summary>
    /// 获取 Audio
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public AudioClip GetAudio(string packageName, string abName)
    {
        AssetBundlePackage ab = HAResourceManager.self.LoadAssetBundleFromFile(packageName);
        AudioClip audio = ab.LoadAssetWithCache<AudioClip>(abName);
        return audio;
    }

    /// <summary>
    ///  异步加载场景
    /// </summary>
    /// <param name="assetBundleName"></param>
    /// <param name="autoJump"></param>
    /// <param name="sceneName"></param>
    /// <param name="finishCallBack"></param>
    public void LoadScene(string assetBundleName, bool autoJump, string sceneName, Action<AssetBundlePackage> finishCallBack)
    {
        StartCoroutine(m_LoadScene(assetBundleName, autoJump, sceneName, finishCallBack));
    }

    /// <summary>
    ///  加载场景
    /// </summary>
    /// <param name="assetBundleName"></param>
    /// <param name="finishCallBack"></param>
    /// <returns></returns>
    private IEnumerator m_LoadScene(string assetBundleName, bool autoJump, string sceneName, Action<AssetBundlePackage> finishCallBack)
    {
        assetBundleName = assetBundleName.ToLower();
        if (!allAssetBundleDic.ContainsKey(assetBundleName))
        {
            WWW w = WWW.LoadFromCacheOrDownload(AutoGetResourcePath(assetBundleName, true), 0);
            yield return w;

            AssetBundle bundle = w.assetBundle;
            if (finishCallBack != null && autoJump && !string.IsNullOrEmpty(sceneName))
            {
                //这里会报错主要出现在加载大厅场景和中发白场景的时候
                //报错提示 Assertion failed on expression: 'Thread::CurrentThreadIsMainThread()' 可以查一下问题
                AsyncOperation ab = SceneManager.LoadSceneAsync(sceneName);
                yield return ab;
                Resources.UnloadUnusedAssets();
                finishCallBack(null);
                if (lastSceneBundle != null)
                {
                    lastSceneBundle.Unload(true);
                    lastSceneBundle = null;
                }
                lastSceneBundle = bundle;
            }
            else
            {
                if (finishCallBack != null)
                {
                    finishCallBack(null);
                }
            }
        }
        else
        {
            SceneManager.LoadScene(sceneName);
            Resources.UnloadUnusedAssets();
            yield return null;
        }
    }

    /// <summary>
    ///  获取资源 在callback 之后自动销毁解压出来的各种资源 一般适用于只创建一次的预设体 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="packageName"></param>
    /// <param name="assetName"></param>
    /// <param name="callBack"></param>
    public void GetAssetWithAutoKill<T>(string packageName, string assetName, Action<T> callBack) where T : UnityEngine.Object
    {
        AssetBundlePackage ab = HAResourceManager.self.LoadAssetBundleFromFile(packageName);
        T ta = ab.assetBundle.LoadAsset<T>(assetName);
        callBack(ta);
        UnloadAssetBundle(ab, false);
    }

    /// <summary>
    ///  备注 LoadFromMemory 垃圾
    ///  一般来说，尽可能使用AssetBundle.LoadFromFile。该API在速度，磁盘使用率和运行时内存使用方面是最有效的
    /// </summary>
    public AssetBundlePackage LoadAssetBundleFromFile(string assetBundleName)
    {
        assetBundleName = assetBundleName.ToLower();
        string[] list = self.GetAssetBundleDependencies(assetBundleName);
        if (list.Length != 0)
        {
            for (int i = 0; i < list.Length; i++)
            {
                LoadAssetBundleFromFile(list[i]);
            }
        }

        if (!allAssetBundleDic.ContainsKey(assetBundleName))
        {
            AssetBundle bundle = AssetBundle.LoadFromFile(AutoGetResourcePath(assetBundleName, false));
            AssetBundlePackage tmpAssetBundle = new AssetBundlePackage(bundle, assetBundleName);
            AddAssetBundleToDic(tmpAssetBundle);
            return tmpAssetBundle;
        }
        else
        {
            return allAssetBundleDic[assetBundleName];
        }
    }

    /// <summary>
    ///  加载一系列 的assetbundle
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    public List<AssetBundlePackage> LoadAssetsBundlesFromFile(string[] list, Action<float> progressCallback)
    {
        List<AssetBundlePackage> bundles = new List<AssetBundlePackage>();
        for (int i = 0; i < list.Length; i++)
        {
            AssetBundlePackage bundle = LoadAssetBundleFromFile(list[i]);
            if (bundle != null)
            {
                bundles.Add(bundle);
            }
            if (progressCallback != null)
            {
                progressCallback((bundles.Count + 0.0f) / list.Length);
            }
        }
        return bundles;
    }

    public void LoadAssetsBundlesFromFileAsyc(string[] list, Action<float> progressCallback)
    {
        StartCoroutine(m_LoadAssetsBundlesFromFileAsyc(list, progressCallback));
    }

    private IEnumerator m_LoadAssetsBundlesFromFileAsyc(string[] list, Action<float> progressCallback)
    {
        List<AssetBundlePackage> bundles = new List<AssetBundlePackage>();
        for (int i = 0; i < list.Length; i++)
        {
            AssetBundlePackage bundle = LoadAssetBundleFromFile(list[i]);
            if (bundle != null)
            {
                bundles.Add(bundle);
            }
            yield return null;
            if (progressCallback != null)
            {
                progressCallback((bundles.Count + 0.0f) / list.Length);
            }
        }
    }

    public void LoadHotFixAssembly(string assetbundleName,string dllName, ILRuntime.Runtime.Enviorment.AppDomain appdomain, Action<bool> cbAction)
    {
        AssetBundlePackage ab = HAResourceManager.self.LoadAssetBundleFromFile(assetbundleName);
        TextAsset text = ab.LoadAssetWithCache<TextAsset>(dllName + ".dll");
        byte[] dll = text.bytes;
        using (MemoryStream fs = new MemoryStream(dll))
        {
            appdomain.LoadAssembly(fs, null, new PdbReaderProvider());
        }
        if (cbAction != null)
        {
            cbAction(true);
        }
    }

    public void AddAssetBundleToDic(AssetBundlePackage bundle)
    {
        if (!allAssetBundleDic.ContainsKey(bundle.name))
        {
            allAssetBundleDic.Add(bundle.name, bundle);
        }
        else
        {
            Debug.Log("资源加载重复");
        }
    }

    public AssetBundlePackage GetAssetBundleWithName(string name)
    {
        name = name.ToLower();
        if (allAssetBundleDic.ContainsKey(name))
        {
            return allAssetBundleDic[name];
        }
        return null;
    }


    /// <summary>
    ///  卸载某一个 assetbundle 通过名字
    /// </summary>
    /// <param name="name"></param>
    /// <param name="b">是否卸载压出来的的东西</param>
    public void UnloadAssetBundle(string name, bool b = true)
    {
        name = name.ToLower();
        AssetBundlePackage bundle = GetAssetBundleWithName(name);
        if (bundle != null)
        {
            bundle.Unload(b);
            allAssetBundleDic.Remove(name);
        }
    }


    /// <summary>
    ///  卸载一系列的 的assetbundle
    /// </summary>
    /// <param name="list"></param>
    public void UnloadAssetBundles(string[] list, Action<float> progressCallback)
    {
        for (int i = 0; i < list.Length; i++)
        {
            UnloadAssetBundle(list[i]);
            if (progressCallback != null)
            {
                progressCallback((i + 0.0f) / list.Length);
            }
        }
    }


    public void UnloadAssetBundle(AssetBundlePackage bundle, bool b = true)
    {
        if (bundle != null && !string.IsNullOrEmpty(bundle.name))
        {
            allAssetBundleDic.Remove(bundle.name);
            bundle.Unload(b);
        }
    }


    /// <summary>
    ///  卸载所有的 assetBundle
    /// </summary>
    public void UnloadAllAssetBundle()
    {
        foreach (var item in allAssetBundleDic.Values)
        {
            item.Unload(true);
        }
        allAssetBundleDic.Clear();
        Resources.UnloadUnusedAssets();
    }


    void OnDestroy()
    {
        self = null;
        UnloadAllAssetBundle();
    }

    /*
    public void UnloadAllAssetBundleAndSave(List<string> saveListName)
    {
        foreach (var item in allAssetBundleDic.Values)
        {
            item.Unload(true);
        }
        allAssetBundleDic.Clear();
        Resources.UnloadUnusedAssets();
    }
    */
}


public class AssetBundlePackage
{
    public string name;
    public AssetBundle assetBundle;
    private Dictionary<string, UnityEngine.Object> cacheDic;
    public Dictionary<string, UnityEngine.Object> CacheDic
    {
        set
        {
            cacheDic = value;
        }
        get
        {
            if (cacheDic == null)
            {
                cacheDic = new Dictionary<string, UnityEngine.Object>();
            }
            return cacheDic;
        }
    }

    public AssetBundlePackage(AssetBundle bundle, string n)
    {
        n = n.ToLower();
        name = n;
        assetBundle = bundle;
    }

    public void Unload(bool t)
    {
        if (assetBundle != null)
        {
            if (t)
            {
                CacheDic.Clear();
                assetBundle.Unload(t);
                CacheDic = null;
                assetBundle = null;
                name = null;
            }
            else
            {
                assetBundle.Unload(t);
                CacheDic = null;
                assetBundle = null;
            }
        }
    }


    /// <summary>
    ///  通过缓存读取 文件 比如很多情况下读取图片会有很多次 那么如果不缓存的话就会形成很多副本 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="name"></param>
    /// <returns></returns>
    public T LoadAssetWithCache<T>(string name) where T : UnityEngine.Object
    {
        //
        if (CacheDic.ContainsKey(name))
        {
            return CacheDic[name] as T;
        }
        else
        {
            T t1 = assetBundle.LoadAsset<T>(name);
            if (t1 != null)
            {
                CacheDic.Add(name, t1);
                return t1;
            }
            else
            {
                return null;
            }
        }
    }

    /// <summary>
    ///  通过缓存读取 文件 比如很多情况下读取图片会有很多次 那么如果不缓存的话就会形成很多副本 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="name"></param>
    /// <returns></returns>
    public UnityEngine.Object LoadAssetWithCache(string name)
    {
        if (CacheDic.ContainsKey(name))
        {
            return CacheDic[name];
        }
        else
        {
            UnityEngine.Object t1 = assetBundle.LoadAsset(name);
            if (t1 != null)
            {
                CacheDic.Add(name, t1);
                return t1;
            }
            else
            {
                return null;
            }
        }
    }


    public void LoadAssetWithCacheAsyc<T>(string name, Action<T> callback) where T : UnityEngine.Object
    {
        GameLooper.self.StartCoroutine(m_LoadAssetWithCacheAsyc(name, callback));
    }


    private IEnumerator m_LoadAssetWithCacheAsyc<T>(string name, Action<T> callback) where T : UnityEngine.Object
    {
        if (CacheDic.ContainsKey(name))
        {
            callback(CacheDic[name] as T);
        }
        else
        {
            AssetBundleRequest request = assetBundle.LoadAssetAsync<T>(name);
            yield return request;
            T t1 = request.asset as T;
            if (t1 != null)
            {
                CacheDic.Add(name, t1);
                callback(t1);
            }
            else
            {
                callback(null);
            }
        }
    }



    /// <summary>
    ///  缓存所有的包内资源 
    /// </summary>
    public void CacheAllAsset()
    {
        UnityEngine.Object[] assetArray = assetBundle.LoadAllAssets();
        for (int i = 0; i < assetArray.Length; i++)
        {
            UnityEngine.Object asset = assetArray[i];
            if (!CacheDic.ContainsKey(asset.name))
            {
                CacheDic.Add(asset.name, asset);
            }
        }
    }
}