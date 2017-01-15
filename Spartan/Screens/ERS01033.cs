using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01033

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01033", "FormName");
		//Fields
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterType = new WinFormsField("REGISTER-TYPE", "RegisterType");
        public static WinFormsField RegisterDesc = new WinFormsField("REGISTER-DESC", "RegisterDesc");
        public static WinFormsField Comments = new WinFormsField("COMMENTS", "Comments");
        public static WinFormsField HoldingEndDate = new WinFormsField("HOLDING-END-DATE", "HoldingEndDate");
        public static WinFormsField TaxEndDate = new WinFormsField("TAX-END-DATE", "TaxEndDate");
        public static WinFormsField FirstAwardDate = new WinFormsField("FIRST-AWARD-DATE", "FirstAwardDate");
        public static WinFormsField IndividualDatesInd = new WinFormsField("INDIVIDUAL-DATES-IND", "IndividualDatesInd");
        public static WinFormsField FloatingInd = new WinFormsField("FLOATING-IND", "FloatingInd");
        public static WinFormsField ExpiresAfter = new WinFormsField("EXPIRES-AFTER", "ExpiresAfter");
        public static WinFormsField UnitRoundingInd = new WinFormsField("UNIT-ROUNDING-IND", "UnitRoundingInd");
        public static WinFormsField ReleaseTypes = new WinFormsField("RELEASE-TYPES", "ReleaseTypes");
        public static WinFormsField AutoRemoveDays = new WinFormsField("AUTO-REMOVE-DAYS", "AutoRemoveDays");
        public static WinFormsField AessLimitType = new WinFormsField("AESS-LIMIT-TYPE", "AessLimitType");
        public static WinFormsField LimitMinimum = new WinFormsField("LIMIT-MINIMUM", "LimitMinimum");
        public static WinFormsField LimitMaximum = new WinFormsField("LIMIT-MAXIMUM", "LimitMaximum");
        public static WinFormsField PaymentsCarrierInd = new WinFormsField("PAYMENTS-CARRIER-IND", "PaymentsCarrierInd");
        public static WinFormsField MoneyRoundingInd = new WinFormsField("MONEY-ROUNDING-IND", "MoneyRoundingInd");
        public static WinFormsField ResidualsInd = new WinFormsField("RESIDUALS-IND", "ResidualsInd");
        public static WinFormsField MaximumNbrRestarts = new WinFormsField("MAXIMUM-NBR-RESTARTS", "MaximumNbrRestarts");
        public static WinFormsField PaymentAcct = new WinFormsField("PAYMENT-ACCT", "PaymentAcct");
        public static WinFormsField BaseCurrency = new WinFormsField("BASE-CURRENCY", "BaseCurrency");
        public static WinFormsField AwardPayFreqDtls = new WinFormsField("AWARD-PAY-FREQ-DTLS", "AwardPayFreqDtls");
        public static WinFormsField CalcTaxInd = new WinFormsField("CALC-TAX-IND", "CalcTaxInd");
        public static WinFormsField ForfeitureType = new WinFormsField("FORFEITURE-TYPE", "ForfeitureType");
        public static WinFormsField ProRataMethod = new WinFormsField("PRO-RATA-METHOD", "ProRataMethod");
        public static WinFormsField ForfeitureEndDate = new WinFormsField("FORFEITURE-END-DATE", "ForfeitureEndDate");
        public static WinFormsField NonForfeitureStatus = new WinFormsField("NON-FORFEITURE-STATUS", "NonForfeitureStatus");
        public static WinFormsField UsingMtchgInd = new WinFormsField("USING-MTCHG-IND", "UsingMtchgInd");
        public static WinFormsField UsingUnmatchedInd = new WinFormsField("USING-UNMATCHED-IND", "UsingUnmatchedInd");
        public static WinFormsField MtchgUpfrontInd = new WinFormsField("MTCHG-UPFRONT-IND", "MtchgUpfrontInd");
        public static WinFormsField FutrMtchgEndDate = new WinFormsField("FUTR-MTCHG-END-DATE", "FutrMtchgEndDate");
        public static WinFormsField MtchgRatio = new WinFormsField("MTCHG-RATIO", "MtchgRatio");
        public static WinFormsField AwdMtchgLimitPerd = new WinFormsField("AWD-MTCHG-LIMIT-PERD", "AwdMtchgLimitPerd");
        public static WinFormsField AwdMtchgLimit = new WinFormsField("AWD-MTCHG-LIMIT", "AwdMtchgLimit");
        public static WinFormsField LoanBonusPerdDtls = new WinFormsField("LOAN-BONUS-PERD-DTLS", "LoanBonusPerdDtls");
        public static WinFormsField RecoursePlanInd = new WinFormsField("RECOURSE-PLAN-IND", "RecoursePlanInd");
        public static WinFormsField FutureFloat = new WinFormsField("FUTURE-FLOAT", "FutureFloat");
        public static WinFormsField ForfeitureFloat = new WinFormsField("FORFEITURE-FLOAT", "ForfeitureFloat");
        public static WinFormsField LeaverSchedule = new WinFormsField("LEAVER-SCHEDULE", "LeaverSchedule");
        public static WinFormsField UsingVestingInd = new WinFormsField("USING-VESTING-IND", "UsingVestingInd");
        public static WinFormsField TaxStmtTypeInd = new WinFormsField("TAX-STMT-TYPE-IND", "TaxStmtTypeInd");
        public static WinFormsField TaxReportableInd = new WinFormsField("TAX-REPORTABLE-IND", "TaxReportableInd");
        public static WinFormsField FinRptExp = new WinFormsField("FIN-RPT-EXP", "FinRptExp");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
