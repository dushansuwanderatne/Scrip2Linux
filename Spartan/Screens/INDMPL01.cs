using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class INDMPL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("INDMPL01", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField InvDomplans = new WinFormsField("INV-DOMPLANS", "InvDomplans");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
