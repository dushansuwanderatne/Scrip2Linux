using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PRIMOS75

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PRIMOS75", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Filename = new WinFormsField("FILENAME", "Filename");
        public static WinFormsField Copies = new WinFormsField("COPIES", "Copies");
    }
}
