using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBSHFN80

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBSHFN80", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField DelFN = new WinFormsField("DEL-FN", "DelFN");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
