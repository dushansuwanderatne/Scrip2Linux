using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01302

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01302", "FormName");
		//Fields


        public static WinFormsField UserFlagNumber = new WinFormsField("USER-FLAG-NUMBER", "UserFlagNumber");
        public static WinFormsField UserFlagValue = new WinFormsField("USER-FLAG-VALUE", "UserFlagValue");
        public static WinFormsField UserFlagDesc = new WinFormsField("USER-FLAG-DESC", "UserFlagDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SearchNumber = new WinFormsField("SEARCH-NUMBER", "SearchNumber");
        public static WinFormsField SearchValue = new WinFormsField("SEARCH-VALUE", "SearchValue");
        public static WinFormsField ActionEnq = new WinFormsField("ACTION-ENQ", "ActionEnq");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
