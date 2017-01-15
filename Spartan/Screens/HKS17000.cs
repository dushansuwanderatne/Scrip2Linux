using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS17000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS17000", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SelectPlan = new WinFormsField("SELECT-PLAN", "SelectPlan");
        public static WinFormsField FirstCqnNum = new WinFormsField("FIRST-CQN-NUM", "FirstCqnNum");
        public static WinFormsField LastCqnNum = new WinFormsField("LAST-CQN-NUM", "LastCqnNum");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
