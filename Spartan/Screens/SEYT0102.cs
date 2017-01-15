using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEYT0102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEYT0102", "FormName");
		//Fields


        public static WinFormsField FinYear = new WinFormsField("FIN-YEAR", "FinYear");
        public static WinFormsField StageDesc = new WinFormsField("STAGE-DESC", "StageDesc");
        public static WinFormsField ReportDesc1 = new WinFormsField("REPORT-DESC1", "ReportDesc1");
        public static WinFormsField ReportDesc2 = new WinFormsField("REPORT-DESC2", "ReportDesc2");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
