using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSTRDSH

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSTRDSH", "FormName");
		//Fields
        public static WinFormsField TradingTypeDesc = new WinFormsField("TRADING-TYPE-DESC", "TradingTypeDesc");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderNameAddress1 = new WinFormsField("HOLDER-NAME-ADDRESS1", "HolderNameAddress1");
        public static WinFormsField HolderNameAddress2 = new WinFormsField("HOLDER-NAME-ADDRESS2", "HolderNameAddress2");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField TradingID = new WinFormsField("TRADING-ID", "TradingID");
        public static WinFormsField TrdTransNumber = new WinFormsField("TRD-TRANS-NUMBER", "TrdTransNumber");
        public static WinFormsField TradingStatus = new WinFormsField("TRADING-STATUS", "TradingStatus");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField Money = new WinFormsField("MONEY", "Money");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ReversedTradeInd = new WinFormsField("REVERSED-TRADE-IND", "ReversedTradeInd");
        public static WinFormsField SoldUnitsDesc = new WinFormsField("SOLD-UNITS-DESC", "SoldUnitsDesc");
        public static WinFormsField SoldUnits = new WinFormsField("SOLD-UNITS", "SoldUnits");
        public static WinFormsField TradeDate = new WinFormsField("TRADE-DATE", "TradeDate");
        public static WinFormsField ChargeCode = new WinFormsField("CHARGE-CODE", "ChargeCode");
        public static WinFormsField ChargeDesc = new WinFormsField("CHARGE-DESC", "ChargeDesc");
        public static WinFormsField Charge = new WinFormsField("CHARGE", "Charge");
        public static WinFormsField PaidBYFlag = new WinFormsField("PAID-BY-FLAG", "PaidBYFlag");
        public static WinFormsField Price = new WinFormsField("PRICE", "Price");
        public static WinFormsField SettlementDate = new WinFormsField("SETTLEMENT-DATE", "SettlementDate");
        public static WinFormsField Gross = new WinFormsField("GROSS", "Gross");
        public static WinFormsField EnstrdshEventType = new WinFormsField("ENSTRDSH-EVENT-TYPE", "EnstrdshEventType");
        public static WinFormsField EnstrdshEventCode = new WinFormsField("ENSTRDSH-EVENT-CODE", "EnstrdshEventCode");
        public static WinFormsField PurchRes = new WinFormsField("PURCH-RES", "PurchRes");
        public static WinFormsField PurchResSgn = new WinFormsField("PURCH-RES-SGN", "PurchResSgn");
        public static WinFormsField EnstrdshEventDate = new WinFormsField("ENSTRDSH-EVENT-DATE", "EnstrdshEventDate");
        public static WinFormsField Loan = new WinFormsField("LOAN", "Loan");
        public static WinFormsField LoanEmployer = new WinFormsField("LOAN-EMPLOYER", "LoanEmployer");
        public static WinFormsField OptionCosts = new WinFormsField("OPTION-COSTS", "OptionCosts");
        public static WinFormsField TotalHolderCharges = new WinFormsField("TOTAL-HOLDER-CHARGES", "TotalHolderCharges");
        public static WinFormsField RemainingBalance = new WinFormsField("REMAINING-BALANCE", "RemainingBalance");
        public static WinFormsField Gst = new WinFormsField("GST", "Gst");
        public static WinFormsField RemBalIndDesc = new WinFormsField("REM-BAL-IND-DESC", "RemBalIndDesc");
        public static WinFormsField WithholdingTax = new WinFormsField("WITHHOLDING-TAX", "WithholdingTax");
        public static WinFormsField TransfereeHolder = new WinFormsField("TRANSFEREE-HOLDER", "TransfereeHolder");
        public static WinFormsField NettDesc = new WinFormsField("NETT-DESC", "NettDesc");
        public static WinFormsField Nett = new WinFormsField("NETT", "Nett");
        public static WinFormsField TransfereeClass = new WinFormsField("TRANSFEREE-CLASS", "TransfereeClass");
        public static WinFormsField TransfereeRegister = new WinFormsField("TRANSFEREE-REGISTER", "TransfereeRegister");
        public static WinFormsField TransfereeCertID = new WinFormsField("TRANSFEREE-CERT-ID", "TransfereeCertID");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField PayRefNumber = new WinFormsField("PAY-REF-NUMBER", "PayRefNumber");
        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField CurrencyCode = new WinFormsField("CURRENCY-CODE", "CurrencyCode");
        public static WinFormsField CurrencyDesc = new WinFormsField("CURRENCY-DESC", "CurrencyDesc");
        public static WinFormsField PaymentMethod = new WinFormsField("PAYMENT-METHOD", "PaymentMethod");
        public static WinFormsField ConversionRate = new WinFormsField("CONVERSION-RATE", "ConversionRate");
        public static WinFormsField ForeignCurrencyAmt = new WinFormsField("FOREIGN-CURRENCY-AMT", "ForeignCurrencyAmt");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField TotalApplyHolder = new WinFormsField("TOTAL-APPLY-HOLDER", "TotalApplyHolder");
        public static WinFormsField GstTaxApply = new WinFormsField("GST-TAX-APPLY", "GstTaxApply");
        public static WinFormsField PayeeAccountNumber = new WinFormsField("PAYEE-ACCOUNT-NUMBER", "PayeeAccountNumber");
        public static WinFormsField TotalPaidBYCoy = new WinFormsField("TOTAL-PAID-BY-COY", "TotalPaidBYCoy");
        public static WinFormsField GstTaxCompany = new WinFormsField("GST-TAX-COMPANY", "GstTaxCompany");
        public static WinFormsField AccountName = new WinFormsField("ACCOUNT-NAME", "AccountName");
        public static WinFormsField TotalReportOnly = new WinFormsField("TOTAL-REPORT-ONLY", "TotalReportOnly");
        public static WinFormsField GstTaxReport = new WinFormsField("GST-TAX-REPORT", "GstTaxReport");
        public static WinFormsField SwiftCode = new WinFormsField("SWIFT-CODE", "SwiftCode");
        public static WinFormsField TotalCharges = new WinFormsField("TOTAL-CHARGES", "TotalCharges");
        public static WinFormsField GstTaxTotal = new WinFormsField("GST-TAX-TOTAL", "GstTaxTotal");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
