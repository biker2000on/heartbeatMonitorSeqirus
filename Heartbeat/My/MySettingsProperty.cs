// Decompiled with JetBrains decompiler
// Type: Heartbeat.My.MySettingsProperty
// Assembly: Heartbeat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D874299E-D5F4-45BA-9962-D3F2FFFF10FE
// Assembly location: \\prusntyfil01\home$\su009259\Documents\heartbeat\HeartbeatMonitoring\Heartbeat\Heartbeat.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Heartbeat.My
{
  [CompilerGenerated]
  [StandardModule]
  [DebuggerNonUserCode]
  [HideModuleName]
  internal sealed class MySettingsProperty
  {
    [HelpKeyword("My.Settings")]
    internal static MySettings Settings
    {
      get
      {
        MySettings mySettings = MySettings.Default;
        return mySettings;
      }
    }
  }
}
