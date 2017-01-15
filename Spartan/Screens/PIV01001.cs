using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PIV01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PIV01001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField RepType = new WinFormsField("REP-TYPE", "RepType");
        public static WinFormsField RepSeq = new WinFormsField("REP-SEQ", "RepSeq");
        public static WinFormsField CutoffPoint = new WinFormsField("CUTOFF-POINT", "CutoffPoint");
        public static WinFormsField ASATRun = new WinFormsField("AS-AT-RUN", "ASATRun");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
