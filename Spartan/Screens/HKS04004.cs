using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS04004

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS04004", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ReportDesc = new WinFormsField("REPORT-DESC", "ReportDesc");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
    }
}
