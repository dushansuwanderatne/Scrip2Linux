using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TNS14050

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TNS14050", "FormName");
		//Fields


        public static WinFormsField ParentCompanyName = new WinFormsField("PARENT-COMPANY-NAME", "ParentCompanyName");
        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
