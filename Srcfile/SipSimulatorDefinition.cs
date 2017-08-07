using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SipSimulator
{
    public enum CallRole { Caller = 1, Callee = 2, Invalidrole};

    public enum MsgDirection { SEND = 1, RECV = 2, INVALIDMSGDIRECTION};

    public enum MsgSourceType {FROM_FILE = 1, FROM_STRING = 2, FROM_MSGTYPE = 3, INVALID_SOURCE_TYPE};

    class SipSimulatorDefinition
    {

    }
}
