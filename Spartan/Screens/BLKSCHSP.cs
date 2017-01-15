using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BLKSCHSP

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BLKSCHSP", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField UserID = new WinFormsField("USER-ID", "UserID");
        public static WinFormsField SplitNumber = new WinFormsField("SPLIT-NUMBER", "SplitNumber");
        public static WinFormsField SplitUnits = new WinFormsField("SPLIT-UNITS", "SplitUnits");
        public static WinFormsField SplitCertFrom = new WinFormsField("SPLIT-CERT-FROM", "SplitCertFrom");
        public static WinFormsField SplitCertTO = new WinFormsField("SPLIT-CERT-TO", "SplitCertTO");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
