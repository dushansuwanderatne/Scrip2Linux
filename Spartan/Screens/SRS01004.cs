using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SRS01004

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SRS01004", "FormName");
		//Fields


        public static WinFormsField SystemInfoDate6 = new WinFormsField("SYSTEM-INFO-DATE-6", "10", "10");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 4", "4");
        public static WinFormsField SystemInfoUser1 = new WinFormsField("SYSTEM-INFO-USER-1", "11", "11");
        public static WinFormsField EventTable = new WinFormsField("EVENT-TABLE", "EventTable");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
        public static WinFormsField AsxCode = new WinFormsField("ASX-CODE", "AsxCode");
    }
}