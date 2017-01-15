using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPP05401

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPP05401", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField PartOption = new WinFormsField("PART-OPTION", "PartOption");
        public static WinFormsField ReportSequence = new WinFormsField("REPORT-SEQUENCE", "ReportSequence");
        public static WinFormsField ClassBalanceReqd = new WinFormsField("CLASS-BALANCE-REQD", "ClassBalanceReqd");
        public static WinFormsField Cls = new WinFormsField("CLS", "Cls");
        public static WinFormsField BalanceFrom = new WinFormsField("BALANCE-FROM", "BalanceFrom");
        public static WinFormsField BalanceTO = new WinFormsField("BALANCE-TO", "BalanceTO");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
