﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace HFFramework
{
    /// <summary>
    ///  负责写入log 到本地
    /// </summary>
    public class GameLocalLogger : MonoBehaviour
    {
        public const string logFolderName = "Log";

        public StringBuilder logStr;

        public string timeTag;

        public int cacheCount = 50;

        private void Start()
        {
            bool isNewCreate = UtilsManager.CreateFolder(logFolderName);
            if (isNewCreate==false)
            {
                int fileCount = UtilsManager.GetFileCountInFolder(logFolderName);
                if (fileCount > cacheCount)
                {
                    UtilsManager.DeleteFolder(logFolderName);
                    UtilsManager.CreateFolder(logFolderName);
                }
            }

            logStr = new StringBuilder();
            timeTag = "Log/"+DateTime.Now.ToString().Replace(@"/","_");
            timeTag = timeTag.Replace(@"\", "_");
            timeTag = timeTag.Replace(@" ", "_");
            timeTag = timeTag.Replace(@":", "_");
            timeTag = timeTag + "Log.txt";
            UtilsManager.WriteFile(timeTag, logStr.ToString());
            Application.logMessageReceived += LogMessageReceived;
        }

        public  void LogMessageReceived(string condition, string stackTrace, LogType type)
        {
            logStr.Clear();
            logStr.AppendLine(condition);
            logStr.AppendLine(stackTrace);
            logStr.AppendLine(type.ToString());
            Task.Run(delegate ()
            {
                UtilsManager.WriteFile(timeTag, logStr.ToString(), FileMode.Append);
            });
        }

        private void OnDestroy()
        {
            Application.logMessageReceived -= LogMessageReceived;
            logStr.Clear();
        }
    }
}