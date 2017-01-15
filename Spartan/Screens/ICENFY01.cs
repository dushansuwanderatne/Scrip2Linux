using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICENFY01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICENFY01", "FormName");
		//Fields
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchRule = new WinFormsField("SEARCH-RULE", "SearchRule");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
