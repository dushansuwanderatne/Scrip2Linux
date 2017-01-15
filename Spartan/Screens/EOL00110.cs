using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00110

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00110", "FormName");
		//Fields


        public static WinFormsField MenuItemEseex = new WinFormsField("MENU-ITEM-ESEEX", "ESEEX. Early Exercise", "EarlyExercise");
        public static WinFormsField MenuItemEsrtn = new WinFormsField("MENU-ITEM-ESRTN", "ESRTN. Return Savings", "ReturnSavings");
        public static WinFormsField MenuItemEsoex = new WinFormsField("MENU-ITEM-ESOEX", "ESOEX. Option Exercise", "OptionExercise");
        public static WinFormsField MenuItemEspex = new WinFormsField("MENU-ITEM-ESPEX", "ESPEX. Pending Exercise", "PendingExercise");
        public static WinFormsField MenuItemEsrve = new WinFormsField("MENU-ITEM-ESRVE", "ESRVE. Exercise Reversal", "ExerciseReversal");
        public static WinFormsField MenuItemEslpo = new WinFormsField("MENU-ITEM-ESLPO", "ESLPO. Lapse Options", "LapseOptions");
        public static WinFormsField MenuItemEslps = new WinFormsField("MENU-ITEM-ESLPS", "ESLPS. Lapse Options and Savings", "LapseOptionsandSavings");
        public static WinFormsField MenuItemEsrvl = new WinFormsField("MENU-ITEM-ESRVL", "ESRVL. Lapse Reversal", "LapseReversal");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterDescription = new WinFormsField("REGISTER-DESCRIPTION", "RegisterDescription");
        public static WinFormsField RegisterType = new WinFormsField("REGISTER-TYPE", "RegisterType");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
