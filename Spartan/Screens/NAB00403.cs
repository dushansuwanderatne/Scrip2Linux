using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NAB00403

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NAB00403", "FormName");
		//Fields


        public static WinFormsField TotalRejects = new WinFormsField("TOTAL-REJECTS", "TotalRejects");
        public static WinFormsField ReportName = new WinFormsField("REPORT-NAME", "ReportName");
    }
}
