using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS17010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS17010", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField RunFromRange = new WinFormsField("RUN-FROM-RANGE", "RunFromRange");
        public static WinFormsField RunTORange = new WinFormsField("RUN-TO-RANGE", "RunTORange");
        public static WinFormsField TransFromRange = new WinFormsField("TRANS-FROM-RANGE", "TransFromRange");
        public static WinFormsField TransTORange = new WinFormsField("TRANS-TO-RANGE", "TransTORange");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
