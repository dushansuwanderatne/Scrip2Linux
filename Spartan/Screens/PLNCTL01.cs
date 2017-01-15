using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PLNCTL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PLNCTL01", "FormName");
		//Fields


        public static WinFormsField PlnctlKey0 = new WinFormsField("PLNCTL-KEY0", "PlnctlKey0");
        public static WinFormsField PlanConcept = new WinFormsField("PLAN-CONCEPT", "PlanConcept");
        public static WinFormsField AlternatePlanConcept = new WinFormsField("ALTERNATE-PLAN-CONCEPT", "AlternatePlanConcept");
        public static WinFormsField PlanCategory = new WinFormsField("PLAN-CATEGORY", "PlanCategory");
        public static WinFormsField BriefPlanDescription = new WinFormsField("BRIEF-PLAN-DESCRIPTION", "BriefPlanDescription");
        public static WinFormsField GeneralPlanDesc = new WinFormsField("GENERAL-PLAN-DESC", "GeneralPlanDesc");
        public static WinFormsField IssueClass = new WinFormsField("ISSUE-CLASS", "IssueClass");
        public static WinFormsField ParticipationOption = new WinFormsField("PARTICIPATION-OPTION", "ParticipationOption");
        public static WinFormsField IssueRegister = new WinFormsField("ISSUE-REGISTER", "IssueRegister");
        public static WinFormsField CategoryLevelAdjustment = new WinFormsField("CATEGORY-LEVEL-ADJUSTMENT", "CategoryLevelAdjustment");
        public static WinFormsField IssueMinimum = new WinFormsField("ISSUE-MINIMUM", "IssueMinimum");
        public static WinFormsField UnissuedCertificates = new WinFormsField("UNISSUED-CERTIFICATES", "UnissuedCertificates");
        public static WinFormsField IssueMultiple = new WinFormsField("ISSUE-MULTIPLE", "IssueMultiple");
        public static WinFormsField NOChangeDate = new WinFormsField("NO-CHANGE-DATE", "NOChangeDate");
        public static WinFormsField MoneyClass = new WinFormsField("MONEY-CLASS", "MoneyClass");
        public static WinFormsField CatLevelAdjPlan = new WinFormsField("CAT-LEVEL-ADJ-PLAN", "CatLevelAdjPlan");
        public static WinFormsField UnitRoundOpt = new WinFormsField("UNIT-ROUND-OPT", "UnitRoundOpt");
        public static WinFormsField TfnNoticeReqd = new WinFormsField("TFN-NOTICE-REQD", "TfnNoticeReqd");
        public static WinFormsField CurrencyFlag = new WinFormsField("CURRENCY-FLAG", "CurrencyFlag");
        public static WinFormsField UrrAutoReduceLevel = new WinFormsField("URR-AUTO-REDUCE-LEVEL", "UrrAutoReduceLevel");
        public static WinFormsField UrrAutoWithdraw = new WinFormsField("URR-AUTO-WITHDRAW", "UrrAutoWithdraw");
        public static WinFormsField EssRegisterCode = new WinFormsField("ESS-REGISTER-CODE", "EssRegisterCode");
        public static WinFormsField UrrAutoWithdrawOth = new WinFormsField("URR-AUTO-WITHDRAW-OTH", "UrrAutoWithdrawOth");
        public static WinFormsField DecdWithdrawInd = new WinFormsField("DECD-WITHDRAW-IND", "DecdWithdrawInd");
        public static WinFormsField UrrCondAutoWithdraw = new WinFormsField("URR-COND-AUTO-WITHDRAW", "UrrCondAutoWithdraw");
        public static WinFormsField UrrAutoWithdrawLnkCde = new WinFormsField("URR-AUTO-WITHDRAW-LNK-CDE", "UrrAutoWithdrawLnkCde");
        public static WinFormsField NewElecsNotAllowInd = new WinFormsField("NEW-ELECS-NOT-ALLOW-IND", "NewElecsNotAllowInd");
        public static WinFormsField NewElecsOverrideInd = new WinFormsField("NEW-ELECS-OVERRIDE-IND", "NewElecsOverrideInd");
        public static WinFormsField AllowOvrrideMnyClsInd = new WinFormsField("ALLOW-OVRRIDE-MNY-CLS-IND", "AllowOvrrideMnyClsInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
