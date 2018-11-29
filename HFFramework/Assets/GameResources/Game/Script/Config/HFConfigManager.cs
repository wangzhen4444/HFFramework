using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using System;
using HFFramework;
namespace Config
{ 
    [System.Serializable]
    public class HFConfigManager
    { 
        private static HFConfigManager instance;
        public static HFConfigManager Instance
        { 
            get 
            { 
                if (instance==null) 
                { 
                     instance = new HFConfigManager ();
                } 
                return instance;
            } 
        } 
        public void Init()
        { 
            ConfigAddress.Instance.StartAnalysis();
            ConfigGameSetting.Instance.StartAnalysis();
            ConfigMan.Instance.StartAnalysis();
            ConfigUI.Instance.StartAnalysis();
            HAResourceManager.Instance.UnloadAssetBundle("Config", false); 
        } 
    } 
} 
