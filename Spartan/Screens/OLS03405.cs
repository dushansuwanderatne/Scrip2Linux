using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS03405

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS03405", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField OldRegisterCode = new WinFormsField("OLD-REGISTER-CODE", "OldRegisterCode");
        public static WinFormsField OldRegisterDesc = new WinFormsField("OLD-REGISTER-DESC", "OldRegisterDesc");
        public static WinFormsField NewRegisterCode = new WinFormsField("NEW-REGISTER-CODE", "NewRegisterCode");
    }
}
