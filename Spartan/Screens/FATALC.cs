using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FATALC

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FATALC", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 4", "4");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Message1 = new WinFormsField("MESSAGE-1", "Message1");
        public static WinFormsField Message2 = new WinFormsField("MESSAGE-2", "Message2");
        public static WinFormsField Message3 = new WinFormsField("MESSAGE-3", "Message3");
        public static WinFormsField UserName = new WinFormsField("USER-NAME", "UserName");
        public static WinFormsField UserNumber = new WinFormsField("USER-NUMBER", "UserNumber");
        public static WinFormsField ProgramName = new WinFormsField("PROGRAM-NAME", "ProgramName");
        public static WinFormsField UfdName = new WinFormsField("UFD-NAME", "UfdName");
    }
}
