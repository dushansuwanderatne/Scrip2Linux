using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SDS01040

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SDS01040", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField OrderNumber = new WinFormsField("ORDER-NUMBER", "OrderNumber");
        public static WinFormsField OpsInitials = new WinFormsField("OPS-INITIALS", "OpsInitials");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
    }
}
