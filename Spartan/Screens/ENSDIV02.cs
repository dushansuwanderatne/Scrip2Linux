using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSDIV02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSDIV02", "FormName");
		//Fields
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField CalcCurrency = new WinFormsField("CALC-CURRENCY", "CalcCurrency");
        public static WinFormsField DividendType = new WinFormsField("DIVIDEND-TYPE", "DividendType");
        public static WinFormsField DividendDesc = new WinFormsField("DIVIDEND-DESC", "DividendDesc");
        public static WinFormsField Gross = new WinFormsField("GROSS", "Gross");
        public static WinFormsField PayDetails = new WinFormsField("PAY-DETAILS", "PayDetails");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField DividendSource = new WinFormsField("DIVIDEND-SOURCE", "DividendSource");
        public static WinFormsField Deductions = new WinFormsField("DEDUCTIONS", "Deductions");
        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField TaxBase = new WinFormsField("TAX-BASE", "TaxBase");
        public static WinFormsField ChequeNumber = new WinFormsField("CHEQUE-NUMBER", "ChequeNumber");
        public static WinFormsField TaxOth = new WinFormsField("TAX-OTH", "TaxOth");
        public static WinFormsField Nett = new WinFormsField("NETT", "Nett");
        public static WinFormsField PaidCurrCode = new WinFormsField("PAID-CURR-CODE", "PaidCurrCode");
        public static WinFormsField PaidCurrRate = new WinFormsField("PAID-CURR-RATE", "PaidCurrRate");
        public static WinFormsField PaidCurrAmount = new WinFormsField("PAID-CURR-AMOUNT", "PaidCurrAmount");
        public static WinFormsField SelectionNumber = new WinFormsField("SELECTION-NUMBER", "SelectionNumber");
        public static WinFormsField SubPayCode = new WinFormsField("SUB-PAY-CODE", "SubPayCode");
        public static WinFormsField SubPayType = new WinFormsField("SUB-PAY-TYPE", "SubPayType");
        public static WinFormsField SubPayDesc = new WinFormsField("SUB-PAY-DESC", "SubPayDesc");
        public static WinFormsField SubPayGross = new WinFormsField("SUB-PAY-GROSS", "SubPayGross");
        public static WinFormsField SubPayTaxDeduct = new WinFormsField("SUB-PAY-TAX-DEDUCT", "SubPayTaxDeduct");
        public static WinFormsField SubPayNett = new WinFormsField("SUB-PAY-NETT", "SubPayNett");
        public static WinFormsField Ensdiv02MoreTOComeInd = new WinFormsField("ENSDIV02-MORE-TO-COME-IND", "Ensdiv02MoreTOComeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField TaxOrideCode = new WinFormsField("TAX-ORIDE-CODE", "TaxOrideCode");
        public static WinFormsField DeductionNote = new WinFormsField("DEDUCTION-NOTE", "DeductionNote");
        public static WinFormsField Additions = new WinFormsField("ADDITIONS", "Additions");
        public static WinFormsField TaxCountry = new WinFormsField("TAX-COUNTRY", "TaxCountry");
        public static WinFormsField OtherTaxCountry = new WinFormsField("OTHER-TAX-COUNTRY", "OtherTaxCountry");
        public static WinFormsField LoanCurrCode = new WinFormsField("LOAN-CURR-CODE", "LoanCurrCode");
        public static WinFormsField PaidLoanAmt = new WinFormsField("PAID-LOAN-AMT", "PaidLoanAmt");
        public static WinFormsField CommLine = new WinFormsField("COMM-LINE", "CommLine");
        public static WinFormsField TaxCountryOR = new WinFormsField("TAX-COUNTRY-OR", "TaxCountryOR");
        public static WinFormsField OtherTaxOrideCode = new WinFormsField("OTHER-TAX-ORIDE-CODE", "OtherTaxOrideCode");
        public static WinFormsField OtherTaxCountryOR = new WinFormsField("OTHER-TAX-COUNTRY-OR", "OtherTaxCountryOR");
        public static WinFormsField TinStatus = new WinFormsField("TIN-STATUS", "TinStatus");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
