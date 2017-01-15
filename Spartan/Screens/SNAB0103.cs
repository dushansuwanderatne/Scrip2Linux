using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SNAB0103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SNAB0103", "FormName");
		//Fields


        public static WinFormsField TotalRejects = new WinFormsField("TOTAL-REJECTS", "TotalRejects");
        public static WinFormsField ReportName = new WinFormsField("REPORT-NAME", "ReportName");
    }
}
