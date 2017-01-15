using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG09099

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG09099", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 4", "4");
        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ErrorMessage = new WinFormsField("ERROR-MESSAGE", "ErrorMessage");
        public static WinFormsField ProgramName = new WinFormsField("PROGRAM-NAME", "ProgramName");
        public static WinFormsField UfdName = new WinFormsField("UFD-NAME", "UfdName");
    }
}
