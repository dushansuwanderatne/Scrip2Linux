using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS11790

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS11790", "FormName");
		//Fields


        public static WinFormsField IatReportingInd = new WinFormsField("IAT-REPORTING-IND", "IatReportingInd");
        public static WinFormsField IatCode = new WinFormsField("IAT-CODE", "IatCode");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
