﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EnhancedUI.EnhancedScroller;

namespace HFFramework
{
    public class LogCell : EnhancedScrollerCellView
    {
        public Text cellText;

        public int index;

        public void SetData(LogInfo info,int index)
        {
            cellText.text = info.condition;
            this.index = index;
        }
    }
}

