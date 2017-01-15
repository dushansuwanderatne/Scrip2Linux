using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DMP01070

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DMP01070", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField DeleteHoldPlan1 = new WinFormsField("DELETE-HOLD-PLAN1", "DeleteHoldPlan1");
        public static WinFormsField ParticipationOption1 = new WinFormsField("PARTICIPATION-OPTION1", "ParticipationOption1");
        public static WinFormsField DeleteHoldPlan2 = new WinFormsField("DELETE-HOLD-PLAN2", "DeleteHoldPlan2");
        public static WinFormsField ParticipationOption2 = new WinFormsField("PARTICIPATION-OPTION2", "ParticipationOption2");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
