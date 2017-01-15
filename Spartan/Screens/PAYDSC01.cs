using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAYDSC01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAYDSC01", "FormName");
		//Fields


        public static WinFormsField PaydscKey0 = new WinFormsField("PAYDSC-KEY0", "PaydscKey0");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField PaymentDesc = new WinFormsField("PAYMENT-DESC", "PaymentDesc");
        public static WinFormsField PaymentExtraDesc = new WinFormsField("PAYMENT-EXTRA-DESC", "PaymentExtraDesc");
        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
        public static WinFormsField BaseCurrency = new WinFormsField("BASE-CURRENCY", "BaseCurrency");
        public static WinFormsField ConversionRateAus = new WinFormsField("CONVERSION-RATE-AUS", "ConversionRateAus");
        public static WinFormsField NZTaxFlag = new WinFormsField("NZ-TAX-FLAG", "NZTaxFlag");
        public static WinFormsField ConversionRateNZ = new WinFormsField("CONVERSION-RATE-NZ", "ConversionRateNZ");
        public static WinFormsField HighRefNbr = new WinFormsField("HIGH-REF-NBR", "HighRefNbr");
        public static WinFormsField ImputationRate = new WinFormsField("IMPUTATION-RATE", "ImputationRate");
        public static WinFormsField GbrTaxFlag = new WinFormsField("GBR-TAX-FLAG", "GbrTaxFlag");
        public static WinFormsField ConversionRateGbr = new WinFormsField("CONVERSION-RATE-GBR", "ConversionRateGbr");
        public static WinFormsField LowRefNbr = new WinFormsField("LOW-REF-NBR", "LowRefNbr");
        public static WinFormsField ImputationFactor = new WinFormsField("IMPUTATION-FACTOR", "ImputationFactor");
        public static WinFormsField LoanDeductionInd = new WinFormsField("LOAN-DEDUCTION-IND", "LoanDeductionInd");
        public static WinFormsField MultipleClassInd = new WinFormsField("MULTIPLE-CLASS-IND", "MultipleClassInd");
        public static WinFormsField OtherTaxAmountInd = new WinFormsField("OTHER-TAX-AMOUNT-IND", "OtherTaxAmountInd");
        public static WinFormsField ExtraTaxAmountInd = new WinFormsField("EXTRA-TAX-AMOUNT-IND", "ExtraTaxAmountInd");
        public static WinFormsField LastBatchChequeNbr = new WinFormsField("LAST-BATCH-CHEQUE-NBR", "LastBatchChequeNbr");
        public static WinFormsField GrossAmount = new WinFormsField("GROSS-AMOUNT", "GrossAmount");
        public static WinFormsField DeductionsInd = new WinFormsField("DEDUCTIONS-IND", "DeductionsInd");
        public static WinFormsField LastBatchRefNbr = new WinFormsField("LAST-BATCH-REF-NBR", "LastBatchRefNbr");
        public static WinFormsField NettAmount = new WinFormsField("NETT-AMOUNT", "NettAmount");
        public static WinFormsField SplitTaxFree = new WinFormsField("SPLIT-TAX-FREE", "SplitTaxFree");
        public static WinFormsField MCDomCode = new WinFormsField("MC-DOM-CODE", "MCDomCode");
        public static WinFormsField SplitTaxable = new WinFormsField("SPLIT-TAXABLE", "SplitTaxable");
        public static WinFormsField CurrencyDesc = new WinFormsField("CURRENCY-DESC", "CurrencyDesc");
        public static WinFormsField FinancialYear = new WinFormsField("FINANCIAL-YEAR", "FinancialYear");
        public static WinFormsField PayMandtryDcr = new WinFormsField("PAY-MANDTRY-DCR", "PayMandtryDcr");
        public static WinFormsField CurrencyConvRate = new WinFormsField("CURRENCY-CONV-RATE", "CurrencyConvRate");
        public static WinFormsField TaxTapeFlag = new WinFormsField("TAX-TAPE-FLAG", "TaxTapeFlag");
        public static WinFormsField ReplMandtryDcr = new WinFormsField("REPL-MANDTRY-DCR", "ReplMandtryDcr");
        public static WinFormsField Post0992Indicator = new WinFormsField("POST-0992-INDICATOR", "Post0992Indicator");
        public static WinFormsField InvestmentType = new WinFormsField("INVESTMENT-TYPE", "InvestmentType");
        public static WinFormsField StartBatchChqRange = new WinFormsField("START-BATCH-CHQ-RANGE", "StartBatchChqRange");
        public static WinFormsField ComputershareRecnInd = new WinFormsField("COMPUTERSHARE-RECN-IND", "ComputershareRecnInd");
        public static WinFormsField FrankedTOPercent = new WinFormsField("FRANKED-TO-PERCENT", "FrankedTOPercent");
        public static WinFormsField EndBatchChqRange = new WinFormsField("END-BATCH-CHQ-RANGE", "EndBatchChqRange");
        public static WinFormsField AustTaxFlag = new WinFormsField("AUST-TAX-FLAG", "AustTaxFlag");
        public static WinFormsField InvestmentDesc = new WinFormsField("INVESTMENT-DESC", "InvestmentDesc");
        public static WinFormsField SubCompanyCode = new WinFormsField("SUB-COMPANY-CODE", "SubCompanyCode");
        public static WinFormsField LastBankTapeNbr = new WinFormsField("LAST-BANK-TAPE-NBR", "LastBankTapeNbr");
        public static WinFormsField UnclaimMoneyReportInd = new WinFormsField("UNCLAIM-MONEY-REPORT-IND", "UnclaimMoneyReportInd");
        public static WinFormsField WebReportingInd = new WinFormsField("WEB-REPORTING-IND", "WebReportingInd");
        public static WinFormsField UnclaimMnyRecipientFlag = new WinFormsField("UNCLAIM-MNY-RECIPIENT-FLAG", "UnclaimMnyRecipientFlag");
        public static WinFormsField AccurateReconciledInd = new WinFormsField("ACCURATE-RECONCILED-IND", "AccurateReconciledInd");
        public static WinFormsField ReportGroupCode = new WinFormsField("REPORT-GROUP-CODE", "ReportGroupCode");
        public static WinFormsField AtoCgtReportingInd = new WinFormsField("ATO-CGT-REPORTING-IND", "AtoCgtReportingInd");
        public static WinFormsField PayAccountBalancedInd = new WinFormsField("PAY-ACCOUNT-BALANCED-IND", "PayAccountBalancedInd");
        public static WinFormsField CombinedPaymentInd = new WinFormsField("COMBINED-PAYMENT-IND", "CombinedPaymentInd");
        public static WinFormsField DepartmentCode = new WinFormsField("DEPARTMENT-CODE", "DepartmentCode");
        public static WinFormsField ReconciliationAcctInd = new WinFormsField("RECONCILIATION-ACCT-IND", "ReconciliationAcctInd");
        public static WinFormsField IatReportingInd = new WinFormsField("IAT-REPORTING-IND", "IatReportingInd");
        public static WinFormsField IatCode = new WinFormsField("IAT-CODE", "IatCode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
