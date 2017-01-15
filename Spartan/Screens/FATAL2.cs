using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FATAL2

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FATAL2", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 4", "4");
        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Comment1 = new WinFormsField("COMMENT1", "Comment1");
        public static WinFormsField Comment2 = new WinFormsField("COMMENT2", "Comment2");
        public static WinFormsField Comment3 = new WinFormsField("COMMENT3", "Comment3");
        public static WinFormsField ProgramName = new WinFormsField("PROGRAM-NAME", "ProgramName");
        public static WinFormsField UfdName = new WinFormsField("UFD-NAME", "UfdName");
    }
}
