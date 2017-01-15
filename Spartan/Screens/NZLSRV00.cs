using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZLSRV00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZLSRV00", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ServiceCode = new WinFormsField("SERVICE-CODE", "ServiceCode");
        public static WinFormsField RequestReplyCode = new WinFormsField("REQUEST-REPLY-CODE", "RequestReplyCode");
        public static WinFormsField ReplyText = new WinFormsField("REPLY-TEXT", "ReplyText");
        public static WinFormsField RecordLength = new WinFormsField("RECORD-LENGTH", "RecordLength");
        public static WinFormsField ConnectFlag = new WinFormsField("CONNECT-FLAG", "ConnectFlag");
        public static WinFormsField PartRec = new WinFormsField("PART-REC", "PartRec");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
