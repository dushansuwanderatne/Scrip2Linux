using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EXA00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EXA00101", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 3", "3");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField LinkType = new WinFormsField("LINK-TYPE", "LinkType");
        public static WinFormsField LinkDescription = new WinFormsField("LINK-DESCRIPTION", "LinkDescription");
        public static WinFormsField Amount = new WinFormsField("AMOUNT", "Amount");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
    }
}
