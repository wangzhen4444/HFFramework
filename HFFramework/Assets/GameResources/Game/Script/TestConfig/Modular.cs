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
    public class Modular
    { 
        /// <summary>
        /// 道具id
        /// <summary>
        public int id;
        /// <summary>
        /// 名称
        /// <summary>
        public string name;
        /// <summary>
        /// 描述
        /// <summary>
        public string description;
        /// <summary>
        /// 道具icon
        /// <summary>
        public string itemIcon;
        /// <summary>
        /// icon路径
        /// <summary>
        public string iconPath;
        /// <summary>
        /// 类别
        /// <summary>
        public List<int>type = new List<int>();
    }

    [System.Serializable]
    public class ConfigModular
    { 
        public static string[] split = new string[] { "," };
        public static string[] splitArray = new string[] { ";", "[", "]" };

        private static ConfigModular instance;
        public static ConfigModular Instance
        { 
            get 
            { 
                if (instance==null) 
                { 
                     instance = new ConfigModular ();
                } 
                return instance;
            } 
        } 

        public Dictionary<int , Modular> dic = new Dictionary<int , Modular>();

        public List<Modular> list = new List<Modular>();

        public  static Modular Get(int id)
        {
            Modular temp;
            Instance.dic.TryGetValue(id, out temp);
            return temp;
        }

        public void StartAnalysis()
        {
            AssetBundlePackage package = HAResourceManager.Instance.LoadAssetBundleFromFile("Config");
            TextAsset textAsset = package.LoadAssetWithCache<TextAsset>("Modular");
            StringReader reader = new StringReader(textAsset.text);
            string notes = reader.ReadLine();
            string names = reader.ReadLine();
            reader.ReadLine();
            reader.ReadLine();
            string types = reader.ReadLine();
            while (true)
            {
                string row = reader.ReadLine();
                if (string.IsNullOrEmpty(row))
                {
                    break;
                }
                string[] strs = row.Split(split, StringSplitOptions.None);
                if (strs.Length > 0)
                {
                    Modular config = new Modular();
                    int.TryParse(strs[0], out config.id);
                    config.name = strs[1];
                    config.description = strs[2];
                    config.itemIcon = strs[3];
                    config.iconPath = strs[4];
                    string[] air = strs[5].Split(splitArray, StringSplitOptions.RemoveEmptyEntries);
                    for (int x = 0; x < air.Length; x++)
                    {
                       int ite = 0;
                       int.TryParse(air[x], out ite);
                       config.type.Add(ite);
                     }
                    dic.Add(config.id, config );
                    list.Add(config);
               }
           }
           notes = null;
           names = null;
           types = null;
        }
    }
}