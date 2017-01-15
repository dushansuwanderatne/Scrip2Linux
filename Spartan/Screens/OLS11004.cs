using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS11004
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("OLS11004", "FormName");
        //Fields
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField AddrLine = new WinFormsField("ADDR-LINE", "AddrLine");
        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField BulkID = new WinFormsField("BULK-ID", "BulkID");
        public static WinFormsField SubPaymentCode = new WinFormsField("SUB-PAYMENT-CODE", "SubPaymentCode");
        public static WinFormsField SubpGrossAmt = new WinFormsField("SUBP-GROSS-AMT", "SubpGrossAmt");
        public static WinFormsField SubpTaxAmt = new WinFormsField("SUBP-TAX-AMT", "SubpTaxAmt");
        public static WinFormsField SubpNettAmt = new WinFormsField("SUBP-NETT-AMT", "SubpNettAmt");
        public static WinFormsField TotGrossAmt = new WinFormsField("TOT-GROSS-AMT", "TotGrossAmt");
        public static WinFormsField TotNettAmt = new WinFormsField("TOT-NETT-AMT", "TotNettAmt");
        public static WinFormsField TotTaxAmt = new WinFormsField("TOT-TAX-AMT", "TotTaxAmt");
        public static WinFormsField Confirmation = new WinFormsField("CONFIRMATION", "Confirmation");
        public static WinFormsField PaymentTypeDesc = new WinFormsField("PAYMENT-TYPE-DESC", "PaymentTypeDesc");
        public static WinFormsField SubpErrorMessage = new WinFormsField("SUBP-ERROR-MESSAGE", "SubpErrorMessage");
        public static WinFormsField ConvNettAmt = new WinFormsField("CONV-NETT-AMT", "ConvNettAmt");
        public static WinFormsField SubpOtaxAmt = new WinFormsField("SUBP-OTAX-AMT", "SubpOtaxAmt");
        public static WinFormsField TotOtaxAmt = new WinFormsField("TOT-OTAX-AMT", "TotOtaxAmt");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}