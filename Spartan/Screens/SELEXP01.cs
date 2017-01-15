using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELEXP01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELEXP01", "FormName");
		//Fields


        public static WinFormsField FtpDestCode = new WinFormsField("FTP-DEST-CODE", "FtpDestCode");
        public static WinFormsField FtpName = new WinFormsField("FTP-NAME", "FtpName");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
