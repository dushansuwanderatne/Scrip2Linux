using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZLTST

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZLTST", "FormName");
		//Fields


        public static WinFormsField MenuItemWB = new WinFormsField("MENU-ITEM-WB", "WB. Logon", "Logon");
        public static WinFormsField MenuItemXX = new WinFormsField("MENU-ITEM-XX", "XX. Computershare logoff of phantoms", "Computersharelogoffofphantoms");
        public static WinFormsField MenuItemWD = new WinFormsField("MENU-ITEM-WD", "WD. Deny Access", "DenyAccess");
        public static WinFormsField MenuItemWH = new WinFormsField("MENU-ITEM-WH", "WH. Service Request", "ServiceRequest");
        public static WinFormsField MenuItemJA = new WinFormsField("MENU-ITEM-JA", "JA. Client Inward Transfer", "ClientInwardTransfer");
        public static WinFormsField MenuItemJE = new WinFormsField("MENU-ITEM-JE", "JE. Client Outward Transfer - Long form", "ClientOutwardTransfer-Longform");
        public static WinFormsField MenuItemJF = new WinFormsField("MENU-ITEM-JF", "JF. Client Outward Transfer - Short form", "ClientOutwardTransfer-Shortform");
        public static WinFormsField MenuItemJH = new WinFormsField("MENU-ITEM-JH", "JH. Broker to Broker Transfer", "BrokertoBrokerTransfer");
        public static WinFormsField MenuItemJQ = new WinFormsField("MENU-ITEM-JQ", "JQ. Scripless Inward Transfer", "ScriplessInwardTransfer");
        public static WinFormsField MenuItemWM = new WinFormsField("MENU-ITEM-WM", "WM. Logoff", "Logoff");
        public static WinFormsField MessageType = new WinFormsField("MESSAGE-TYPE", "MessageType");
    }
}
