using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS14103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS14103", "FormName");
		//Fields


        public static WinFormsField ReplaceCntC = new WinFormsField("REPLACE-CNT-C", "ReplaceCntC");
        public static WinFormsField ReplaceAmtC = new WinFormsField("REPLACE-AMT-C", "ReplaceAmtC");
        public static WinFormsField ReplaceCntD = new WinFormsField("REPLACE-CNT-D", "ReplaceCntD");
        public static WinFormsField ReplaceAmtD = new WinFormsField("REPLACE-AMT-D", "ReplaceAmtD");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField WaitingCntC = new WinFormsField("WAITING-CNT-C", "WaitingCntC");
        public static WinFormsField WaitingAmtC = new WinFormsField("WAITING-AMT-C", "WaitingAmtC");
        public static WinFormsField WaitingCntD = new WinFormsField("WAITING-CNT-D", "WaitingCntD");
        public static WinFormsField WaitingAmtD = new WinFormsField("WAITING-AMT-D", "WaitingAmtD");
        public static WinFormsField ReplaceCntT = new WinFormsField("REPLACE-CNT-T", "ReplaceCntT");
        public static WinFormsField ReplaceAmtT = new WinFormsField("REPLACE-AMT-T", "ReplaceAmtT");
        public static WinFormsField WaitingCntT = new WinFormsField("WAITING-CNT-T", "WaitingCntT");
        public static WinFormsField WaitingAmtT = new WinFormsField("WAITING-AMT-T", "WaitingAmtT");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
