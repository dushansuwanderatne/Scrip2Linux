using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDMNU03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDMNU03", "FormName");
		//Fields
        public static WinFormsField OrderType = new WinFormsField("ORDER-TYPE", "OrderType");
        public static WinFormsField BulkProcessing = new WinFormsField("BULK-PROCESSING", "BulkProcessing");
        public static WinFormsField TradingCode = new WinFormsField("TRADING-CODE", "TradingCode");
        public static WinFormsField BulkDesc = new WinFormsField("BULK-DESC", "BulkDesc");
        public static WinFormsField MenuItemTT = new WinFormsField("MENU-ITEM-TT", "TT. Telephone Transaction Entry", "TelephoneTransactionEntry");
        public static WinFormsField MenuItemPT = new WinFormsField("MENU-ITEM-PT", "PT. Postal Transaction Entry", "PostalTransactionEntry");
        public static WinFormsField MenuItemTE = new WinFormsField("MENU-ITEM-TE", "TE. Transaction Enquiry", "TransactionEnquiry");
        public static WinFormsField MenuItemTU = new WinFormsField("MENU-ITEM-TU", "TU. Transaction Update", "TransactionUpdate");
        public static WinFormsField MenuItemTA = new WinFormsField("MENU-ITEM-TA", "TA. Transaction Audit", "TransactionAudit");
        public static WinFormsField MenuItemPR = new WinFormsField("MENU-ITEM-PR", "PR. Price Range Report", "PriceRangeReport");
        public static WinFormsField MenuItemOE = new WinFormsField("MENU-ITEM-OE", "OE. Order Enquiry", "OrderEnquiry");
        public static WinFormsField MenuItemNO = new WinFormsField("MENU-ITEM-NO", "NO. Create a New Order", "CreateaNewOrder");
        public static WinFormsField MenuItemCO = new WinFormsField("MENU-ITEM-CO", "CO. Change Order Status", "ChangeOrderStatus");
        public static WinFormsField MenuItemOU = new WinFormsField("MENU-ITEM-OU", "OU. Order Update", "OrderUpdate");
        public static WinFormsField MenuItemGO = new WinFormsField("MENU-ITEM-GO", "GO. Generate Output", "GenerateOutput");
        public static WinFormsField MenuItemAX = new WinFormsField("MENU-ITEM-AX", "AX. Apply Exercise Transaction", "ApplyExerciseTransaction");
        public static WinFormsField MenuItemSO = new WinFormsField("MENU-ITEM-SO", "SO. Settle Order", "SettleOrder");
        public static WinFormsField MenuItemFS = new WinFormsField("MENU-ITEM-FS", "FS. Force Bulk Settlement - override automatic settlement", "ForceBulkSettlement-overrideautomaticsettlement");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
