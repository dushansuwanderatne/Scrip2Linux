using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEYT0150

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEYT0150", "FormName");
		//Fields


        public static WinFormsField Input = new WinFormsField("INPUT", "Input");
        public static WinFormsField FinYear = new WinFormsField("FIN-YEAR", "FinYear");
        public static WinFormsField ReportDesc1 = new WinFormsField("REPORT-DESC1", "ReportDesc1");
        public static WinFormsField ReportDesc2 = new WinFormsField("REPORT-DESC2", "ReportDesc2");
        public static WinFormsField OutputText1 = new WinFormsField("OUTPUT-TEXT1", "OutputText1");
        public static WinFormsField OutputText2 = new WinFormsField("OUTPUT-TEXT2", "OutputText2");
        public static WinFormsField FinYear2 = new WinFormsField("FIN-YEAR2", "FinYear2");
    }
}
