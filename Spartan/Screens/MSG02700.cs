using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG02700

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG02700", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 3", "3");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField GroupName = new WinFormsField("GROUP-NAME", "GroupName");
        public static WinFormsField GroupDesc = new WinFormsField("GROUP-DESC", "GroupDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
