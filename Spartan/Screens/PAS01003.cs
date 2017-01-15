using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAS01003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAS01003", "FormName");
		//Fields


        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField PaymentDesc = new WinFormsField("PAYMENT-DESC", "PaymentDesc");
        public static WinFormsField PaymentExtraDesc = new WinFormsField("PAYMENT-EXTRA-DESC", "PaymentExtraDesc");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
        public static WinFormsField PaymentTypeFI = new WinFormsField("PAYMENT-TYPE-FI", "PaymentTypeFI");
        public static WinFormsField TypeDesc = new WinFormsField("TYPE-DESC", "TypeDesc");
        public static WinFormsField ImputationRate = new WinFormsField("IMPUTATION-RATE", "ImputationRate");
        public static WinFormsField BaseCurrency = new WinFormsField("BASE-CURRENCY", "BaseCurrency");
        public static WinFormsField DualCurrency = new WinFormsField("DUAL-CURRENCY", "DualCurrency");
        public static WinFormsField PaidCurrency = new WinFormsField("PAID-CURRENCY", "PaidCurrency");
        public static WinFormsField SplitTaxable = new WinFormsField("SPLIT-TAXABLE", "SplitTaxable");
        public static WinFormsField CurrencyConvRate = new WinFormsField("CURRENCY-CONV-RATE", "CurrencyConvRate");
        public static WinFormsField SplitTaxFree = new WinFormsField("SPLIT-TAX-FREE", "SplitTaxFree");
        public static WinFormsField CombinedPayment = new WinFormsField("COMBINED-PAYMENT", "CombinedPayment");
        public static WinFormsField ReconciliationAcct = new WinFormsField("RECONCILIATION-ACCT", "ReconciliationAcct");
        public static WinFormsField IatReportingInd = new WinFormsField("IAT-REPORTING-IND", "IatReportingInd");
        public static WinFormsField ReconBYCshare = new WinFormsField("RECON-BY-CSHARE", "ReconBYCshare");
        public static WinFormsField IatCode = new WinFormsField("IAT-CODE", "IatCode");
        public static WinFormsField AccurateReconciled = new WinFormsField("ACCURATE-RECONCILED", "AccurateReconciled");
        public static WinFormsField WebReporting = new WinFormsField("WEB-REPORTING", "WebReporting");
        public static WinFormsField MCDomicileCodes = new WinFormsField("MC-DOMICILE-CODES", "MCDomicileCodes");
        public static WinFormsField PayMandtryDcr = new WinFormsField("PAY-MANDTRY-DCR", "PayMandtryDcr");
        public static WinFormsField DissenterAccountInd = new WinFormsField("DISSENTER-ACCOUNT-IND", "DissenterAccountInd");
        public static WinFormsField ReplaceAllowedInd = new WinFormsField("REPLACE-ALLOWED-IND", "ReplaceAllowedInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ActionEnq = new WinFormsField("ACTION-ENQ", "ActionEnq");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
