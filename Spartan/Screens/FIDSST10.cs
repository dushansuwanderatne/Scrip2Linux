using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FIDSST10

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FIDSST10", "FormName");
		//Fields


        public static WinFormsField ReportName = new WinFormsField("REPORT-NAME", "ReportName");
    }
}
