using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSAPR01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSAPR01", "FormName");
		//Fields


        public static WinFormsField EssaprKey0 = new WinFormsField("ESSAPR-KEY0", "EssaprKey0");
        public static WinFormsField RegisterDescription = new WinFormsField("REGISTER-DESCRIPTION", "RegisterDescription");
        public static WinFormsField StatusFlag = new WinFormsField("STATUS-FLAG", "StatusFlag");
        public static WinFormsField MinMaxType = new WinFormsField("MIN-MAX-TYPE", "MinMaxType");
        public static WinFormsField InternetSiteInd = new WinFormsField("INTERNET-SITE-IND", "InternetSiteInd");
        public static WinFormsField TermINMonths = new WinFormsField("TERM-IN-MONTHS", "TermINMonths");
        public static WinFormsField TermINDays = new WinFormsField("TERM-IN-DAYS", "TermINDays");
        public static WinFormsField MinMoneyAmt = new WinFormsField("MIN-MONEY-AMT", "MinMoneyAmt");
        public static WinFormsField RegisterHurdleInd = new WinFormsField("REGISTER-HURDLE-IND", "RegisterHurdleInd");
        public static WinFormsField RetentionPeriod = new WinFormsField("RETENTION-PERIOD", "RetentionPeriod");
        public static WinFormsField RetentionPeriodDays = new WinFormsField("RETENTION-PERIOD-DAYS", "RetentionPeriodDays");
        public static WinFormsField MaxMoneyAmt = new WinFormsField("MAX-MONEY-AMT", "MaxMoneyAmt");
        public static WinFormsField RecourseInd = new WinFormsField("RECOURSE-IND", "RecourseInd");
        public static WinFormsField TaxRetentionPeriod = new WinFormsField("TAX-RETENTION-PERIOD", "TaxRetentionPeriod");
        public static WinFormsField TaxRetentionPerDays = new WinFormsField("TAX-RETENTION-PER-DAYS", "TaxRetentionPerDays");
        public static WinFormsField ReleaseOption = new WinFormsField("RELEASE-OPTION", "ReleaseOption");
        public static WinFormsField RetentionFloatingInd = new WinFormsField("RETENTION-FLOATING-IND", "RetentionFloatingInd");
        public static WinFormsField TaxRetFloatingInd = new WinFormsField("TAX-RET-FLOATING-IND", "TaxRetFloatingInd");
        public static WinFormsField FirstAwardDate = new WinFormsField("FIRST-AWARD-DATE", "FirstAwardDate");
        public static WinFormsField Mea0UsingIndDatesInd = new WinFormsField("MEA0-USING-IND-DATES-IND", "Mea0UsingIndDatesInd");
        public static WinFormsField ForfeitureType = new WinFormsField("FORFEITURE-TYPE", "ForfeitureType");
        public static WinFormsField ExercisePeriod = new WinFormsField("EXERCISE-PERIOD", "ExercisePeriod");
        public static WinFormsField Mea0ForfFloatingInd = new WinFormsField("MEA0-FORF-FLOATING-IND", "Mea0ForfFloatingInd");
        public static WinFormsField AllowMultCertsInd = new WinFormsField("ALLOW-MULT-CERTS-IND", "AllowMultCertsInd");
        public static WinFormsField MarketValueATStart = new WinFormsField("MARKET-VALUE-AT-START", "MarketValueATStart");
        public static WinFormsField UnitRounding = new WinFormsField("UNIT-ROUNDING", "UnitRounding");
        public static WinFormsField MoneyRounding = new WinFormsField("MONEY-ROUNDING", "MoneyRounding");
        public static WinFormsField ResidualInd = new WinFormsField("RESIDUAL-IND", "ResidualInd");
        public static WinFormsField ForfPeriodFrom = new WinFormsField("FORF-PERIOD-FROM", "ForfPeriodFrom");
        public static WinFormsField ForfPerFromDays = new WinFormsField("FORF-PER-FROM-DAYS", "ForfPerFromDays");
        public static WinFormsField ForfPeriodTO = new WinFormsField("FORF-PERIOD-TO", "ForfPeriodTO");
        public static WinFormsField ForfPerTODays = new WinFormsField("FORF-PER-TO-DAYS", "ForfPerTODays");
        public static WinFormsField ForfPercentage = new WinFormsField("FORF-PERCENTAGE", "ForfPercentage");
        public static WinFormsField UsingFreeInd = new WinFormsField("USING-FREE-IND", "UsingFreeInd");
        public static WinFormsField FinRptExp = new WinFormsField("FIN-RPT-EXP", "FinRptExp");
        public static WinFormsField AutoRemovalDays = new WinFormsField("AUTO-REMOVAL-DAYS", "AutoRemovalDays");
        public static WinFormsField SavingsCarrierInd = new WinFormsField("SAVINGS-CARRIER-IND", "SavingsCarrierInd");
        public static WinFormsField BaseCurrency = new WinFormsField("BASE-CURRENCY", "BaseCurrency");
        public static WinFormsField MaxNumberRestarts = new WinFormsField("MAX-NUMBER-RESTARTS", "MaxNumberRestarts");
        public static WinFormsField PaymentAccount = new WinFormsField("PAYMENT-ACCOUNT", "PaymentAccount");
        public static WinFormsField Mea0StatusType = new WinFormsField("MEA0-STATUS-TYPE", "Mea0StatusType");
        public static WinFormsField MaxNumberPayments = new WinFormsField("MAX-NUMBER-PAYMENTS", "MaxNumberPayments");
        public static WinFormsField FutureFloatingInd = new WinFormsField("FUTURE-FLOATING-IND", "FutureFloatingInd");
        public static WinFormsField FutureMatchPerDays = new WinFormsField("FUTURE-MATCH-PER-DAYS", "FutureMatchPerDays");
        public static WinFormsField MaxOverduePayments = new WinFormsField("MAX-OVERDUE-PAYMENTS", "MaxOverduePayments");
        public static WinFormsField PaymentFrequency = new WinFormsField("PAYMENT-FREQUENCY", "PaymentFrequency");
        public static WinFormsField BonusPeriod1 = new WinFormsField("BONUS-PERIOD1", "BonusPeriod1");
        public static WinFormsField BonusRate1 = new WinFormsField("BONUS-RATE1", "BonusRate1");
        public static WinFormsField NbrAccumPeriods = new WinFormsField("NBR-ACCUM-PERIODS", "NbrAccumPeriods");
        public static WinFormsField BonusPeriod2 = new WinFormsField("BONUS-PERIOD2", "BonusPeriod2");
        public static WinFormsField BonusRate2 = new WinFormsField("BONUS-RATE2", "BonusRate2");
        public static WinFormsField UsingMatchingInd = new WinFormsField("USING-MATCHING-IND", "UsingMatchingInd");
        public static WinFormsField FutureMatchPeriod = new WinFormsField("FUTURE-MATCH-PERIOD", "FutureMatchPeriod");
        public static WinFormsField IntQualifyPeriod = new WinFormsField("INT-QUALIFY-PERIOD", "IntQualifyPeriod");
        public static WinFormsField InterestRate = new WinFormsField("INTEREST-RATE", "InterestRate");
        public static WinFormsField UsingUnmatchedInd = new WinFormsField("USING-UNMATCHED-IND", "UsingUnmatchedInd");
        public static WinFormsField Mea0MatchingLimitMoney = new WinFormsField("MEA0-MATCHING-LIMIT-MONEY", "Mea0MatchingLimitMoney");
        public static WinFormsField ForfProRataMethod = new WinFormsField("FORF-PRO-RATA-METHOD", "ForfProRataMethod");
        public static WinFormsField MatchingUpfrontInd = new WinFormsField("MATCHING-UPFRONT-IND", "MatchingUpfrontInd");
        public static WinFormsField Mea0MatchingLimitUnits = new WinFormsField("MEA0-MATCHING-LIMIT-UNITS", "Mea0MatchingLimitUnits");
        public static WinFormsField CalculateTaxInd = new WinFormsField("CALCULATE-TAX-IND", "CalculateTaxInd");
        public static WinFormsField Mea0MatchingLimitPerFrom = new WinFormsField("MEA0-MATCHING-LIMIT-PER-FROM", "Mea0MatchingLimitPerFrom");
        public static WinFormsField Mea0MatchingLimitPerTO = new WinFormsField("MEA0-MATCHING-LIMIT-PER-TO", "Mea0MatchingLimitPerTO");
        public static WinFormsField LeaverSchedule = new WinFormsField("LEAVER-SCHEDULE", "LeaverSchedule");
        public static WinFormsField MatchingRatio1 = new WinFormsField("MATCHING-RATIO-1", "MatchingRatio1");
        public static WinFormsField MatchingRatio2 = new WinFormsField("MATCHING-RATIO-2", "MatchingRatio2");
        public static WinFormsField ExpiresAfterMonths = new WinFormsField("EXPIRES-AFTER-MONTHS", "ExpiresAfterMonths");
        public static WinFormsField ExpiresAfterDays = new WinFormsField("EXPIRES-AFTER-DAYS", "ExpiresAfterDays");
        public static WinFormsField Mea0FreeFormatLine = new WinFormsField("MEA0-FREE-FORMAT-LINE", "Mea0FreeFormatLine");
        public static WinFormsField UsingVestingInd = new WinFormsField("USING-VESTING-IND", "UsingVestingInd");
        public static WinFormsField GrantAcceptanceInd = new WinFormsField("GRANT-ACCEPTANCE-IND", "GrantAcceptanceInd");
        public static WinFormsField TaxReportableInd = new WinFormsField("TAX-REPORTABLE-IND", "TaxReportableInd");
        public static WinFormsField TaxStmtTypeInd = new WinFormsField("TAX-STMT-TYPE-IND", "TaxStmtTypeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
