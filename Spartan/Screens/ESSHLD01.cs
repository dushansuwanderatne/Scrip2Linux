using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSHLD01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSHLD01", "FormName");
		//Fields


        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField EsshldKey2 = new WinFormsField("ESSHLD-KEY2", "EsshldKey2");
        public static WinFormsField EsshldKey1 = new WinFormsField("ESSHLD-KEY1", "EsshldKey1");
        public static WinFormsField RunCreated = new WinFormsField("RUN-CREATED", "RunCreated");
        public static WinFormsField RunLastChanged = new WinFormsField("RUN-LAST-CHANGED", "RunLastChanged");
        public static WinFormsField SavingsAmount = new WinFormsField("SAVINGS-AMOUNT", "SavingsAmount");
        public static WinFormsField EsstrnTranCount = new WinFormsField("ESSTRN-TRAN-COUNT", "EsstrnTranCount");
        public static WinFormsField TotalSavingsAmount = new WinFormsField("TOTAL-SAVINGS-AMOUNT", "TotalSavingsAmount");
        public static WinFormsField AppropDate = new WinFormsField("APPROP-DATE", "AppropDate");
        public static WinFormsField PaymentFrequency = new WinFormsField("PAYMENT-FREQUENCY", "PaymentFrequency");
        public static WinFormsField MaturityDate = new WinFormsField("MATURITY-DATE", "MaturityDate");
        public static WinFormsField ResidualInd = new WinFormsField("RESIDUAL-IND", "ResidualInd");
        public static WinFormsField TaxAssessedInd = new WinFormsField("TAX-ASSESSED-IND", "TaxAssessedInd");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField StoppedInd = new WinFormsField("STOPPED-IND", "StoppedInd");
        public static WinFormsField Tliv = new WinFormsField("TLIV", "Tliv");
        public static WinFormsField NbrTimesRestarted = new WinFormsField("NBR-TIMES-RESTARTED", "NbrTimesRestarted");
        public static WinFormsField PendingExerciseInd = new WinFormsField("PENDING-EXERCISE-IND", "PendingExerciseInd");
        public static WinFormsField LastAccumPeriod = new WinFormsField("LAST-ACCUM-PERIOD", "LastAccumPeriod");
        public static WinFormsField PoolRegisterInd = new WinFormsField("POOL-REGISTER-IND", "PoolRegisterInd");
        public static WinFormsField LastPaymentNumber = new WinFormsField("LAST-PAYMENT-NUMBER", "LastPaymentNumber");
        public static WinFormsField LeaverForfAppliedInd = new WinFormsField("LEAVER-FORF-APPLIED-IND", "LeaverForfAppliedInd");
        public static WinFormsField LastAwardPeriod = new WinFormsField("LAST-AWARD-PERIOD", "LastAwardPeriod");
        public static WinFormsField InterestAppliedInd = new WinFormsField("INTEREST-APPLIED-IND", "InterestAppliedInd");
        public static WinFormsField TerminatedContract = new WinFormsField("TERMINATED-CONTRACT", "TerminatedContract");
        public static WinFormsField MatchingAvailInd = new WinFormsField("MATCHING-AVAIL-IND", "MatchingAvailInd");
        public static WinFormsField LastPaymentDate = new WinFormsField("LAST-PAYMENT-DATE", "LastPaymentDate");
        public static WinFormsField FutureMatchPeriod = new WinFormsField("FUTURE-MATCH-PERIOD", "FutureMatchPeriod");
        public static WinFormsField FutureMatchPerDays = new WinFormsField("FUTURE-MATCH-PER-DAYS", "FutureMatchPerDays");
        public static WinFormsField NbrPaymentsMade = new WinFormsField("NBR-PAYMENTS-MADE", "NbrPaymentsMade");
        public static WinFormsField OverdueCount = new WinFormsField("OVERDUE-COUNT", "OverdueCount");
        public static WinFormsField MatchWorkingClass = new WinFormsField("MATCH-WORKING-CLASS", "MatchWorkingClass");
        public static WinFormsField Bonus1AppliedInd = new WinFormsField("BONUS1-APPLIED-IND", "Bonus1AppliedInd");
        public static WinFormsField Bonus2AppliedInd = new WinFormsField("BONUS2-APPLIED-IND", "Bonus2AppliedInd");
        public static WinFormsField RetentionPeriodMonths = new WinFormsField("RETENTION-PERIOD-MONTHS", "RetentionPeriodMonths");
        public static WinFormsField RetentionPeriodDays = new WinFormsField("RETENTION-PERIOD-DAYS", "RetentionPeriodDays");
        public static WinFormsField RolledOverResidueInd = new WinFormsField("ROLLED-OVER-RESIDUE-IND", "RolledOverResidueInd");
        public static WinFormsField RolledOverAccumPeriod = new WinFormsField("ROLLED-OVER-ACCUM-PERIOD", "RolledOverAccumPeriod");
        public static WinFormsField TaxRetentionPerMths = new WinFormsField("TAX-RETENTION-PER-MTHS", "TaxRetentionPerMths");
        public static WinFormsField TaxRetentionPerDays = new WinFormsField("TAX-RETENTION-PER-DAYS", "TaxRetentionPerDays");
        public static WinFormsField GrantCountry = new WinFormsField("GRANT-COUNTRY", "GrantCountry");
        public static WinFormsField DivFirstAwardDate = new WinFormsField("DIV-FIRST-AWARD-DATE", "DivFirstAwardDate");
        public static WinFormsField PayrollIdentifier = new WinFormsField("PAYROLL-IDENTIFIER", "PayrollIdentifier");
        public static WinFormsField TaxDeferBaseDate = new WinFormsField("TAX-DEFER-BASE-DATE", "TaxDeferBaseDate");
        public static WinFormsField LocationCode = new WinFormsField("LOCATION-CODE", "LocationCode");
        public static WinFormsField VestingCode = new WinFormsField("VESTING-CODE", "VestingCode");
        public static WinFormsField Meh0UnvestedBalance = new WinFormsField("MEH0-UNVESTED-BALANCE", "Meh0UnvestedBalance");
        public static WinFormsField IgnoreBlackoutInd = new WinFormsField("IGNORE-BLACKOUT-IND", "IgnoreBlackoutInd");
        public static WinFormsField Meh0UnvestedNOChgUnits = new WinFormsField("MEH0-UNVESTED-NO-CHG-UNITS", "Meh0UnvestedNOChgUnits");
        public static WinFormsField LeaverProcessedInd = new WinFormsField("LEAVER-PROCESSED-IND", "LeaverProcessedInd");
        public static WinFormsField Meh0VestedBalance = new WinFormsField("MEH0-VESTED-BALANCE", "Meh0VestedBalance");
        public static WinFormsField Meh0ScheduleTypeInd = new WinFormsField("MEH0-SCHEDULE-TYPE-IND", "Meh0ScheduleTypeInd");
        public static WinFormsField Meh0VestedNOChgUnits = new WinFormsField("MEH0-VESTED-NO-CHG-UNITS", "Meh0VestedNOChgUnits");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
