using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEYT0140

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEYT0140", "FormName");
		//Fields


        public static WinFormsField FinYear = new WinFormsField("FIN-YEAR", "FinYear");
        public static WinFormsField ReportDesc2 = new WinFormsField("REPORT-DESC2", "ReportDesc2");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField CcsFile = new WinFormsField("CCS-FILE", "CcsFile");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
