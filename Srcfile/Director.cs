using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Threading;

namespace SipSimulator
{
    class Director
    {
        ArrayList callerMsgList = new ArrayList();
        ArrayList calleeMsgList = new ArrayList();
        public Terminal caller;
        public Terminal callee;
        public TextBox callertrace;
        public TextBox calleetrace;
        Thread callerthread;
        Thread calleethread;
        Boolean bInitFinish = false;

        public void Run()
        {
            if (bInitFinish == true)
            {
                callerthread = new Thread(StartCall);
                callerthread.Start(CallRole.Caller);

                calleethread = new Thread(StartCall);
                calleethread.Start(CallRole.Callee);
            }
        }

        public void SetInitFinishFlag(bool flag)
        {
            bInitFinish = flag;
        }

        public void Stop()
        {
            if (bInitFinish == true)
            {
                callerthread.Abort();
                calleethread.Abort();

                caller.Stop();
                callee.Stop();
            }
        }

        void StartCall(object obj)
        {
            CallRole role = (CallRole)obj;
            TextBox trace;
            Terminal terminal;

            ArrayList msgList = new ArrayList();
            if (role == CallRole.Caller)
            {
                msgList = callerMsgList; trace = callertrace; terminal = caller;
            }
            else
            {
                msgList = calleeMsgList; trace = calleetrace; terminal = callee;
            }

            trace.Text += "\r\n";
            foreach (SipMessage tmp in msgList)
            {
                Log.PrintTrace("Now " + role.ToString() + " decide to " + tmp.msgDirection.ToString() + " msg:" + tmp.sipMsgFilePath, role);
                if (tmp.msgDirection == MsgDirection.SEND)
                    trace.Text += MsgDirection.SEND.ToString() + "\r\n" + terminal.Send(tmp.sipMsgFilePath, MsgSourceType.FROM_FILE);
                else
                    trace.Text += MsgDirection.RECV.ToString() + "\r\n" + terminal.Recv(tmp.sipMsgFilePath, MsgSourceType.FROM_MSGTYPE);
            }
        }

        SipMessage GetSipMessageInfo(string line)
        {
            SipMessage currentMsg = new SipMessage();

            string[] pareselines = line.Split(new char[]{' '});
            foreach (string temp in pareselines)
            {
                if (temp.IndexOf(MsgDirection.RECV.ToString()) >= 0)
                    currentMsg.msgDirection = MsgDirection.RECV;
                else if (temp.IndexOf(MsgDirection.SEND.ToString()) >= 0)
                    currentMsg.msgDirection = MsgDirection.SEND;
                else
                    currentMsg.sipMsgFilePath = temp;
            }

            return currentMsg;
        }

        public void GetSipMessageList(string filepath, CallRole role)
        {
            if (!File.Exists(filepath))
            {
                Log.RecordErr(role.ToString() + "需要发送的SIP消息文件不存在，请在程序目录下进行配置");
                return;
            }

            string[] alltext = File.ReadAllLines(filepath);
            foreach (string line in alltext)
            {
                if (line.Length <= 0)
                    continue;

                if (role == CallRole.Caller)
                    callerMsgList.Add(GetSipMessageInfo(line));
                else
                    calleeMsgList.Add(GetSipMessageInfo(line));
            }
        }
    }

    class SipMessage
    {
        public string sipMsgFilePath;
        public MsgDirection msgDirection;

        public SipMessage()
        {
            sipMsgFilePath = "";
            msgDirection = MsgDirection.INVALIDMSGDIRECTION;
        }
    }
}
