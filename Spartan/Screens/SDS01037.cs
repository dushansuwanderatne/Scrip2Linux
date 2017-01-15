using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SDS01037

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SDS01037", "FormName");
		//Fields


        public static WinFormsField ClassGroup = new WinFormsField("CLASS-GROUP", "ClassGroup");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField AllotClass = new WinFormsField("ALLOT-CLASS", "AllotClass");
        public static WinFormsField RefundClass = new WinFormsField("REFUND-CLASS", "RefundClass");
        public static WinFormsField MinParticipation = new WinFormsField("MIN-PARTICIPATION", "MinParticipation");
        public static WinFormsField MoneyUnitLit = new WinFormsField("MONEY-UNIT-LIT", "MoneyUnitLit");
        public static WinFormsField Units110From = new WinFormsField("UNITS1-10-FROM", "Units110From");
        public static WinFormsField Units110TO = new WinFormsField("UNITS1-10-TO", "Units110TO");
        public static WinFormsField Units1120From = new WinFormsField("UNITS11-20-FROM", "Units1120From");
        public static WinFormsField Units1120TO = new WinFormsField("UNITS11-20-TO", "Units1120TO");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
