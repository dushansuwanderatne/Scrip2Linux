using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK04001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK04001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ParentAsxCode = new WinFormsField("PARENT-ASX-CODE", "ParentAsxCode");
        public static WinFormsField DefaultInvProcess = new WinFormsField("DEFAULT-INV-PROCESS", "DefaultInvProcess");
        public static WinFormsField LastCashTransNbr = new WinFormsField("LAST-CASH-TRANS-NBR", "LastCashTransNbr");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
