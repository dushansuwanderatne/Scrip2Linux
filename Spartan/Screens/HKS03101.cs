using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS03101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS03101", "FormName");
		//Fields


        public static WinFormsField PlanConcept = new WinFormsField("PLAN-CONCEPT", "PlanConcept");
        public static WinFormsField PlanCategory = new WinFormsField("PLAN-CATEGORY", "PlanCategory");
        public static WinFormsField CurrencyFlag = new WinFormsField("CURRENCY-FLAG", "CurrencyFlag");
        public static WinFormsField DisplayOnline = new WinFormsField("DISPLAY-ONLINE", "DisplayOnline");
        public static WinFormsField UpdateOnline = new WinFormsField("UPDATE-ONLINE", "UpdateOnline");
        public static WinFormsField AltPlanConcept = new WinFormsField("ALT-PLAN-CONCEPT", "AltPlanConcept");
        public static WinFormsField BriefPlanDesc = new WinFormsField("BRIEF-PLAN-DESC", "BriefPlanDesc");
        public static WinFormsField GeneralPlanDesc = new WinFormsField("GENERAL-PLAN-DESC", "GeneralPlanDesc");
        public static WinFormsField OnlinePlanDesc = new WinFormsField("ONLINE-PLAN-DESC", "OnlinePlanDesc");
        public static WinFormsField ParticipationOption = new WinFormsField("PARTICIPATION-OPTION", "ParticipationOption");
        public static WinFormsField IssueClass = new WinFormsField("ISSUE-CLASS", "IssueClass");
        public static WinFormsField IssueRegister = new WinFormsField("ISSUE-REGISTER", "IssueRegister");
        public static WinFormsField EssRegisterCode = new WinFormsField("ESS-REGISTER-CODE", "EssRegisterCode");
        public static WinFormsField UnissuedCertificates = new WinFormsField("UNISSUED-CERTIFICATES", "UnissuedCertificates");
        public static WinFormsField IssueMinimum = new WinFormsField("ISSUE-MINIMUM", "IssueMinimum");
        public static WinFormsField IssueMultiple = new WinFormsField("ISSUE-MULTIPLE", "IssueMultiple");
        public static WinFormsField MoneyClass = new WinFormsField("MONEY-CLASS", "MoneyClass");
        public static WinFormsField AllowOvrrideMnyCls = new WinFormsField("ALLOW-OVRRIDE-MNY-CLS", "AllowOvrrideMnyCls");
        public static WinFormsField UnitRoundOpt = new WinFormsField("UNIT-ROUND-OPT", "UnitRoundOpt");
        public static WinFormsField CatLevelAdjustment = new WinFormsField("CAT-LEVEL-ADJUSTMENT", "CatLevelAdjustment");
        public static WinFormsField CatLevelAdjPlan = new WinFormsField("CAT-LEVEL-ADJ-PLAN", "CatLevelAdjPlan");
        public static WinFormsField NOChangeDate = new WinFormsField("NO-CHANGE-DATE", "NOChangeDate");
        public static WinFormsField ExcludeDomCodes = new WinFormsField("EXCLUDE-DOM-CODES", "ExcludeDomCodes");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField SearchName = new WinFormsField("SEARCH-NAME", "SearchName");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
