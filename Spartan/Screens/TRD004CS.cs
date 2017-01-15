using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRD004CS

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRD004CS", "FormName");
		//Fields
        public static WinFormsField TradingID = new WinFormsField("TRADING-ID", "TradingID");
        public static WinFormsField TradeDescription = new WinFormsField("TRADE-DESCRIPTION", "TradeDescription");
        public static WinFormsField TradingType = new WinFormsField("TRADING-TYPE", "TradingType");
        public static WinFormsField TradingTypeDesc = new WinFormsField("TRADING-TYPE-DESC", "TradingTypeDesc");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField StatusDesc = new WinFormsField("STATUS-DESC", "StatusDesc");
        public static WinFormsField TotalCount = new WinFormsField("TOTAL-COUNT", "TotalCount");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField TotalMoney = new WinFormsField("TOTAL-MONEY", "TotalMoney");
        public static WinFormsField UnitsTraded = new WinFormsField("UNITS-TRADED", "UnitsTraded");
        public static WinFormsField TotalCost = new WinFormsField("TOTAL-COST", "TotalCost");
        public static WinFormsField ChargeCode = new WinFormsField("CHARGE-CODE", "ChargeCode");
        public static WinFormsField ChargeDesc = new WinFormsField("CHARGE-DESC", "ChargeDesc");
        public static WinFormsField ChargeAmount = new WinFormsField("CHARGE-AMOUNT", "ChargeAmount");
        public static WinFormsField ChargePaidBY = new WinFormsField("CHARGE-PAID-BY", "ChargePaidBY");
        public static WinFormsField FinalPrice = new WinFormsField("FINAL-PRICE", "FinalPrice");
        public static WinFormsField TradePrice = new WinFormsField("TRADE-PRICE", "TradePrice");
        public static WinFormsField PriceLimit = new WinFormsField("PRICE-LIMIT", "PriceLimit");
        public static WinFormsField GrossAmount = new WinFormsField("GROSS-AMOUNT", "GrossAmount");
        public static WinFormsField PurchaseResidue = new WinFormsField("PURCHASE-RESIDUE", "PurchaseResidue");
        public static WinFormsField PurchaseResidueSgn = new WinFormsField("PURCHASE-RESIDUE-SGN", "PurchaseResidueSgn");
        public static WinFormsField HolderCharges1 = new WinFormsField("HOLDER-CHARGES-1", "HolderCharges1");
        public static WinFormsField LoanAmount = new WinFormsField("LOAN-AMOUNT", "LoanAmount");
        public static WinFormsField LoanEmployer = new WinFormsField("LOAN-EMPLOYER", "LoanEmployer");
        public static WinFormsField Gst = new WinFormsField("GST", "Gst");
        public static WinFormsField TaxWithheld = new WinFormsField("TAX-WITHHELD", "TaxWithheld");
        public static WinFormsField NettAmount = new WinFormsField("NETT-AMOUNT", "NettAmount");
        public static WinFormsField ChqNbrFrom = new WinFormsField("CHQ-NBR-FROM", "ChqNbrFrom");
        public static WinFormsField ChqNbrTO = new WinFormsField("CHQ-NBR-TO", "ChqNbrTO");
        public static WinFormsField CompanyCharges = new WinFormsField("COMPANY-CHARGES", "CompanyCharges");
        public static WinFormsField CompanyTax = new WinFormsField("COMPANY-TAX", "CompanyTax");
        public static WinFormsField LocalChqCount = new WinFormsField("LOCAL-CHQ-COUNT", "LocalChqCount");
        public static WinFormsField LocalChqNettAmount = new WinFormsField("LOCAL-CHQ-NETT-AMOUNT", "LocalChqNettAmount");
        public static WinFormsField HolderCharges = new WinFormsField("HOLDER-CHARGES", "HolderCharges");
        public static WinFormsField HolderTax = new WinFormsField("HOLDER-TAX", "HolderTax");
        public static WinFormsField ForeignChqCount = new WinFormsField("FOREIGN-CHQ-COUNT", "ForeignChqCount");
        public static WinFormsField ForeignChqNettAmt = new WinFormsField("FOREIGN-CHQ-NETT-AMT", "ForeignChqNettAmt");
        public static WinFormsField ReportCharges = new WinFormsField("REPORT-CHARGES", "ReportCharges");
        public static WinFormsField ReportTax = new WinFormsField("REPORT-TAX", "ReportTax");
        public static WinFormsField WireCount = new WinFormsField("WIRE-COUNT", "WireCount");
        public static WinFormsField WireNettAmount = new WinFormsField("WIRE-NETT-AMOUNT", "WireNettAmount");
        public static WinFormsField DirectBankingCount = new WinFormsField("DIRECT-BANKING-COUNT", "DirectBankingCount");
        public static WinFormsField DirectBankNettAmt = new WinFormsField("DIRECT-BANK-NETT-AMT", "DirectBankNettAmt");
        public static WinFormsField EmployerCount = new WinFormsField("EMPLOYER-COUNT", "EmployerCount");
        public static WinFormsField EmployerNettAmount = new WinFormsField("EMPLOYER-NETT-AMOUNT", "EmployerNettAmount");
        public static WinFormsField PaymentAccount = new WinFormsField("PAYMENT-ACCOUNT", "PaymentAccount");
        public static WinFormsField BankType = new WinFormsField("BANK-TYPE", "BankType");
        public static WinFormsField BranchNumber = new WinFormsField("BRANCH-NUMBER", "BranchNumber");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField PriceATAudit = new WinFormsField("PRICE-AT-AUDIT", "PriceATAudit");
        public static WinFormsField PriceATAuditType = new WinFormsField("PRICE-AT-AUDIT-TYPE", "PriceATAuditType");
        public static WinFormsField OptionCost = new WinFormsField("OPTION-COST", "OptionCost");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
