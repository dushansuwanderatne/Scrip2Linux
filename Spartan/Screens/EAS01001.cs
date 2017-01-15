using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EAS01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EAS01001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField AllotDesc = new WinFormsField("ALLOT-DESC", "AllotDesc");
        public static WinFormsField AllotFreq = new WinFormsField("ALLOT-FREQ", "AllotFreq");
        public static WinFormsField LastAllotPeriod = new WinFormsField("LAST-ALLOT-PERIOD", "LastAllotPeriod");
        public static WinFormsField LastAllotDate = new WinFormsField("LAST-ALLOT-DATE", "LastAllotDate");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
        public static WinFormsField AllotNum = new WinFormsField("ALLOT-NUM", "AllotNum");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
