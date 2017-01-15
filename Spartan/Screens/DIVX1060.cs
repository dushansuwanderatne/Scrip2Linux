using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVX1060

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVX1060", "FormName");
		//Fields
        public static WinFormsField BuildRequired = new WinFormsField("BUILD-REQUIRED", "BuildRequired");
        public static WinFormsField IatReportingInd = new WinFormsField("IAT-REPORTING-IND", "IatReportingInd");
        public static WinFormsField IatCode = new WinFormsField("IAT-CODE", "IatCode");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
