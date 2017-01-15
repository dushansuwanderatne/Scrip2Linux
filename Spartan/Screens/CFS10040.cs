using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS10040

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS10040", "FormName");
		//Fields


        public static WinFormsField ParamCoy = new WinFormsField("PARAM-COY", "ParamCoy");
        public static WinFormsField ParamFile = new WinFormsField("PARAM-FILE", "ParamFile");
        public static WinFormsField RepHeading = new WinFormsField("REP-HEADING", "RepHeading");
        public static WinFormsField DclFile = new WinFormsField("DCL-FILE", "DclFile");
        public static WinFormsField JobName = new WinFormsField("JOB-NAME", "JobName");
        public static WinFormsField OutputDest = new WinFormsField("OUTPUT-DEST", "OutputDest");
        public static WinFormsField DeferTime = new WinFormsField("DEFER-TIME", "DeferTime");
        public static WinFormsField DeferDate = new WinFormsField("DEFER-DATE", "DeferDate");
        public static WinFormsField Queue = new WinFormsField("QUEUE", "Queue");
        public static WinFormsField Username = new WinFormsField("USERNAME", "Username");
        public static WinFormsField OptimizedInd = new WinFormsField("OPTIMIZED-IND", "OptimizedInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
    }
}
