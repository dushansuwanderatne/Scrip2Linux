using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01054

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01054", "FormName");
		//Fields
        public static WinFormsField EventType = new WinFormsField("EVENT-TYPE", "EventType");
        public static WinFormsField EventCode = new WinFormsField("EVENT-CODE", "EventCode");
        public static WinFormsField EventDate = new WinFormsField("EVENT-DATE", "EventDate");
        public static WinFormsField EventTotals = new WinFormsField("EVENT-TOTALS", "EventTotals");
        public static WinFormsField RegisterTotals = new WinFormsField("REGISTER-TOTALS", "RegisterTotals");
        public static WinFormsField RegisterTypeTotals = new WinFormsField("REGISTER-TYPE-TOTALS", "RegisterTypeTotals");
        public static WinFormsField CertificateBalances = new WinFormsField("CERTIFICATE-BALANCES", "CertificateBalances");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
