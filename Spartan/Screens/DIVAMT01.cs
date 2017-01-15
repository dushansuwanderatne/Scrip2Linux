using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVAMT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVAMT01", "FormName");
		//Fields


        public static WinFormsField DivamtKey0 = new WinFormsField("DIVAMT-KEY0", "DivamtKey0");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField DivhisKey1 = new WinFormsField("DIVHIS-KEY1", "DivhisKey1");
        public static WinFormsField DividendSource = new WinFormsField("DIVIDEND-SOURCE", "DividendSource");
        public static WinFormsField PayMethod = new WinFormsField("PAY-METHOD", "PayMethod");
        public static WinFormsField ReferenceNumber = new WinFormsField("REFERENCE-NUMBER", "ReferenceNumber");
        public static WinFormsField SubPaymentCode = new WinFormsField("SUB-PAYMENT-CODE", "SubPaymentCode");
        public static WinFormsField CatcdeCode = new WinFormsField("CATCDE-CODE", "CatcdeCode");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField CompCode = new WinFormsField("COMP-CODE", "CompCode");
        public static WinFormsField DivamtKey1 = new WinFormsField("DIVAMT-KEY1", "DivamtKey1");
        public static WinFormsField CompTypeCode = new WinFormsField("COMP-TYPE-CODE", "CompTypeCode");
        public static WinFormsField CompCatCode = new WinFormsField("COMP-CAT-CODE", "CompCatCode");
        public static WinFormsField CompAmt = new WinFormsField("COMP-AMT", "CompAmt");
        public static WinFormsField CompAmtType = new WinFormsField("COMP-AMT-TYPE", "CompAmtType");
        public static WinFormsField CompRate = new WinFormsField("COMP-RATE", "CompRate");
        public static WinFormsField CompRateFlag = new WinFormsField("COMP-RATE-FLAG", "CompRateFlag");
        public static WinFormsField CompCalcAmt = new WinFormsField("COMP-CALC-AMT", "CompCalcAmt");
        public static WinFormsField CalcSeq = new WinFormsField("CALC-SEQ", "CalcSeq");
        public static WinFormsField RepPayAccount = new WinFormsField("REP-PAY-ACCOUNT", "RepPayAccount");
        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
        public static WinFormsField TaxAmt = new WinFormsField("TAX-AMT", "TaxAmt");
        public static WinFormsField OtherTaxAmt = new WinFormsField("OTHER-TAX-AMT", "OtherTaxAmt");
        public static WinFormsField TaxRate = new WinFormsField("TAX-RATE", "TaxRate");
        public static WinFormsField OtherTaxRate = new WinFormsField("OTHER-TAX-RATE", "OtherTaxRate");
        public static WinFormsField TaxCode = new WinFormsField("TAX-CODE", "TaxCode");
        public static WinFormsField OtherTaxCode = new WinFormsField("OTHER-TAX-CODE", "OtherTaxCode");
        public static WinFormsField TaxType = new WinFormsField("TAX-TYPE", "TaxType");
        public static WinFormsField OtherTaxType = new WinFormsField("OTHER-TAX-TYPE", "OtherTaxType");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
