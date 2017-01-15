using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SRV00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SRV00101", "FormName");
		//Fields


        public static WinFormsField ServiceProvider = new WinFormsField("SERVICE-PROVIDER", "ServiceProvider");
        public static WinFormsField ServiceCode = new WinFormsField("SERVICE-CODE", "ServiceCode");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
