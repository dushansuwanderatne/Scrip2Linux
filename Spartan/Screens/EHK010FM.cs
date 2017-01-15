using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK010FM

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK010FM", "FormName");
		//Fields


        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterType = new WinFormsField("REGISTER-TYPE", "RegisterType");
        public static WinFormsField RegisterDescription = new WinFormsField("REGISTER-DESCRIPTION", "RegisterDescription");
        public static WinFormsField TaxReportableInd = new WinFormsField("TAX-REPORTABLE-IND", "TaxReportableInd");
        public static WinFormsField TaxStmtTypeInd = new WinFormsField("TAX-STMT-TYPE-IND", "TaxStmtTypeInd");
        public static WinFormsField UsingIndDatesInd = new WinFormsField("USING-IND-DATES-IND", "UsingIndDatesInd");
        public static WinFormsField LeaverSchedule = new WinFormsField("LEAVER-SCHEDULE", "LeaverSchedule");
        public static WinFormsField ForfeitureType = new WinFormsField("FORFEITURE-TYPE", "ForfeitureType");
        public static WinFormsField RetentionPeriod = new WinFormsField("RETENTION-PERIOD", "RetentionPeriod");
        public static WinFormsField RetentionPeriodDays = new WinFormsField("RETENTION-PERIOD-DAYS", "RetentionPeriodDays");
        public static WinFormsField RetentionFloatingInd = new WinFormsField("RETENTION-FLOATING-IND", "RetentionFloatingInd");
        public static WinFormsField ForfProRataMethod = new WinFormsField("FORF-PRO-RATA-METHOD", "ForfProRataMethod");
        public static WinFormsField TaxRetentionPeriod = new WinFormsField("TAX-RETENTION-PERIOD", "TaxRetentionPeriod");
        public static WinFormsField TaxRetentionPerDays = new WinFormsField("TAX-RETENTION-PER-DAYS", "TaxRetentionPerDays");
        public static WinFormsField TaxRetFloatingInd = new WinFormsField("TAX-RET-FLOATING-IND", "TaxRetFloatingInd");
        public static WinFormsField FirstAwardDate = new WinFormsField("FIRST-AWARD-DATE", "FirstAwardDate");
        public static WinFormsField UnitRounding = new WinFormsField("UNIT-ROUNDING", "UnitRounding");
        public static WinFormsField MoneyRounding = new WinFormsField("MONEY-ROUNDING", "MoneyRounding");
        public static WinFormsField ForfPeriodFrom = new WinFormsField("FORF-PERIOD-FROM", "ForfPeriodFrom");
        public static WinFormsField ForfPerFromDays = new WinFormsField("FORF-PER-FROM-DAYS", "ForfPerFromDays");
        public static WinFormsField ForfPeriodTO = new WinFormsField("FORF-PERIOD-TO", "ForfPeriodTO");
        public static WinFormsField ForfPerTODays = new WinFormsField("FORF-PER-TO-DAYS", "ForfPerTODays");
        public static WinFormsField ForfPercentage = new WinFormsField("FORF-PERCENTAGE", "ForfPercentage");
        public static WinFormsField AutoRemovalDays = new WinFormsField("AUTO-REMOVAL-DAYS", "AutoRemovalDays");
        public static WinFormsField ReleaseOption = new WinFormsField("RELEASE-OPTION", "ReleaseOption");
        public static WinFormsField ForfFloatingInd = new WinFormsField("FORF-FLOATING-IND", "ForfFloatingInd");
        public static WinFormsField CalculateTaxInd = new WinFormsField("CALCULATE-TAX-IND", "CalculateTaxInd");
        public static WinFormsField FinRptExp = new WinFormsField("FIN-RPT-EXP", "FinRptExp");
        public static WinFormsField BaseCurrency = new WinFormsField("BASE-CURRENCY", "BaseCurrency");
        public static WinFormsField MinMaxType = new WinFormsField("MIN-MAX-TYPE", "MinMaxType");
        public static WinFormsField MatchingRatio1 = new WinFormsField("MATCHING-RATIO-1", "MatchingRatio1");
        public static WinFormsField MatchingRatio2 = new WinFormsField("MATCHING-RATIO-2", "MatchingRatio2");
        public static WinFormsField MinMoneyAmt = new WinFormsField("MIN-MONEY-AMT", "MinMoneyAmt");
        public static WinFormsField MaxMoneyAmt = new WinFormsField("MAX-MONEY-AMT", "MaxMoneyAmt");
        public static WinFormsField FutureMatchPeriod = new WinFormsField("FUTURE-MATCH-PERIOD", "FutureMatchPeriod");
        public static WinFormsField FutureMatchPerDays = new WinFormsField("FUTURE-MATCH-PER-DAYS", "FutureMatchPerDays");
        public static WinFormsField FutureFloatingInd = new WinFormsField("FUTURE-FLOATING-IND", "FutureFloatingInd");
        public static WinFormsField MatchingLimitMoney = new WinFormsField("MATCHING-LIMIT-MONEY", "MatchingLimitMoney");
        public static WinFormsField MatchingLimitUnits = new WinFormsField("MATCHING-LIMIT-UNITS", "MatchingLimitUnits");
        public static WinFormsField FreeFormatLine = new WinFormsField("FREE-FORMAT-LINE", "FreeFormatLine");
        public static WinFormsField MatchLimitPerFrom = new WinFormsField("MATCH-LIMIT-PER-FROM", "MatchLimitPerFrom");
        public static WinFormsField MatchLimitPerTO = new WinFormsField("MATCH-LIMIT-PER-TO", "MatchLimitPerTO");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField LocateArgumentReg = new WinFormsField("LOCATE-ARGUMENT-REG", "LocateArgumentReg");
        public static WinFormsField LocateArgumentType = new WinFormsField("LOCATE-ARGUMENT-TYPE", "LocateArgumentType");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
