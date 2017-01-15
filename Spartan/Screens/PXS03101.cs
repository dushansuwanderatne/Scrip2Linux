using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS03101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS03101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
