using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01801

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01801", "FormName");
		//Fields


        public static WinFormsField MenuItemNom = new WinFormsField("MENU-ITEM-NOM", "NOM. Nominate valid registers", "Nominatevalidregisters");
        public static WinFormsField MenuItemPrt = new WinFormsField("MENU-ITEM-PRT", "PRT. Enter register Print Descriptions", "EnterregisterPrintDescriptions");
        public static WinFormsField MenuItemEss = new WinFormsField("MENU-ITEM-ESS", "ESS. Set Up Award Register", "SetUpAwardRegister");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField MenuOption = new WinFormsField("MENU-OPTION", "MenuOption");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
