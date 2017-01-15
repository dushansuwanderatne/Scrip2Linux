using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDHIS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDHIS01", "FormName");
		//Fields


        public static WinFormsField TradingCode = new WinFormsField("TRADING-CODE", "TradingCode");
        public static WinFormsField TradingNumber = new WinFormsField("TRADING-NUMBER", "TradingNumber");
        public static WinFormsField DlgTransNumber = new WinFormsField("DLG-TRANS-NUMBER", "DlgTransNumber");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField SettlementDate = new WinFormsField("SETTLEMENT-DATE", "SettlementDate");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField CrtTransNumber = new WinFormsField("CRT-TRANS-NUMBER", "CrtTransNumber");
        public static WinFormsField TradingType = new WinFormsField("TRADING-TYPE", "TradingType");
        public static WinFormsField OriginalCurrency = new WinFormsField("ORIGINAL-CURRENCY", "OriginalCurrency");
        public static WinFormsField ContactNumber = new WinFormsField("CONTACT-NUMBER", "ContactNumber");
        public static WinFormsField VersionNumber = new WinFormsField("VERSION-NUMBER", "VersionNumber");
        public static WinFormsField CurrencyCode = new WinFormsField("CURRENCY-CODE", "CurrencyCode");
        public static WinFormsField ForeignCurrencyAmt = new WinFormsField("FOREIGN-CURRENCY-AMT", "ForeignCurrencyAmt");
        public static WinFormsField Amount = new WinFormsField("AMOUNT", "Amount");
        public static WinFormsField DealingTransStatus = new WinFormsField("DEALING-TRANS-STATUS", "DealingTransStatus");
        public static WinFormsField OriginalPaymentMethod = new WinFormsField("ORIGINAL-PAYMENT-METHOD", "OriginalPaymentMethod");
        public static WinFormsField PaymentMethod = new WinFormsField("PAYMENT-METHOD", "PaymentMethod");
        public static WinFormsField OverridePaymentMethod = new WinFormsField("OVERRIDE-PAYMENT-METHOD", "OverridePaymentMethod");
        public static WinFormsField Charge = new WinFormsField("CHARGE", "Charge");
        public static WinFormsField TaxONCharge = new WinFormsField("TAX-ON-CHARGE", "TaxONCharge");
        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField OverrideCourierFlag = new WinFormsField("OVERRIDE-COURIER-FLAG", "OverrideCourierFlag");
        public static WinFormsField PayRefNumber = new WinFormsField("PAY-REF-NUMBER", "PayRefNumber");
        public static WinFormsField AlternatePayMethod = new WinFormsField("ALTERNATE-PAY-METHOD", "AlternatePayMethod");
        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField PayeeAccountNumber = new WinFormsField("PAYEE-ACCOUNT-NUMBER", "PayeeAccountNumber");
        public static WinFormsField AccountName = new WinFormsField("ACCOUNT-NAME", "AccountName");
        public static WinFormsField PayeeAccountType = new WinFormsField("PAYEE-ACCOUNT-TYPE", "PayeeAccountType");
        public static WinFormsField SwiftCode = new WinFormsField("SWIFT-CODE", "SwiftCode");
        public static WinFormsField CountryCode = new WinFormsField("COUNTRY-CODE", "CountryCode");
        public static WinFormsField BankAddressLine = new WinFormsField("BANK-ADDRESS-LINE", "BankAddressLine");
        public static WinFormsField IncomeSourceCode = new WinFormsField("INCOME-SOURCE-CODE", "IncomeSourceCode");
        public static WinFormsField TaxType = new WinFormsField("TAX-TYPE", "TaxType");
        public static WinFormsField TaxStatus = new WinFormsField("TAX-STATUS", "TaxStatus");
        public static WinFormsField WireMiscellaneous = new WinFormsField("WIRE-MISCELLANEOUS", "WireMiscellaneous");
        public static WinFormsField DomicileCode = new WinFormsField("DOMICILE-CODE", "DomicileCode");
        public static WinFormsField DiscountPercentage = new WinFormsField("DISCOUNT-PERCENTAGE", "DiscountPercentage");
        public static WinFormsField UnitsTraded = new WinFormsField("UNITS-TRADED", "UnitsTraded");
        public static WinFormsField ResiduePayMethod = new WinFormsField("RESIDUE-PAY-METHOD", "ResiduePayMethod");
        public static WinFormsField ResidueReason = new WinFormsField("RESIDUE-REASON", "ResidueReason");
        public static WinFormsField ReceiptMethod = new WinFormsField("RECEIPT-METHOD", "ReceiptMethod");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField SourceTaxCode = new WinFormsField("SOURCE-TAX-CODE", "SourceTaxCode");
        public static WinFormsField Price = new WinFormsField("PRICE", "Price");
        public static WinFormsField InitialSetupInd = new WinFormsField("INITIAL-SETUP-IND", "InitialSetupInd");
        public static WinFormsField Money = new WinFormsField("MONEY", "Money");
        public static WinFormsField WflowID = new WinFormsField("WFLOW-ID", "WflowID");
        public static WinFormsField TradeDate = new WinFormsField("TRADE-DATE", "TradeDate");
        public static WinFormsField CourierServiceInd = new WinFormsField("COURIER-SERVICE-IND", "CourierServiceInd");
        public static WinFormsField TradePrice = new WinFormsField("TRADE-PRICE", "TradePrice");
        public static WinFormsField PurchaseType = new WinFormsField("PURCHASE-TYPE", "PurchaseType");
        public static WinFormsField RemainingBalanceInd = new WinFormsField("REMAINING-BALANCE-IND", "RemainingBalanceInd");
        public static WinFormsField RemainingBalance = new WinFormsField("REMAINING-BALANCE", "RemainingBalance");
        public static WinFormsField OptionPrice = new WinFormsField("OPTION-PRICE", "OptionPrice");
        public static WinFormsField SaleTypeInd = new WinFormsField("SALE-TYPE-IND", "SaleTypeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoTime1 = new WinFormsField("SYSTEM-INFO-TIME-1", "1", "1");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
