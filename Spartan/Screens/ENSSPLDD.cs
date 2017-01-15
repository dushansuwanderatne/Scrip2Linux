using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSSPLDD

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSSPLDD", "FormName");
		//Fields


        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField Gross = new WinFormsField("GROSS", "Gross");
        public static WinFormsField DividendType = new WinFormsField("DIVIDEND-TYPE", "DividendType");
        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField Nett = new WinFormsField("NETT", "Nett");
        public static WinFormsField DividendSource = new WinFormsField("DIVIDEND-SOURCE", "DividendSource");
        public static WinFormsField ChequeNumber = new WinFormsField("CHEQUE-NUMBER", "ChequeNumber");
        public static WinFormsField Tax = new WinFormsField("TAX", "Tax");
        public static WinFormsField TaxType = new WinFormsField("TAX-TYPE", "TaxType");
        public static WinFormsField PayDetails = new WinFormsField("PAY-DETAILS", "PayDetails");
        public static WinFormsField MultCurr = new WinFormsField("MULT-CURR", "MultCurr");
        public static WinFormsField CurrencyDesc = new WinFormsField("CURRENCY-DESC", "CurrencyDesc");
        public static WinFormsField LoanDeduction = new WinFormsField("LOAN-DEDUCTION", "LoanDeduction");
        public static WinFormsField ExtraTaxAmount = new WinFormsField("EXTRA-TAX-AMOUNT", "ExtraTaxAmount");
        public static WinFormsField OtherTaxAmount = new WinFormsField("OTHER-TAX-AMOUNT", "OtherTaxAmount");
        public static WinFormsField TotImpFranHead = new WinFormsField("TOT-IMP-FRAN-HEAD", "TotImpFranHead");
        public static WinFormsField TotImpFranCredit = new WinFormsField("TOT-IMP-FRAN-CREDIT", "TotImpFranCredit");
        public static WinFormsField TotTttTaxHead = new WinFormsField("TOT-TTT-TAX-HEAD", "TotTttTaxHead");
        public static WinFormsField TotTttTaxCredit = new WinFormsField("TOT-TTT-TAX-CREDIT", "TotTttTaxCredit");
        public static WinFormsField MCConvRate = new WinFormsField("MC-CONV-RATE", "MCConvRate");
        public static WinFormsField ImpFranHeading = new WinFormsField("IMP-FRAN-HEADING", "ImpFranHeading");
        public static WinFormsField TttTaxHeading = new WinFormsField("TTT-TAX-HEADING", "TttTaxHeading");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField Cat = new WinFormsField("CAT", "Cat");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField Column1 = new WinFormsField("COLUMN1", "Column1");
        public static WinFormsField Column2 = new WinFormsField("COLUMN2", "Column2");
        public static WinFormsField Column3 = new WinFormsField("COLUMN3", "Column3");
        public static WinFormsField Column4 = new WinFormsField("COLUMN4", "Column4");
        public static WinFormsField Column5 = new WinFormsField("COLUMN5", "Column5");
        public static WinFormsField ExcludeDom = new WinFormsField("EXCLUDE-DOM", "ExcludeDom");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField TotTttGrossHead = new WinFormsField("TOT-TTT-GROSS-HEAD", "TotTttGrossHead");
        public static WinFormsField TotTttGrossAmt = new WinFormsField("TOT-TTT-GROSS-AMT", "TotTttGrossAmt");
        public static WinFormsField TotTttAggrHead1 = new WinFormsField("TOT-TTT-AGGR-HEAD1", "TotTttAggrHead1");
        public static WinFormsField TotTttAggrHead2 = new WinFormsField("TOT-TTT-AGGR-HEAD2", "TotTttAggrHead2");
        public static WinFormsField TotTttAggregateAmt = new WinFormsField("TOT-TTT-AGGREGATE-AMT", "TotTttAggregateAmt");
        public static WinFormsField TttTaxExchangeRate = new WinFormsField("TTT-TAX-EXCHANGE-RATE", "TttTaxExchangeRate");
        public static WinFormsField TttTaxRateHead = new WinFormsField("TTT-TAX-RATE-HEAD", "TttTaxRateHead");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
