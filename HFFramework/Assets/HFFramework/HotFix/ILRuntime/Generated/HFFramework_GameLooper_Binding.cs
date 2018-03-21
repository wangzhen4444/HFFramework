using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class HFFramework_GameLooper_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(HFFramework.GameLooper);

            field = type.GetField("self", flag);
            app.RegisterCLRFieldGetter(field, get_self_0);
            app.RegisterCLRFieldSetter(field, set_self_0);


        }



        static object get_self_0(ref object o)
        {
            return HFFramework.GameLooper.self;
        }
        static void set_self_0(ref object o, object v)
        {
            HFFramework.GameLooper.self = (HFFramework.GameLooper)v;
        }


    }
}