using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFN42

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFN42", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField FtpDestCode = new WinFormsField("FTP-DEST-CODE", "FtpDestCode");
        public static WinFormsField FtpName = new WinFormsField("FTP-NAME", "FtpName");
        public static WinFormsField LitForward = new WinFormsField("LIT-FORWARD", "LitForward");
        public static WinFormsField LitBack = new WinFormsField("LIT-BACK", "LitBack");
        public static WinFormsField FileGroup = new WinFormsField("FILE-GROUP", "FileGroup");
        public static WinFormsField FileGroupDesc = new WinFormsField("FILE-GROUP-DESC", "FileGroupDesc");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
    }
}
