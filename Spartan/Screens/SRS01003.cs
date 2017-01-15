using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SRS01003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SRS01003", "FormName");
		//Fields


        public static WinFormsField SystemInfoDate6 = new WinFormsField("SYSTEM-INFO-DATE-6", "10", "10");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 4", "4");
        public static WinFormsField SystemInfoUser1 = new WinFormsField("SYSTEM-INFO-USER-1", "11", "11");
        public static WinFormsField HolderNumber = new WinFormsField("HOLDER-NUMBER", "HolderNumber");
        public static WinFormsField Company = new WinFormsField("COMPANY", "Company");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField PageNO = new WinFormsField("PAGE-NO", "PageNO");
        public static WinFormsField LastUpdate = new WinFormsField("LAST-UPDATE", "LastUpdate");
        public static WinFormsField Sequence = new WinFormsField("SEQUENCE", "Sequence");
        public static WinFormsField Line = new WinFormsField("LINE", "Line");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
