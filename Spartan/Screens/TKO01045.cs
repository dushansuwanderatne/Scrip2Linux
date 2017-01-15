using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TKO01045

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TKO01045", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField AcceptanceClass = new WinFormsField("ACCEPTANCE-CLASS", "AcceptanceClass");
        public static WinFormsField Register = new WinFormsField("REGISTER", "Register");
        public static WinFormsField ParValue = new WinFormsField("PAR-VALUE", "ParValue");
        public static WinFormsField ParValueFlag = new WinFormsField("PAR-VALUE-FLAG", "ParValueFlag");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
