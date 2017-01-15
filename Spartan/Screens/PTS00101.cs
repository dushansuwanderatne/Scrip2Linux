using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PTS00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PTS00101", "FormName");
		//Fields


        public static WinFormsField MenuItemPM = new WinFormsField("MENU-ITEM-PM", "PM.  Problem Management", "ProblemManagement");
        public static WinFormsField MenuItemTM = new WinFormsField("MENU-ITEM-TM", "TM.  Task Management", "TaskManagement");
        public static WinFormsField MenuItemLI = new WinFormsField("MENU-ITEM-LI", "LI.  Log In as New User", "LogInasNewUser");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit System", "ExitSystem");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 6", "6");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 1", "1");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
