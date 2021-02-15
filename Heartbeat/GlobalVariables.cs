// Decompiled with JetBrains decompiler
// Type: Heartbeat.GlobalVariables
// Assembly: Heartbeat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D874299E-D5F4-45BA-9962-D3F2FFFF10FE
// Assembly location: \\prusntyfil01\home$\su009259\Documents\heartbeat\HeartbeatMonitoring\Heartbeat\Heartbeat.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;

namespace Heartbeat
{
  public class GlobalVariables
  {
    [DebuggerNonUserCode]
    public GlobalVariables()
    {
    }

    public static string GetFileContents(string FullPath, ref string ErrInfo)
    {
      string str;
      try
      {
        StreamReader streamReader = new StreamReader(FullPath);
        string end = streamReader.ReadToEnd();
        streamReader.Close();
        str = end;
        return str;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        ErrInfo = exception.Message;
        ProjectData.ClearProjectError();
      }
      return "";
    }

    public static bool SaveTextToFile(string strData, string FullPath, string ErrInfo = "")
    {
      bool flag = false;
      try
      {
        StreamWriter streamWriter = new StreamWriter(FullPath, true);
        streamWriter.Write(strData);
        streamWriter.Close();
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrInfo = ex.Message;
        ProjectData.ClearProjectError();
      }
      return flag;
    }
  }
}
