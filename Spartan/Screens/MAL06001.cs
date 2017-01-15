using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MAL06001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MAL06001", "FormName");
		//Fields


        public static WinFormsField ReportName = new WinFormsField("REPORT-NAME", "ReportName");
        public static WinFormsField Var = new WinFormsField("VAR", "Var");
    }
}
