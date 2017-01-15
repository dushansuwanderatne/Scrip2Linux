using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG01003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG01003", "FormName");
		//Fields


        public static WinFormsField MenuItemEvt = new WinFormsField("MENU-ITEM-EVT", "EVT.  Diary Events", "DiaryEvents");
        public static WinFormsField MenuItemSec = new WinFormsField("MENU-ITEM-SEC", "SEC.  Company / Security", "Company/Security");
        public static WinFormsField MenuItemThs = new WinFormsField("MENU-ITEM-THS", "THS.  Trading History", "TradingHistory");
        public static WinFormsField MenuItemGth = new WinFormsField("MENU-ITEM-GTH", "GTH.  Graph Trade History", "GraphTradeHistory");
        public static WinFormsField MenuItemDer = new WinFormsField("MENU-ITEM-DER", "DER.  Diary Event Report", "DiaryEventReport");
        public static WinFormsField MenuItemSbc = new WinFormsField("MENU-ITEM-SBC", "SBC.  Source/Broker Code", "Source/BrokerCode");
        public static WinFormsField MenuItemErc = new WinFormsField("MENU-ITEM-ERC", "ERC.  Error Codes", "ErrorCodes");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
