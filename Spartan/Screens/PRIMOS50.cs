using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PRIMOS50

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PRIMOS50", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField Filename = new WinFormsField("FILENAME", "Filename");
        public static WinFormsField Program = new WinFormsField("PROGRAM", "Program");
        public static WinFormsField From = new WinFormsField("FROM", "From");
        public static WinFormsField TO = new WinFormsField("TO", "TO");
    }
}
