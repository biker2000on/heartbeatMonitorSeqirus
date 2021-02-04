// Decompiled with JetBrains decompiler
// Type: Heartbeat.HeartbeatMonitoring
// Assembly: Heartbeat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D874299E-D5F4-45BA-9962-D3F2FFFF10FE
// Assembly location: \\prusntyfil01\home$\su009259\Documents\heartbeat\HeartbeatMonitoring\Heartbeat\Heartbeat.exe

using Microsoft.VisualBasic.CompilerServices;
using PISDK;
using PISDKDlg;
using System;
using System.Diagnostics;
using System.Net.Mail;
using System.Threading;

namespace Heartbeat
{
  [StandardModule]
  internal sealed class HeartbeatMonitoring
  {
    [STAThread]
    public static void Main()
    {
label_1:
      int num1;
      int num2;
      try
      {
        int num3 = 1;
        Connections connections1 = (Connections) new ConnectionsClass();
label_2:
        num3 = 2;
        PISDK.PISDK pisdk = (PISDK.PISDK) new PISDKClass();
label_3:
        num3 = 3;
        string str1 = "D:\\Reports\\HeartbeatMonitoring\\Heartbeat\\tag.txt";
label_4:
        num3 = 4;
        string fileName = "D:\\Reports\\HeartbeatMonitoring\\rtreportsdisable.bat";
label_5:
        ProjectData.ClearProjectError();
        num1 = -2;
label_6:
label_7:
        num3 = 6;
        string str2 = "pidemo";
label_8:
        num3 = 7;
        string str3 = "Fac0ps";
label_9:
        num3 = 8;
        Connections connections2 = connections1;
        Server server1 = (Server) null;
        ref Server local1 = ref server1;
        ref string local2 = ref str2;
        ref string local3 = ref str3;
        Server server2 = connections2.Login(ref local1, ref local2, ref local3, false, false);
label_10:
        num3 = 9;
        bool connected = server2.Connected;
label_11:
        num3 = 10;
        string FullPath = str1;
        string str4 = "";
        ref string local4 = ref str4;
        string fileContents1 = GlobalVariables.GetFileContents(FullPath, ref local4);
label_12:
        num3 = 11;
        PIPoint point = pisdk.GetPoint(fileContents1);
label_13:
        num3 = 12;
        DigitalState digitalState = (DigitalState) point.Data.Snapshot.Value;
label_14:
        num3 = 13;
        object code = (object) digitalState.Code;
label_15:
        num3 = 14;
        if (!connected)
          goto label_52;
        else
          goto label_51;
label_16:
label_17:
        num3 = 17;
        Thread.Sleep(10000);
label_18:
        num3 = 18;
        point = pisdk.GetPoint(Conversions.ToString(code));
label_19:
        num3 = 19;
        digitalState = (DigitalState) point.Data.Snapshot.Value;
label_20:
        num3 = 20;
        code = (object) digitalState.Code;
label_21:
        num3 = 21;
        if (Operators.ConditionalCompareObjectEqual(code, (object) "0", false))
          goto label_16;
label_22:
        num3 = 24;
label_23:
        num3 = 25;
        Process.Start(fileName);
label_24:
        num3 = 26;
        SmtpClient smtpClient = new SmtpClient();
label_25:
        num3 = 27;
        MailMessage message = new MailMessage();
label_26:
        num3 = 28;
        string ErrInfo1 = "";
        string fileContents2 = GlobalVariables.GetFileContents("D:\\Reports\\HeartbeatMonitoring\\Heartbeat\\Email\\sender.txt", ref ErrInfo1);
label_27:
        num3 = 29;
        string ErrInfo2 = "";
        string fileContents3 = GlobalVariables.GetFileContents("D:\\Reports\\HeartbeatMonitoring\\Heartbeat\\Email\\host.txt", ref ErrInfo2);
label_28:
        num3 = 30;
        string ErrInfo3 = "";
        string fileContents4 = GlobalVariables.GetFileContents("D:\\Reports\\HeartbeatMonitoring\\Heartbeat\\Email\\recipients.txt", ref ErrInfo3);
label_29:
        num3 = 31;
        string ErrInfo4 = "";
        string fileContents5 = GlobalVariables.GetFileContents("D:\\Reports\\HeartbeatMonitoring\\Heartbeat\\Email\\subject.txt", ref ErrInfo4);
label_30:
        num3 = 32;
        string ErrInfo5 = "";
        string fileContents6 = GlobalVariables.GetFileContents("D:\\Reports\\HeartbeatMonitoring\\Heartbeat\\Email\\body.txt", ref ErrInfo5);
label_31:
        num3 = 33;
        string ErrInfo6 = "";
        string fileContents7 = GlobalVariables.GetFileContents("D:\\Reports\\HeartbeatMonitoring\\Heartbeat\\Email\\port.txt", ref ErrInfo6);
label_32:
        num3 = 34;
        smtpClient.Port = Conversions.ToInteger(fileContents7);
label_33:
        num3 = 35;
        smtpClient.Host = fileContents3;
label_34:
        num3 = 36;
        smtpClient.EnableSsl = false;
label_35:
        num3 = 37;
        message = new MailMessage();
label_36:
        num3 = 38;
        message.From = new MailAddress(fileContents2);
label_37:
        num3 = 39;
        message.To.Add(fileContents4);
label_38:
        num3 = 40;
        message.Subject = fileContents5;
label_39:
        num3 = 41;
        message.Body = fileContents6;
label_40:
        num3 = 42;
        smtpClient.Send(message);
label_41:
label_42:
        num3 = 44;
        Thread.Sleep(10000);
label_43:
        num3 = 45;
        point = pisdk.GetPoint(Conversions.ToString(code));
label_44:
        num3 = 46;
        digitalState = (DigitalState) point.Data.Snapshot.Value;
label_45:
        num3 = 47;
        code = (object) digitalState.Code;
label_46:
        num3 = 48;
        if (Operators.ConditionalCompareObjectEqual(code, (object) "0", false))
          goto label_49;
label_47:
        num3 = 51;
label_48:
        goto label_42;
label_49:
label_50:
label_51:
        num3 = 16;
        if (connected)
          goto label_16;
        else
          goto label_53;
label_52:
        num3 = 57;
        goto label_6;
label_53:
        goto label_60;
label_55:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num4 = num2 + 1;
            num2 = 0;
            switch (num4)
            {
              case 1:
                goto label_1;
              case 2:
                goto label_2;
              case 3:
                goto label_3;
              case 4:
                goto label_4;
              case 5:
                goto label_5;
              case 6:
                goto label_7;
              case 7:
                goto label_8;
              case 8:
                goto label_9;
              case 9:
                goto label_10;
              case 10:
                goto label_11;
              case 11:
                goto label_12;
              case 12:
                goto label_13;
              case 13:
                goto label_14;
              case 14:
                goto label_15;
              case 15:
              case 16:
                goto label_51;
              case 17:
                goto label_17;
              case 18:
                goto label_18;
              case 19:
                goto label_19;
              case 20:
                goto label_20;
              case 21:
                goto label_21;
              case 22:
                goto label_16;
              case 23:
              case 49:
              case 54:
                goto label_49;
              case 24:
                goto label_22;
              case 25:
                goto label_23;
              case 26:
                goto label_24;
              case 27:
                goto label_25;
              case 28:
                goto label_26;
              case 29:
                goto label_27;
              case 30:
                goto label_28;
              case 31:
                goto label_29;
              case 32:
                goto label_30;
              case 33:
                goto label_31;
              case 34:
                goto label_32;
              case 35:
                goto label_33;
              case 36:
                goto label_34;
              case 37:
                goto label_35;
              case 38:
                goto label_36;
              case 39:
                goto label_37;
              case 40:
                goto label_38;
              case 41:
                goto label_39;
              case 42:
                goto label_40;
              case 43:
                goto label_41;
              case 44:
              case 53:
                goto label_42;
              case 45:
                goto label_43;
              case 46:
                goto label_44;
              case 47:
                goto label_45;
              case 48:
                goto label_46;
              case 50:
              case 52:
                goto label_48;
              case 51:
                goto label_47;
              case 55:
                goto label_50;
              case 56:
              case 59:
                goto label_53;
              case 57:
                goto label_52;
              case 58:
                goto label_6;
              case 60:
                goto label_60;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_55;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_60:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }
  }
}
