using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVHIS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVHIS01", "FormName");
		//Fields


        public static WinFormsField DivhisKey0 = new WinFormsField("DIVHIS-KEY0", "DivhisKey0");
        public static WinFormsField DividendType = new WinFormsField("DIVIDEND-TYPE", "DividendType");
        public static WinFormsField BCRunNumber = new WinFormsField("BC-RUN-NUMBER", "BCRunNumber");
        public static WinFormsField NARunNumber = new WinFormsField("NA-RUN-NUMBER", "NARunNumber");
        public static WinFormsField DividendPlanApply = new WinFormsField("DIVIDEND-PLAN-APPLY", "DividendPlanApply");
        public static WinFormsField CorporateAction = new WinFormsField("CORPORATE-ACTION", "CorporateAction");
        public static WinFormsField BaseCurrency = new WinFormsField("BASE-CURRENCY", "BaseCurrency");
        public static WinFormsField MultiTypePlansInd = new WinFormsField("MULTI-TYPE-PLANS-IND", "MultiTypePlansInd");
        public static WinFormsField DividendPlan = new WinFormsField("DIVIDEND-PLAN", "DividendPlan");
        public static WinFormsField CosRate1 = new WinFormsField("COS-RATE1", "CosRate1");
        public static WinFormsField CosRate2 = new WinFormsField("COS-RATE2", "CosRate2");
        public static WinFormsField CosRate3 = new WinFormsField("COS-RATE3", "CosRate3");
        public static WinFormsField CosRate4 = new WinFormsField("COS-RATE4", "CosRate4");
        public static WinFormsField CosRate5 = new WinFormsField("COS-RATE5", "CosRate5");
        public static WinFormsField CosRate6 = new WinFormsField("COS-RATE6", "CosRate6");
        public static WinFormsField CosRate7 = new WinFormsField("COS-RATE7", "CosRate7");
        public static WinFormsField CosRate8 = new WinFormsField("COS-RATE8", "CosRate8");
        public static WinFormsField CosRate9 = new WinFormsField("COS-RATE9", "CosRate9");
        public static WinFormsField CosRate10 = new WinFormsField("COS-RATE10", "CosRate10");
        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField CostShares = new WinFormsField("COST-SHARES", "CostShares");
        public static WinFormsField CertificateAllotDate = new WinFormsField("CERTIFICATE-ALLOT-DATE", "CertificateAllotDate");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField CatcdeCode = new WinFormsField("CATCDE-CODE", "CatcdeCode");
        public static WinFormsField SecasxCode = new WinFormsField("SECASX-CODE", "SecasxCode");
        public static WinFormsField DivRate1 = new WinFormsField("DIV-RATE1", "DivRate1");
        public static WinFormsField DivRate2 = new WinFormsField("DIV-RATE2", "DivRate2");
        public static WinFormsField DivRate3 = new WinFormsField("DIV-RATE3", "DivRate3");
        public static WinFormsField DivRate4 = new WinFormsField("DIV-RATE4", "DivRate4");
        public static WinFormsField DivRate5 = new WinFormsField("DIV-RATE5", "DivRate5");
        public static WinFormsField DivRate6 = new WinFormsField("DIV-RATE6", "DivRate6");
        public static WinFormsField DivRate7 = new WinFormsField("DIV-RATE7", "DivRate7");
        public static WinFormsField DivRate8 = new WinFormsField("DIV-RATE8", "DivRate8");
        public static WinFormsField DivRate9 = new WinFormsField("DIV-RATE9", "DivRate9");
        public static WinFormsField DivRate10 = new WinFormsField("DIV-RATE10", "DivRate10");
        public static WinFormsField IntDays = new WinFormsField("INT-DAYS", "IntDays");
        public static WinFormsField TaxCtryCode = new WinFormsField("TAX-CTRY-CODE", "TaxCtryCode");
        public static WinFormsField CountryCalculation = new WinFormsField("COUNTRY-CALCULATION", "CountryCalculation");
        public static WinFormsField OtherTaxCtryCode = new WinFormsField("OTHER-TAX-CTRY-CODE", "OtherTaxCtryCode");
        public static WinFormsField MCFirstDomCode = new WinFormsField("MC-FIRST-DOM-CODE", "MCFirstDomCode");
        public static WinFormsField MCPayAccountNumber = new WinFormsField("MC-PAY-ACCOUNT-NUMBER", "MCPayAccountNumber");
        public static WinFormsField MCConversionRate = new WinFormsField("MC-CONVERSION-RATE", "MCConversionRate");
        public static WinFormsField DeferTaxCalcFlag = new WinFormsField("DEFER-TAX-CALC-FLAG", "DeferTaxCalcFlag");
        public static WinFormsField DeductionCodeInd = new WinFormsField("DEDUCTION-CODE-IND", "DeductionCodeInd");
        public static WinFormsField CombinedPaymentFlag = new WinFormsField("COMBINED-PAYMENT-FLAG", "CombinedPaymentFlag");
        public static WinFormsField InterestRepCodeInd = new WinFormsField("INTEREST-REP-CODE-IND", "InterestRepCodeInd");
        public static WinFormsField TttTaxInd = new WinFormsField("TTT-TAX-IND", "TttTaxInd");
        public static WinFormsField TttCountryCode = new WinFormsField("TTT-COUNTRY-CODE", "TttCountryCode");
        public static WinFormsField TttTaxExchangeRate = new WinFormsField("TTT-TAX-EXCHANGE-RATE", "TttTaxExchangeRate");
        public static WinFormsField TttRate1 = new WinFormsField("TTT-RATE1", "TttRate1");
        public static WinFormsField TttRate2 = new WinFormsField("TTT-RATE2", "TttRate2");
        public static WinFormsField TttRate3 = new WinFormsField("TTT-RATE3", "TttRate3");
        public static WinFormsField TttRate4 = new WinFormsField("TTT-RATE4", "TttRate4");
        public static WinFormsField TttRate5 = new WinFormsField("TTT-RATE5", "TttRate5");
        public static WinFormsField TttRate6 = new WinFormsField("TTT-RATE6", "TttRate6");
        public static WinFormsField TttRate7 = new WinFormsField("TTT-RATE7", "TttRate7");
        public static WinFormsField TttRate8 = new WinFormsField("TTT-RATE8", "TttRate8");
        public static WinFormsField TttRate9 = new WinFormsField("TTT-RATE9", "TttRate9");
        public static WinFormsField TttRate10 = new WinFormsField("TTT-RATE10", "TttRate10");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
