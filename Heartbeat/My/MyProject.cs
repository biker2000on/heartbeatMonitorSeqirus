﻿// Decompiled with JetBrains decompiler
// Type: Heartbeat.My.MyProject
// Assembly: Heartbeat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D874299E-D5F4-45BA-9962-D3F2FFFF10FE
// Assembly location: \\prusntyfil01\home$\su009259\Documents\heartbeat\HeartbeatMonitoring\Heartbeat\Heartbeat.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Heartbeat.My
{
  [HideModuleName]
  [GeneratedCode("MyTemplate", "8.0.0.0")]
  [StandardModule]
  internal sealed class MyProject
  {
    private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
    private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

    [DebuggerNonUserCode]
    static MyProject()
    {
    }

    [HelpKeyword("My.Computer")]
    internal static MyComputer Computer
    {
      [DebuggerHidden] get => MyProject.m_ComputerObjectProvider.GetInstance;
    }

    [HelpKeyword("My.Application")]
    internal static MyApplication Application
    {
      [DebuggerHidden] get => MyProject.m_AppObjectProvider.GetInstance;
    }

    [HelpKeyword("My.User")]
    internal static User User
    {
      [DebuggerHidden] get => MyProject.m_UserObjectProvider.GetInstance;
    }

    [HelpKeyword("My.WebServices")]
    internal static MyProject.MyWebServices WebServices
    {
      [DebuggerHidden] get => MyProject.m_MyWebServicesObjectProvider.GetInstance;
    }

    [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class MyWebServices
    {
      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode() => base.GetHashCode();

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      internal new Type GetType() => typeof (MyProject.MyWebServices);

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override string ToString() => base.ToString();

      [DebuggerHidden]
      private static T Create__Instance__<T>(T instance) where T : new() => (object) instance == null ? new T() : instance;

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) => instance = default (T);

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public MyWebServices()
      {
      }
    }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [ComVisible(false)]
        internal sealed class ThreadSafeObjectProvider<T> where T : new()
        {
            internal T GetInstance
            {
                [DebuggerHidden]
                get
                {
                    if ((object)MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
                        MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
                    return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
                }
            }

            // per https://www.telerik.com/forums/justdecompiler-q2-2013
            [ThreadStatic, CompilerGenerated]
            private static T m_ThreadStaticValue;

            [EditorBrowsable(EditorBrowsableState.Never)]
            [DebuggerHidden]
            public ThreadSafeObjectProvider()
            {
            }
        }
    }
}
