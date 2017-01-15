using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PRIMOS99

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PRIMOS99", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField PrtNumber = new WinFormsField("PRT-NUMBER", "PrtNumber");
    }
}
