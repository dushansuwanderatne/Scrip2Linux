using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HLP00100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HLP00100", "FormName");
		//Fields


        public static WinFormsField SystemInfoDate6 = new WinFormsField("SYSTEM-INFO-DATE-6", "10", "10");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 4", "4");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField Frmnam = new WinFormsField("FRMNAM", "Frmnam");
        public static WinFormsField Fldnam = new WinFormsField("FLDNAM", "Fldnam");
        public static WinFormsField MoreHelp = new WinFormsField("MORE-HELP", "MoreHelp");
        public static WinFormsField Help = new WinFormsField("HELP", "Help");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchFrmnam = new WinFormsField("SEARCH-FRMNAM", "SearchFrmnam");
        public static WinFormsField SearchFldnam = new WinFormsField("SEARCH-FLDNAM", "SearchFldnam");
    }
}
