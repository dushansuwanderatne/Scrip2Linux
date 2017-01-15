using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS00111

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS00111", "FormName");
		//Fields


        public static WinFormsField MenuItemRgstw = new WinFormsField("MENU-ITEM-RGSTW", "RGSTW. Stock Withdrawal Pending", "StockWithdrawalPending");
        public static WinFormsField MenuItemRgstd = new WinFormsField("MENU-ITEM-RGSTD", "RGSTD. Stock Deposit", "StockDeposit");
        public static WinFormsField MenuItemGtkoa = new WinFormsField("MENU-ITEM-GTKOA", "GTKOA. Crest Takeover Acceptance", "CrestTakeoverAcceptance");
        public static WinFormsField MenuItemRgtrn = new WinFormsField("MENU-ITEM-RGTRN", "RGTRN. Registry Transition to CREST", "RegistryTransitiontoCREST");
        public static WinFormsField MenuItemTrstw = new WinFormsField("MENU-ITEM-TRSTW", "TRSTW. Transition Stock Withdrawal", "TransitionStockWithdrawal");
        public static WinFormsField MenuItemCrsup = new WinFormsField("MENU-ITEM-CRSUP", "CRSUP. CREST Adjustment Increase", "CRESTAdjustmentIncrease");
        public static WinFormsField MenuItemCrsdn = new WinFormsField("MENU-ITEM-CRSDN", "CRSDN. CREST Adjustment Decrease", "CRESTAdjustmentDecrease");
        public static WinFormsField MenuItemGfxup = new WinFormsField("MENU-ITEM-GFXUP", "GFXUP. CREST Fixup Increase", "CRESTFixupIncrease");
        public static WinFormsField MenuItemGfxdn = new WinFormsField("MENU-ITEM-GFXDN", "GFXDN. CREST Fixup Decrease", "CRESTFixupDecrease");
        public static WinFormsField MenuItemGtktf = new WinFormsField("MENU-ITEM-GTKTF", "GTKTF. Transfer From Escrow (Takeover lapses or goes Unconditional)", "TransferFromEscrow(TakeoverlapsesorgoesUnconditional)");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST. Session Totals", "SessionTotals");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
