using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class WBC00201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("WBC00201", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField RunFromControl = new WinFormsField("RUN-FROM-CONTROL", "RunFromControl");
        public static WinFormsField RunTO = new WinFormsField("RUN-TO", "RunTO");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField RunFrom = new WinFormsField("RUN-FROM", "RunFrom");
    }
}
