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
using System.Timers;

namespace Heartbeat
{
    [StandardModule]
    internal sealed class HeartbeatMonitoring
    {
        [STAThread]
        public static void Main()
        {
            string ErrInfo1 = "";
            // filepaths for inputs
            string str1 = "D:\\Reports\\HeartbeatMonitoring\\Heartbeat\\tag.txt";
            string reportsDisable = "D:\\Reports\\HeartbeatMonitoring\\rtreportsdisable.bat";
            string gmpReportsDisable = "D:\\Reports\\HeartbeatMonitoring\\GMPalarmreportsdisable.bat";
            
            try
            {
                Connections connections1 = (Connections)new ConnectionsClass();
                PISDK.PISDK pisdk = (PISDK.PISDK)new PISDKClass();

                ProjectData.ClearProjectError();
                Server server = connectToPI(ref ErrInfo1);
                bool connected = server.Connected;
                string str4 = "";
                ref string local4 = ref str4;
                string fileContents1 = GlobalVariables.GetFileContents(str1, ref local4);
                PIPoint point = pisdk.GetPoint(fileContents1);
                DigitalState digitalState = (DigitalState)point.Data.Snapshot.Value;
                object code = (object)digitalState.Code;

                bool codeOkay;
                while (connected)
                {
                    Thread.Sleep(10000);
                    code = getCurrentValue(code, pisdk);
                    codeOkay = isCodeGood(code, ref ErrInfo1);
                    if (!codeOkay)
                    {
                        sendEmail(code, reportsDisable, gmpReportsDisable, ref ErrInfo1);
                    }
                    while (!codeOkay)
                    {
                        Thread.Sleep(10000);
                        code = getCurrentValue(code, pisdk);
                        codeOkay = isCodeGood(code, ref ErrInfo1);
                    }
                    connected = server.Connected;
                    if (!connected)
                    {
                        server = connectToPI(ref ErrInfo1);
                        connected = server.Connected;
                    }
                }

            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                ErrInfo1 = exception.Message;
                ProjectData.ClearProjectError();
            }
        }
        private static void sendEmail(object code, string reportsDisable, string gmpReportsDisable, ref string ErrInfo)
        {
            SmtpClient smtpClient = new SmtpClient();
            MailMessage message = new MailMessage();
            // declare error information
            string ErrInfo1 = "";
            string ErrInfo2 = "";
            string ErrInfo3 = "";
            string ErrInfo4 = "";
            string ErrInfo5 = "";
            string ErrInfo6 = "";
            try
            {
                string sender = GlobalVariables.GetFileContents("D:\\Reports\\HeartbeatMonitoring\\Heartbeat\\Email\\sender.txt", ref ErrInfo1);
                string host = GlobalVariables.GetFileContents("D:\\Reports\\HeartbeatMonitoring\\Heartbeat\\Email\\host.txt", ref ErrInfo2);
                string recipients = GlobalVariables.GetFileContents("D:\\Reports\\HeartbeatMonitoring\\Heartbeat\\Email\\recipients.txt", ref ErrInfo3);
                string port = GlobalVariables.GetFileContents("D:\\Reports\\HeartbeatMonitoring\\Heartbeat\\Email\\port.txt", ref ErrInfo6);

                string subject;
                string body;
                if (Operators.ConditionalCompareObjectEqual(code, (object)"3", true))
                { // BAS Slow collect
                    subject = GlobalVariables.GetFileContents("D:\\Reports\\HeartbeatMonitoring\\Heartbeat\\Email\\gmpsubject.txt", ref ErrInfo4);
                    body = GlobalVariables.GetFileContents("D:\\Reports\\HeartbeatMonitoring\\Heartbeat\\Email\\gmpbody.txt", ref ErrInfo5);
                    Process.Start(gmpReportsDisable);
                }
                else
                {
                    subject = GlobalVariables.GetFileContents("D:\\Reports\\HeartbeatMonitoring\\Heartbeat\\Email\\subject.txt", ref ErrInfo4);
                    body = GlobalVariables.GetFileContents("D:\\Reports\\HeartbeatMonitoring\\Heartbeat\\Email\\body.txt", ref ErrInfo5);
                    Process.Start(reportsDisable);
                }
                smtpClient.Port = Conversions.ToInteger(port);
                smtpClient.Host = host;
                smtpClient.EnableSsl = false;
                message = new MailMessage();
                message.From = new MailAddress(sender);
                message.To.Add(recipients);
                message.Subject = subject;
                message.Body = body;
                smtpClient.Send(message);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                ErrInfo = exception.Message;
                ProjectData.ClearProjectError();
            }
            return;
        }
        private static Server connectToPI(ref string ErrInfo)
        {
            Server server2;
            try
            {
                Connections connections1 = (Connections)new ConnectionsClass();
                PISDK.PISDK pisdk = (PISDK.PISDK)new PISDKClass();

                // not sure what this is for...
                // ProjectData.ClearProjectError();
                // num1 = -2;
                // end of comment above

                string str2 = "pidemo";
                string str3 = "Fac0ps";
                Connections connections2 = connections1;
                Server server1 = (Server)null;
                ref Server local1 = ref server1;
                ref string local2 = ref str2;
                ref string local3 = ref str3;
                server2 = connections2.Login(ref local1, ref local2, ref local3, false, false);
                return server2;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                ErrInfo = exception.Message;
                ProjectData.ClearProjectError();
                return (Server)null;
            }
        }
        private static object getCurrentValue(object code, PISDK.PISDK pisdk)
        {
            PIPoint point = pisdk.GetPoint(Conversions.ToString(code));
            DigitalState digitalState = (DigitalState)point.Data.Snapshot.Value;
            return (object)digitalState.Code;
        }
        private static bool isCodeGood(object code, ref string ErrInfo)
        {
            if (Operators.ConditionalCompareObjectEqual(code, (object)"1", false))
            {
                return false;
            }
            if (Operators.ConditionalCompareObjectEqual(code, (object)"2", false))
            {
                return false;
            }
            if (Operators.ConditionalCompareObjectEqual(code, (object)"3", false)) // BAS Slow Collect
            {
                return false;
            }
            return true;
        }
    }
}
