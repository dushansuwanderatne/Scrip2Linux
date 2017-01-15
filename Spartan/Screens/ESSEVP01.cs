using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSEVP01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSEVP01", "FormName");
		//Fields


        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField DisposalChoice = new WinFormsField("DISPOSAL-CHOICE", "DisposalChoice");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField EventUnits = new WinFormsField("EVENT-UNITS", "EventUnits");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField CurrentBalance = new WinFormsField("CURRENT-BALANCE", "CurrentBalance");
        public static WinFormsField CertNumber = new WinFormsField("CERT-NUMBER", "CertNumber");
        public static WinFormsField CertType = new WinFormsField("CERT-TYPE", "CertType");
        public static WinFormsField CertLineNumber = new WinFormsField("CERT-LINE-NUMBER", "CertLineNumber");
        public static WinFormsField Mvp0SellPartialUnits = new WinFormsField("MVP0-SELL-PARTIAL-UNITS", "Mvp0SellPartialUnits");
        public static WinFormsField EventType = new WinFormsField("EVENT-TYPE", "EventType");
        public static WinFormsField EventRate = new WinFormsField("EVENT-RATE", "EventRate");
        public static WinFormsField EventCode = new WinFormsField("EVENT-CODE", "EventCode");
        public static WinFormsField EventTotalMoney = new WinFormsField("EVENT-TOTAL-MONEY", "EventTotalMoney");
        public static WinFormsField EventDate = new WinFormsField("EVENT-DATE", "EventDate");
        public static WinFormsField EventSharePrice = new WinFormsField("EVENT-SHARE-PRICE", "EventSharePrice");
        public static WinFormsField ElectionStatus = new WinFormsField("ELECTION-STATUS", "ElectionStatus");
        public static WinFormsField EventStatus = new WinFormsField("EVENT-STATUS", "EventStatus");
        public static WinFormsField EventCostOFShares = new WinFormsField("EVENT-COST-OF-SHARES", "EventCostOFShares");
        public static WinFormsField EventEmpStatus = new WinFormsField("EVENT-EMP-STATUS", "EventEmpStatus");
        public static WinFormsField ActionStatus = new WinFormsField("ACTION-STATUS", "ActionStatus");
        public static WinFormsField ExerciseUnits = new WinFormsField("EXERCISE-UNITS", "ExerciseUnits");
        public static WinFormsField PaymentMethod = new WinFormsField("PAYMENT-METHOD", "PaymentMethod");
        public static WinFormsField WithholdingTaxRate = new WinFormsField("WITHHOLDING-TAX-RATE", "WithholdingTaxRate");
        public static WinFormsField CurrencyCode = new WinFormsField("CURRENCY-CODE", "CurrencyCode");
        public static WinFormsField WithholdingTaxCode = new WinFormsField("WITHHOLDING-TAX-CODE", "WithholdingTaxCode");
        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField MarketValueType = new WinFormsField("MARKET-VALUE-TYPE", "MarketValueType");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField ComplexHolderCode = new WinFormsField("COMPLEX-HOLDER-CODE", "ComplexHolderCode");
        public static WinFormsField PayeeAccountNumber = new WinFormsField("PAYEE-ACCOUNT-NUMBER", "PayeeAccountNumber");
        public static WinFormsField AccountName = new WinFormsField("ACCOUNT-NAME", "AccountName");
        public static WinFormsField PayeeAccountType = new WinFormsField("PAYEE-ACCOUNT-TYPE", "PayeeAccountType");
        public static WinFormsField RemainDisposalChoice = new WinFormsField("REMAIN-DISPOSAL-CHOICE", "RemainDisposalChoice");
        public static WinFormsField CountryCode = new WinFormsField("COUNTRY-CODE", "CountryCode");
        public static WinFormsField Reference = new WinFormsField("REFERENCE", "Reference");
        public static WinFormsField SwiftCode = new WinFormsField("SWIFT-CODE", "SwiftCode");
        public static WinFormsField VsaJurisdictionCode = new WinFormsField("VSA-JURISDICTION-CODE", "VsaJurisdictionCode");
        public static WinFormsField Mvp0ContactNumber = new WinFormsField("MVP0-CONTACT-NUMBER", "Mvp0ContactNumber");
        public static WinFormsField VsaJurisdictionClass = new WinFormsField("VSA-JURISDICTION-CLASS", "VsaJurisdictionClass");
        public static WinFormsField WireMiscellaneous = new WinFormsField("WIRE-MISCELLANEOUS", "WireMiscellaneous");
        public static WinFormsField BankAddressLine = new WinFormsField("BANK-ADDRESS-LINE", "BankAddressLine");
        public static WinFormsField Comments = new WinFormsField("COMMENTS", "Comments");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
