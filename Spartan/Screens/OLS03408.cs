using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS03408

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS03408", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField CRegisterCode = new WinFormsField("C-REGISTER-CODE", "CRegisterCode");
        public static WinFormsField CRegisterDesc = new WinFormsField("C-REGISTER-DESC", "CRegisterDesc");
        public static WinFormsField NRegisterCode = new WinFormsField("N-REGISTER-CODE", "NRegisterCode");
        public static WinFormsField NRegisterDesc = new WinFormsField("N-REGISTER-DESC", "NRegisterDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
