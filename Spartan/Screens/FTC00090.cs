using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FTC00090

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FTC00090", "FormName");
		//Fields


        public static WinFormsField SystemInfoDate6 = new WinFormsField("SYSTEM-INFO-DATE-6", "10", "10");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 4", "4");
        public static WinFormsField SystemInfoUser1 = new WinFormsField("SYSTEM-INFO-USER-1", "11", "11");
        public static WinFormsField TeamNumber1 = new WinFormsField("TEAM-NUMBER-1", "TeamNumber1");
        public static WinFormsField TeamName1 = new WinFormsField("TEAM-NAME-1", "TeamName1");
        public static WinFormsField TeamNumber2 = new WinFormsField("TEAM-NUMBER-2", "TeamNumber2");
        public static WinFormsField TeamName2 = new WinFormsField("TEAM-NAME-2", "TeamName2");
    }
}
