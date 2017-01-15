using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FOL00106

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FOL00106", "FormName");
		//Fields


        public static WinFormsField MenuItemPrsnt = new WinFormsField("MENU-ITEM-PRSNT", "PRSNT. Payment Presentation", "PaymentPresentation");
        public static WinFormsField MenuItemPrrev = new WinFormsField("MENU-ITEM-PRREV", "PRREV. Presentation Reversal", "PresentationReversal");
        public static WinFormsField MenuItemReplc = new WinFormsField("MENU-ITEM-REPLC", "REPLC. Payment Replacement", "PaymentReplacement");
        public static WinFormsField MenuItemCancl = new WinFormsField("MENU-ITEM-CANCL", "CANCL. Cancel Payment", "CancelPayment");
        public static WinFormsField MenuItemRptax = new WinFormsField("MENU-ITEM-RPTAX", "RPTAX. Withholding Tax Replacement", "WithholdingTaxReplacement");
        public static WinFormsField MenuItemCnrev = new WinFormsField("MENU-ITEM-CNREV", "CNREV. Cancellation Reversal", "CancellationReversal");
        public static WinFormsField MenuItemNewpy = new WinFormsField("MENU-ITEM-NEWPY", "NEWPY. User Entered Payment", "UserEnteredPayment");
        public static WinFormsField MenuItemPayad = new WinFormsField("MENU-ITEM-PAYAD", "PAYAD. Payment Adjust", "PaymentAdjust");
        public static WinFormsField MenuItemPaymv = new WinFormsField("MENU-ITEM-PAYMV", "PAYMV. Payment Move", "PaymentMove");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
