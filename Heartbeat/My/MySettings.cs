// Decompiled with JetBrains decompiler
// Type: Heartbeat.My.MySettings
// Assembly: Heartbeat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D874299E-D5F4-45BA-9962-D3F2FFFF10FE
// Assembly location: \\prusntyfil01\home$\su009259\Documents\heartbeat\HeartbeatMonitoring\Heartbeat\Heartbeat.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Heartbeat.My
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
  [CompilerGenerated]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());

    [DebuggerNonUserCode]
    public MySettings()
    {
    }

    public static MySettings Default
    {
      get
      {
        MySettings defaultInstance = MySettings.defaultInstance;
        return defaultInstance;
      }
    }
  }
}
