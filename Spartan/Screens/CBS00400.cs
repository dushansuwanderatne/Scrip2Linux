using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS00400

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS00400", "FormName");
		//Fields


        public static WinFormsField MenuItemLdi = new WinFormsField("MENU-ITEM-LDI", "LDI.  London Delivered into SEPON", "LondonDeliveredintoSEPON");
        public static WinFormsField MenuItemLdo = new WinFormsField("MENU-ITEM-LDO", "LDO.  London Delivered out of SEPON", "LondonDeliveredoutofSEPON");
        public static WinFormsField MenuItemAdo = new WinFormsField("MENU-ITEM-ADO", "ADO.  Australian Delivered out of SEPON (NON CHESS)", "AustralianDeliveredoutofSEPON(NONCHESS)");
        public static WinFormsField MenuItemTfp = new WinFormsField("MENU-ITEM-TFP", "TFP.  Transfer Phase Setting", "TransferPhaseSetting");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit this menu", "Exitthismenu");
        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
