using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSCRTDB

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSCRTDB", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField EnteredBD = new WinFormsField("ENTERED-BD", "EnteredBD");
        public static WinFormsField HldaddBD = new WinFormsField("HLDADD-BD", "HldaddBD");
        public static WinFormsField Update = new WinFormsField("UPDATE", "Update");
    }
}
