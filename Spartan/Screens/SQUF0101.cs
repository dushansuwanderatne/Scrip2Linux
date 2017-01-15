using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SQUF0101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SQUF0101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField RepHeading = new WinFormsField("REP-HEADING", "RepHeading");
        public static WinFormsField RepDate = new WinFormsField("REP-DATE", "RepDate");
        public static WinFormsField RepASATRun = new WinFormsField("REP-AS-AT-RUN", "RepASATRun");
        public static WinFormsField Selcls = new WinFormsField("SELCLS", "Selcls");
        public static WinFormsField PaymentRate = new WinFormsField("PAYMENT-RATE", "PaymentRate");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
