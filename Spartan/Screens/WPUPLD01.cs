using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class WPUPLD01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("WPUPLD01", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField OutputName = new WinFormsField("OUTPUT-NAME", "OutputName");
        public static WinFormsField Printer = new WinFormsField("PRINTER", "Printer");
    }
}
