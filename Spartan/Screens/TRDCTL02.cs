using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDCTL02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDCTL02", "FormName");
		//Fields


        public static WinFormsField TradingCode = new WinFormsField("TRADING-CODE", "TradingCode");
        public static WinFormsField OnlineEntryInd = new WinFormsField("ONLINE-ENTRY-IND", "OnlineEntryInd");
        public static WinFormsField DiscountPercentage = new WinFormsField("DISCOUNT-PERCENTAGE", "DiscountPercentage");
        public static WinFormsField TelephoneSalesEntryInd = new WinFormsField("TELEPHONE-SALES-ENTRY-IND", "TelephoneSalesEntryInd");
        public static WinFormsField UnitAllocationInd = new WinFormsField("UNIT-ALLOCATION-IND", "UnitAllocationInd");
        public static WinFormsField WebInterfaceInd = new WinFormsField("WEB-INTERFACE-IND", "WebInterfaceInd");
        public static WinFormsField PriceBase = new WinFormsField("PRICE-BASE", "PriceBase");
        public static WinFormsField PurchaseType = new WinFormsField("PURCHASE-TYPE", "PurchaseType");
        public static WinFormsField IvrInterfaceInd = new WinFormsField("IVR-INTERFACE-IND", "IvrInterfaceInd");
        public static WinFormsField LoanClassInd = new WinFormsField("LOAN-CLASS-IND", "LoanClassInd");
        public static WinFormsField ResidueProcessingInd = new WinFormsField("RESIDUE-PROCESSING-IND", "ResidueProcessingInd");
        public static WinFormsField ScripOptionsInd = new WinFormsField("SCRIP-OPTIONS-IND", "ScripOptionsInd");
        public static WinFormsField EmployerPymtMethod = new WinFormsField("EMPLOYER-PYMT-METHOD", "EmployerPymtMethod");
        public static WinFormsField ResidueLevelPaidOut = new WinFormsField("RESIDUE-LEVEL-PAID-OUT", "ResidueLevelPaidOut");
        public static WinFormsField ExternalExerciseInd = new WinFormsField("EXTERNAL-EXERCISE-IND", "ExternalExerciseInd");
        public static WinFormsField Mtc0StcResidualInd = new WinFormsField("MTC0-STC-RESIDUAL-IND", "Mtc0StcResidualInd");
        public static WinFormsField EmployerHolderID = new WinFormsField("EMPLOYER-HOLDER-ID", "EmployerHolderID");
        public static WinFormsField CutOffTime = new WinFormsField("CUT-OFF-TIME", "CutOffTime");
        public static WinFormsField EstimateUnitsTopup = new WinFormsField("ESTIMATE-UNITS-TOPUP", "EstimateUnitsTopup");
        public static WinFormsField AuditInd = new WinFormsField("AUDIT-IND", "AuditInd");
        public static WinFormsField MinimumInitialInvest = new WinFormsField("MINIMUM-INITIAL-INVEST", "MinimumInitialInvest");
        public static WinFormsField TransactionLimitInd = new WinFormsField("TRANSACTION-LIMIT-IND", "TransactionLimitInd");
        public static WinFormsField MinInitialInvestInd = new WinFormsField("MIN-INITIAL-INVEST-IND", "MinInitialInvestInd");
        public static WinFormsField TransactionLimitMin = new WinFormsField("TRANSACTION-LIMIT-MIN", "TransactionLimitMin");
        public static WinFormsField IntervalLimitInd = new WinFormsField("INTERVAL-LIMIT-IND", "IntervalLimitInd");
        public static WinFormsField TransactionLimitMax = new WinFormsField("TRANSACTION-LIMIT-MAX", "TransactionLimitMax");
        public static WinFormsField IntervalLimit = new WinFormsField("INTERVAL-LIMIT", "IntervalLimit");
        public static WinFormsField RecordMoneyORUnits = new WinFormsField("RECORD-MONEY-OR-UNITS", "RecordMoneyORUnits");
        public static WinFormsField AnnualLimit = new WinFormsField("ANNUAL-LIMIT", "AnnualLimit");
        public static WinFormsField MinimumDeal = new WinFormsField("MINIMUM-DEAL", "MinimumDeal");
        public static WinFormsField MaximumDeal = new WinFormsField("MAXIMUM-DEAL", "MaximumDeal");
        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField ReportableValue = new WinFormsField("REPORTABLE-VALUE", "ReportableValue");
        public static WinFormsField LoanPayAccount = new WinFormsField("LOAN-PAY-ACCOUNT", "LoanPayAccount");
        public static WinFormsField AllowCorporateBodiesInd = new WinFormsField("ALLOW-CORPORATE-BODIES-IND", "AllowCorporateBodiesInd");
        public static WinFormsField AllowWarningFlag1Ind = new WinFormsField("ALLOW-WARNING-FLAG1-IND", "AllowWarningFlag1Ind");
        public static WinFormsField PurchaseResPayAccount = new WinFormsField("PURCHASE-RES-PAY-ACCOUNT", "PurchaseResPayAccount");
        public static WinFormsField AllowForeignResidInd = new WinFormsField("ALLOW-FOREIGN-RESID-IND", "AllowForeignResidInd");
        public static WinFormsField AllowWarningFlag2Ind = new WinFormsField("ALLOW-WARNING-FLAG2-IND", "AllowWarningFlag2Ind");
        public static WinFormsField ZarWireSuppressInd = new WinFormsField("ZAR-WIRE-SUPPRESS-IND", "ZarWireSuppressInd");
        public static WinFormsField AllowPartialSellInd = new WinFormsField("ALLOW-PARTIAL-SELL-IND", "AllowPartialSellInd");
        public static WinFormsField AllowWarningFlag3Ind = new WinFormsField("ALLOW-WARNING-FLAG3-IND", "AllowWarningFlag3Ind");
        public static WinFormsField ValidPaymentMethod = new WinFormsField("VALID-PAYMENT-METHOD", "ValidPaymentMethod");
        public static WinFormsField AllowDeceasedInd = new WinFormsField("ALLOW-DECEASED-IND", "AllowDeceasedInd");
        public static WinFormsField AllowWarningFlag4Ind = new WinFormsField("ALLOW-WARNING-FLAG4-IND", "AllowWarningFlag4Ind");
        public static WinFormsField DefaultPaymentMethod = new WinFormsField("DEFAULT-PAYMENT-METHOD", "DefaultPaymentMethod");
        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField AllowCertPartSellInd = new WinFormsField("ALLOW-CERT-PART-SELL-IND", "AllowCertPartSellInd");
        public static WinFormsField AllowWarningFlag5Ind = new WinFormsField("ALLOW-WARNING-FLAG5-IND", "AllowWarningFlag5Ind");
        public static WinFormsField ExistPayDirCredInd = new WinFormsField("EXIST-PAY-DIR-CRED-IND", "ExistPayDirCredInd");
        public static WinFormsField PermPayDirCredInd = new WinFormsField("PERM-PAY-DIR-CRED-IND", "PermPayDirCredInd");
        public static WinFormsField TempPayDirCredInd = new WinFormsField("TEMP-PAY-DIR-CRED-IND", "TempPayDirCredInd");
        public static WinFormsField AllowReturnMailInd = new WinFormsField("ALLOW-RETURN-MAIL-IND", "AllowReturnMailInd");
        public static WinFormsField AllowWarningFlag6Ind = new WinFormsField("ALLOW-WARNING-FLAG6-IND", "AllowWarningFlag6Ind");
        public static WinFormsField ExistPayWireInd = new WinFormsField("EXIST-PAY-WIRE-IND", "ExistPayWireInd");
        public static WinFormsField PermPayWireInd = new WinFormsField("PERM-PAY-WIRE-IND", "PermPayWireInd");
        public static WinFormsField TempPayWireInd = new WinFormsField("TEMP-PAY-WIRE-IND", "TempPayWireInd");
        public static WinFormsField AllowTinUncertifiedInd = new WinFormsField("ALLOW-TIN-UNCERTIFIED-IND", "AllowTinUncertifiedInd");
        public static WinFormsField AllowWarningFlag7Ind = new WinFormsField("ALLOW-WARNING-FLAG7-IND", "AllowWarningFlag7Ind");
        public static WinFormsField DefaultPaymentCurrency = new WinFormsField("DEFAULT-PAYMENT-CURRENCY", "DefaultPaymentCurrency");
        public static WinFormsField AllowFullSellInd = new WinFormsField("ALLOW-FULL-SELL-IND", "AllowFullSellInd");
        public static WinFormsField AllowWarningFlag8Ind = new WinFormsField("ALLOW-WARNING-FLAG8-IND", "AllowWarningFlag8Ind");
        public static WinFormsField AllowSellSelectedInd = new WinFormsField("ALLOW-SELL-SELECTED-IND", "AllowSellSelectedInd");
        public static WinFormsField AllowWarningFlag9Ind = new WinFormsField("ALLOW-WARNING-FLAG9-IND", "AllowWarningFlag9Ind");
        public static WinFormsField PaymentCurrency = new WinFormsField("PAYMENT-CURRENCY", "PaymentCurrency");
        public static WinFormsField AllowSellTOCoverInd = new WinFormsField("ALLOW-SELL-TO-COVER-IND", "AllowSellTOCoverInd");
        public static WinFormsField AllowPurchaseResidue = new WinFormsField("ALLOW-PURCHASE-RESIDUE", "AllowPurchaseResidue");
        public static WinFormsField BuildPaymentsInd = new WinFormsField("BUILD-PAYMENTS-IND", "BuildPaymentsInd");
        public static WinFormsField AllowDirectDebitsInd = new WinFormsField("ALLOW-DIRECT-DEBITS-IND", "AllowDirectDebitsInd");
        public static WinFormsField AllowFwdInsInd = new WinFormsField("ALLOW-FWD-INS-IND", "AllowFwdInsInd");
        public static WinFormsField WorldlinkNumber = new WinFormsField("WORLDLINK-NUMBER", "WorldlinkNumber");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoTime1 = new WinFormsField("SYSTEM-INFO-TIME-1", "1", "1");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
