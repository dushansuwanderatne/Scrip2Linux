using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS04030

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS04030", "FormName");
		//Fields
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField EomRun = new WinFormsField("EOM-RUN", "EomRun");
        public static WinFormsField LastRunNbr = new WinFormsField("LAST-RUN-NBR", "LastRunNbr");
        public static WinFormsField CurrentRun = new WinFormsField("CURRENT-RUN", "CurrentRun");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField Asterisk1 = new WinFormsField("ASTERISK1", "Asterisk1");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField Eom = new WinFormsField("EOM", "Eom");
        public static WinFormsField LastRun = new WinFormsField("LAST-RUN", "LastRun");
        public static WinFormsField Current = new WinFormsField("CURRENT", "Current");
        public static WinFormsField Asterisk2 = new WinFormsField("ASTERISK2", "Asterisk2");
        public static WinFormsField MoreCodes = new WinFormsField("MORE-CODES", "MoreCodes");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SearchClass = new WinFormsField("SEARCH-CLASS", "SearchClass");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
