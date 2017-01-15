using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00125

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00125", "FormName");
		//Fields


        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField MenuItemEsflo = new WinFormsField("MENU-ITEM-ESFLO", "ESFLO. Forfeit Loan Shares and Money", "ForfeitLoanSharesandMoney");
        public static WinFormsField MenuItemEstlo = new WinFormsField("MENU-ITEM-ESTLO", "ESTLO. Transfer of Shares", "TransferofShares");
        public static WinFormsField MenuItemEsslo = new WinFormsField("MENU-ITEM-ESSLO", "ESSLO. Repayment of Loan by Sale of Shares", "RepaymentofLoanbySaleofShares");
        public static WinFormsField MenuItemEsstl = new WinFormsField("MENU-ITEM-ESSTL", "ESSTL. Sell/Transfer Shares", "Sell/TransferShares");
        public static WinFormsField MenuItemEsspl = new WinFormsField("MENU-ITEM-ESSPL", "ESSPL. Partial Sale of Shares", "PartialSaleofShares");
        public static WinFormsField MenuItemEsrvg = new WinFormsField("MENU-ITEM-ESRVG", "ESRVG. Forfeit Loan Shares and Money Reversal", "ForfeitLoanSharesandMoneyReversal");
        public static WinFormsField MenuItemEsrvt = new WinFormsField("MENU-ITEM-ESRVT", "ESRVT. Transfer of Shares Reversal", "TransferofSharesReversal");
        public static WinFormsField MenuItemEsrvh = new WinFormsField("MENU-ITEM-ESRVH", "ESRVH. Repayment of Loan by Sale of Shares Reversal", "RepaymentofLoanbySaleofSharesReversal");
        public static WinFormsField MenuItemEsrvj = new WinFormsField("MENU-ITEM-ESRVJ", "ESRVJ. Sell/Transfer Shares Reversal", "Sell/TransferSharesReversal");
        public static WinFormsField MenuItemEsrvn = new WinFormsField("MENU-ITEM-ESRVN", "ESRVN. Trading Sale Reversal", "TradingSaleReversal");
        public static WinFormsField MenuItemEsrvi = new WinFormsField("MENU-ITEM-ESRVI", "ESRVI. Partial Sale of Shares Reversal", "PartialSaleofSharesReversal");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
