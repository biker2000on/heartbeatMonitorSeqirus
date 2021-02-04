// Decompiled with JetBrains decompiler
// Type: Heartbeat.My.Resources.Resources
// Assembly: Heartbeat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D874299E-D5F4-45BA-9962-D3F2FFFF10FE
// Assembly location: \\prusntyfil01\home$\su009259\Documents\heartbeat\HeartbeatMonitoring\Heartbeat\Heartbeat.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Heartbeat.My.Resources
{
  [CompilerGenerated]
  [StandardModule]
  [DebuggerNonUserCode]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [HideModuleName]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) Heartbeat.My.Resources.Resources.resourceMan, (object) null))
          Heartbeat.My.Resources.Resources.resourceMan = new ResourceManager("Heartbeat.Resources", typeof (Heartbeat.My.Resources.Resources).Assembly);
        return Heartbeat.My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => Heartbeat.My.Resources.Resources.resourceCulture;
      set => Heartbeat.My.Resources.Resources.resourceCulture = value;
    }
  }
}
