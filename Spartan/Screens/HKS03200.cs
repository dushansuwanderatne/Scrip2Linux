using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS03200

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS03200", "FormName");
		//Fields


        public static WinFormsField DivSource = new WinFormsField("DIV-SOURCE", "DivSource");
        public static WinFormsField BriefPlnDescription = new WinFormsField("BRIEF-PLN-DESCRIPTION", "BriefPlnDescription");
        public static WinFormsField GeneralPlanDesc = new WinFormsField("GENERAL-PLAN-DESC", "GeneralPlanDesc");
        public static WinFormsField CountryCalculation = new WinFormsField("COUNTRY-CALCULATION", "CountryCalculation");
        public static WinFormsField DualTaxCtryCode = new WinFormsField("DUAL-TAX-CTRY-CODE", "DualTaxCtryCode");
        public static WinFormsField WithholdingTax = new WinFormsField("WITHHOLDING-TAX", "WithholdingTax");
        public static WinFormsField ImputationRate = new WinFormsField("IMPUTATION-RATE", "ImputationRate");
        public static WinFormsField QArrangement = new WinFormsField("Q-ARRANGEMENT", "QArrangement");
        public static WinFormsField AlterCompanyName = new WinFormsField("ALTER-COMPANY-NAME", "AlterCompanyName");
        public static WinFormsField SuppDivNonres = new WinFormsField("SUPP-DIV-NONRES", "SuppDivNonres");
        public static WinFormsField CurrencyFlag = new WinFormsField("CURRENCY-FLAG", "CurrencyFlag");
        public static WinFormsField SuppCompanyRate = new WinFormsField("SUPP-COMPANY-RATE", "SuppCompanyRate");
        public static WinFormsField SuppDualRate = new WinFormsField("SUPP-DUAL-RATE", "SuppDualRate");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField TaxCountry = new WinFormsField("TAX-COUNTRY", "TaxCountry");
        public static WinFormsField CountryDesc = new WinFormsField("COUNTRY-DESC", "CountryDesc");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
