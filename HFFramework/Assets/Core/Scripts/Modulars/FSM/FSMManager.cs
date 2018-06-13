﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFFramework
{
    public class FSMManager
    {   
        /// <summary>
        ///  缓存状态的字典
        /// </summary>
        private Dictionary<string, FSMBaseState> allStateDic = new Dictionary<string, FSMBaseState>();

        private FSMBaseState currentState;
        /// <summary>
        ///  获取当前正在执行的状态
        /// </summary>
        public FSMBaseState CurrentState
        {
            set
            {
                currentState = value;
            }
            get
            {
                return currentState;
            }
        }

        /// <summary>
        ///  构造方法
        /// </summary>
        public FSMManager()
        {
            FSMBaseState rootState = new FSMBaseState(FSMBaseState.RootState,this);
            AddState(rootState);
            TranslateToState(FSMBaseState.RootState);
        }

        /// <summary>
        ///  添加一个状态
        /// </summary>
        /// <param name="state"></param>
        public void AddState(FSMBaseState state)
        {
            if (!allStateDic.ContainsKey(state.stateName))
            {
                this[state.stateName] = state;
            }
        }

        /// <summary>
        ///  转移到某个状态
        /// </summary>
        /// <param name="stateName"></param>
        public void TranslateToState(string stateName)
        {
            if (CurrentState != null)
            {
                if (stateName != CurrentState.stateName)
                {
                    CurrentState.OnStateInvoke(StateEnum.StateExit);
                    CurrentState = this[stateName];
                    CurrentState.OnStateInvoke(StateEnum.StateEnter);
                }
            }
            else
            {
                CurrentState = this[stateName];
                CurrentState.OnStateInvoke(StateEnum.StateEnter);
            }
        }

        public void Update()
        {
            if (CurrentState != null)
            {
                currentState.OnStateInvoke(StateEnum.StateStay);
            }
        }


        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="name">Name.</param>
        public FSMBaseState this[string name]
        {
            get
            {
                return allStateDic[name];
            }
            set
            {
                allStateDic[name] = value;
            }
        }
    }
}