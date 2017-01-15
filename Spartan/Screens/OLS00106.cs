using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS00106

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS00106", "FormName");
		//Fields


        public static WinFormsField MenuItemPrsnt = new WinFormsField("MENU-ITEM-PRSNT", "PRSNT. Payment Presentation", "PaymentPresentation");
        public static WinFormsField MenuItemPrrev = new WinFormsField("MENU-ITEM-PRREV", "PRREV. Presentation Reversal", "PresentationReversal");
        public static WinFormsField MenuItemCancl = new WinFormsField("MENU-ITEM-CANCL", "CANCL. Cancel Payment", "CancelPayment");
        public static WinFormsField MenuItemCnrev = new WinFormsField("MENU-ITEM-CNREV", "CNREV. Cancellation Reversal", "CancellationReversal");
        public static WinFormsField MenuItemRtncq = new WinFormsField("MENU-ITEM-RTNCQ", "RTNCQ. Returned Cheque", "ReturnedCheque");
        public static WinFormsField MenuItemRqrev = new WinFormsField("MENU-ITEM-RQREV", "RQREV. Returned Cheque Reversal", "ReturnedChequeReversal");
        public static WinFormsField MenuItemRescq = new WinFormsField("MENU-ITEM-RESCQ", "RESCQ. Resend Cheque", "ResendCheque");
        public static WinFormsField MenuItemRsrev = new WinFormsField("MENU-ITEM-RSREV", "RSREV. Resend Cheque Reversal", "ResendChequeReversal");
        public static WinFormsField MenuItemDescq = new WinFormsField("MENU-ITEM-DESCQ", "DESCQ. Destroyed Cheque", "DestroyedCheque");
        public static WinFormsField MenuItemDqrev = new WinFormsField("MENU-ITEM-DQREV", "DQREV. Destroyed Cheque Reversal", "DestroyedChequeReversal");
        public static WinFormsField MenuItemRptax = new WinFormsField("MENU-ITEM-RPTAX", "RPTAX. Withholding Tax Replacement", "WithholdingTaxReplacement");
        public static WinFormsField MenuItemRptxp = new WinFormsField("MENU-ITEM-RPTXP", "RPTXP. With'Tax Replacement with Print", "With'TaxReplacementwithPrint");
        public static WinFormsField MenuItemNewpy = new WinFormsField("MENU-ITEM-NEWPY", "NEWPY. User Entered Payment", "UserEnteredPayment");
        public static WinFormsField MenuItemPayad = new WinFormsField("MENU-ITEM-PAYAD", "PAYAD. Payment Adjust", "PaymentAdjust");
        public static WinFormsField MenuItemPaymv = new WinFormsField("MENU-ITEM-PAYMV", "PAYMV. Payment Move", "PaymentMove");
        public static WinFormsField MenuItemDcrfm = new WinFormsField("MENU-ITEM-DCRFM", "DCRFM. Direct Credit Fail Manual", "DirectCreditFailManual");
        public static WinFormsField MenuItemDfrev = new WinFormsField("MENU-ITEM-DFREV", "DFREV. Direct Credit Fail Reversal", "DirectCreditFailReversal");
        public static WinFormsField MenuItemDcrfa = new WinFormsField("MENU-ITEM-DCRFA", "DCRFA. Direct Credit Fail Auto", "DirectCreditFailAuto");
        public static WinFormsField MenuItemPayrp = new WinFormsField("MENU-ITEM-PAYRP", "PAYRP. Payment Replacements", "PaymentReplacements");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
