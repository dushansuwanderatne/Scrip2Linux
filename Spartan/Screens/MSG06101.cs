using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG06101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG06101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ReportName = new WinFormsField("REPORT-NAME", "ReportName");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
