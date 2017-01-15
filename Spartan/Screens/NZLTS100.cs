using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZLTS100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZLTS100", "FormName");
		//Fields


        public static WinFormsField MenuItemLon = new WinFormsField("MENU-ITEM-LON", "LON.  Logon", "Logon");
        public static WinFormsField MenuItemXxxx = new WinFormsField("MENU-ITEM-XXXX", "XXXX. Computershare logoff of phantoms", "Computersharelogoffofphantoms");
        public static WinFormsField MenuItem010q = new WinFormsField("MENU-ITEM-010Q", "010Q. CSN Change FIN", "CSNChangeFIN");
        public static WinFormsField MenuItem020q = new WinFormsField("MENU-ITEM-020Q", "020Q. CSN Link Request", "CSNLinkRequest");
        public static WinFormsField MenuItem040q = new WinFormsField("MENU-ITEM-040Q", "040Q. CSN Update Account Request", "CSNUpdateAccountRequest");
        public static WinFormsField MenuItem100c = new WinFormsField("MENU-ITEM-100C", "100C. Daily Reconciliation Download", "DailyReconciliationDownload");
        public static WinFormsField MenuItem200q = new WinFormsField("MENU-ITEM-200Q", "200Q. Client Inward Transfer", "ClientInwardTransfer");
        public static WinFormsField MenuItem210q = new WinFormsField("MENU-ITEM-210Q", "210Q. Client Outward Transfer", "ClientOutwardTransfer");
        public static WinFormsField MenuItem220q = new WinFormsField("MENU-ITEM-220Q", "220Q. Broker to Broker Transfer", "BrokertoBrokerTransfer");
        public static WinFormsField MenuItem220h = new WinFormsField("MENU-ITEM-220H", "220H. Holder Transfer Release", "HolderTransferRelease");
        public static WinFormsField MenuItem240q = new WinFormsField("MENU-ITEM-240Q", "240Q. Owned Inward Transfer", "OwnedInwardTransfer");
        public static WinFormsField MenuItem250q = new WinFormsField("MENU-ITEM-250Q", "250Q. Owned Outward Transfer", "OwnedOutwardTransfer");
        public static WinFormsField MenuItem300q = new WinFormsField("MENU-ITEM-300Q", "300Q. Holder Balance Enquiry", "HolderBalanceEnquiry");
        public static WinFormsField MenuItem310q = new WinFormsField("MENU-ITEM-310Q", "310Q. Transfer Account Balance Enquiry", "TransferAccountBalanceEnquiry");
        public static WinFormsField MenuItem320c = new WinFormsField("MENU-ITEM-320C", "320C. Unnotified Transfer Enquiry", "UnnotifiedTransferEnquiry");
        public static WinFormsField MenuItem340c = new WinFormsField("MENU-ITEM-340C", "340C. Transfer Account History", "TransferAccountHistory");
        public static WinFormsField MenuItem360q = new WinFormsField("MENU-ITEM-360Q", "360Q. Transfer Reference Enquiry", "TransferReferenceEnquiry");
        public static WinFormsField MenuItem370c = new WinFormsField("MENU-ITEM-370C", "370C. Holding Balances Enquiry", "HoldingBalancesEnquiry");
        public static WinFormsField MenuItem150c = new WinFormsField("MENU-ITEM-150C", "150C. Holding Balances Enquiry", "HoldingBalancesEnquiry");
        public static WinFormsField MenuItem400q = new WinFormsField("MENU-ITEM-400Q", "400Q. Create Reservation", "CreateReservation");
        public static WinFormsField MenuItem410q = new WinFormsField("MENU-ITEM-410Q", "410Q. Cancel Reservation", "CancelReservation");
        public static WinFormsField MenuItemLoff = new WinFormsField("MENU-ITEM-LOFF", "LOFF. Logoff", "Logoff");
        public static WinFormsField MenuCode = new WinFormsField("MENU-CODE", "MenuCode");
    }
}
