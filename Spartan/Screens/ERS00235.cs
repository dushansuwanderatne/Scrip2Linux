using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS00235

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS00235", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField AsxSecCode = new WinFormsField("ASX-SEC-CODE", "AsxSecCode");
    }
}
