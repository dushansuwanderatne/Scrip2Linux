using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFN46

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFN46", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField FtpTransferID = new WinFormsField("FTP-TRANSFER-ID", "FtpTransferID");
        public static WinFormsField FtpDestination = new WinFormsField("FTP-DESTINATION", "FtpDestination");
        public static WinFormsField ReqName = new WinFormsField("REQ-NAME", "ReqName");
        public static WinFormsField ReqDate = new WinFormsField("REQ-DATE", "ReqDate");
        public static WinFormsField ReqTime = new WinFormsField("REQ-TIME", "ReqTime");
        public static WinFormsField FileGroupCode = new WinFormsField("FILE-GROUP-CODE", "FileGroupCode");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField AuthDate = new WinFormsField("AUTH-DATE", "AuthDate");
        public static WinFormsField AuthTime = new WinFormsField("AUTH-TIME", "AuthTime");
        public static WinFormsField LitForward = new WinFormsField("LIT-FORWARD", "LitForward");
        public static WinFormsField LitBack = new WinFormsField("LIT-BACK", "LitBack");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
    }
}
