using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PLNCTL11

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PLNCTL11", "FormName");
		//Fields


        public static WinFormsField PlnctlKey0 = new WinFormsField("PLNCTL-KEY0", "PlnctlKey0");
        public static WinFormsField PlanConcept = new WinFormsField("PLAN-CONCEPT", "PlanConcept");
        public static WinFormsField BriefPlanDescription = new WinFormsField("BRIEF-PLAN-DESCRIPTION", "BriefPlanDescription");
        public static WinFormsField DivSource = new WinFormsField("DIV-SOURCE", "DivSource");
        public static WinFormsField GeneralPlanDesc = new WinFormsField("GENERAL-PLAN-DESC", "GeneralPlanDesc");
        public static WinFormsField AlternateCompanyName = new WinFormsField("ALTERNATE-COMPANY-NAME", "AlternateCompanyName");
        public static WinFormsField CountryCalculation = new WinFormsField("COUNTRY-CALCULATION", "CountryCalculation");
        public static WinFormsField ImputationRate = new WinFormsField("IMPUTATION-RATE", "ImputationRate");
        public static WinFormsField WithholdingTax = new WinFormsField("WITHHOLDING-TAX", "WithholdingTax");
        public static WinFormsField PercentageBuildFactor = new WinFormsField("PERCENTAGE-BUILD-FACTOR", "PercentageBuildFactor");
        public static WinFormsField CurrencyFlag = new WinFormsField("CURRENCY-FLAG", "CurrencyFlag");
        public static WinFormsField FdaProcessingFlag = new WinFormsField("FDA-PROCESSING-FLAG", "FdaProcessingFlag");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
