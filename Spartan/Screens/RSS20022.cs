using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS20022

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS20022", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ReportSelection = new WinFormsField("REPORT-SELECTION", "ReportSelection");
        public static WinFormsField CancelSelection = new WinFormsField("CANCEL-SELECTION", "CancelSelection");
    }
}
