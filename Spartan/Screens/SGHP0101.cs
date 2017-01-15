using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SGHP0101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SGHP0101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 6", "6");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField Account = new WinFormsField("ACCOUNT", "Account");
        public static WinFormsField StatementSequence = new WinFormsField("STATEMENT-SEQUENCE", "StatementSequence");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
    }
}
