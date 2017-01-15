using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CAL01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CAL01001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField CallClass = new WinFormsField("CALL-CLASS", "CallClass");
        public static WinFormsField CallDesc = new WinFormsField("CALL-DESC", "CallDesc");
        public static WinFormsField PreloadInd = new WinFormsField("PRELOAD-IND", "PreloadInd");
        public static WinFormsField CalNum = new WinFormsField("CAL-NUM", "CalNum");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
