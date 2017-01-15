using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SDHF0101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SDHF0101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ProcessDate = new WinFormsField("PROCESS-DATE", "ProcessDate");
        public static WinFormsField RetentRate = new WinFormsField("RETENT-RATE", "RetentRate");
        public static WinFormsField CalcClass = new WinFormsField("CALC-CLASS", "CalcClass");
        public static WinFormsField ReductClass = new WinFormsField("REDUCT-CLASS", "ReductClass");
        public static WinFormsField CutoffRun = new WinFormsField("CUTOFF-RUN", "CutoffRun");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
