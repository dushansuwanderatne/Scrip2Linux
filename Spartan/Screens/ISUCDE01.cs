using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISUCDE01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISUCDE01", "FormName");
		//Fields


        public static WinFormsField IssueNumber = new WinFormsField("ISSUE-NUMBER", "IssueNumber");
        public static WinFormsField IssueDescription = new WinFormsField("ISSUE-DESCRIPTION", "IssueDescription");
        public static WinFormsField LoanType = new WinFormsField("LOAN-TYPE", "LoanType");
        public static WinFormsField IssueParValue = new WinFormsField("ISSUE-PAR-VALUE", "IssueParValue");
        public static WinFormsField LoanNumber = new WinFormsField("LOAN-NUMBER", "LoanNumber");
        public static WinFormsField PaymentCalcMethod = new WinFormsField("PAYMENT-CALC-METHOD", "PaymentCalcMethod");
        public static WinFormsField IssueAuthorisedMoney = new WinFormsField("ISSUE-AUTHORISED-MONEY", "IssueAuthorisedMoney");
        public static WinFormsField MaturityDate = new WinFormsField("MATURITY-DATE", "MaturityDate");
        public static WinFormsField IssueScripFormat = new WinFormsField("ISSUE-SCRIP-FORMAT", "IssueScripFormat");
        public static WinFormsField IssueIssuedMoney = new WinFormsField("ISSUE-ISSUED-MONEY", "IssueIssuedMoney");
        public static WinFormsField InterestRate = new WinFormsField("INTEREST-RATE", "InterestRate");
        public static WinFormsField CurrentFlag = new WinFormsField("CURRENT-FLAG", "CurrentFlag");
        public static WinFormsField IssueTradeMinimum = new WinFormsField("ISSUE-TRADE-MINIMUM", "IssueTradeMinimum");
        public static WinFormsField PaymentMethod = new WinFormsField("PAYMENT-METHOD", "PaymentMethod");
        public static WinFormsField PaymentFrequency = new WinFormsField("PAYMENT-FREQUENCY", "PaymentFrequency");
        public static WinFormsField IssueTradeMultiple = new WinFormsField("ISSUE-TRADE-MULTIPLE", "IssueTradeMultiple");
        public static WinFormsField OpenDate = new WinFormsField("OPEN-DATE", "OpenDate");
        public static WinFormsField ExtensionsInd = new WinFormsField("EXTENSIONS-IND", "ExtensionsInd");
        public static WinFormsField IssueInvalidReg1to6 = new WinFormsField("ISSUE-INVALID-REG-1TO6", "IssueInvalidReg1to6");
        public static WinFormsField CloseDate = new WinFormsField("CLOSE-DATE", "CloseDate");
        public static WinFormsField LastCertStartRun = new WinFormsField("LAST-CERT-START-RUN", "LastCertStartRun");
        public static WinFormsField IssueInvalidReg7to12 = new WinFormsField("ISSUE-INVALID-REG-7TO12", "IssueInvalidReg7to12");
        public static WinFormsField FirstPaymentDate = new WinFormsField("FIRST-PAYMENT-DATE", "FirstPaymentDate");
        public static WinFormsField LastCertNumberUsed = new WinFormsField("LAST-CERT-NUMBER-USED", "LastCertNumberUsed");
        public static WinFormsField CompoundTradingOption = new WinFormsField("COMPOUND-TRADING-OPTION", "CompoundTradingOption");
        public static WinFormsField PayATEndOFMonth = new WinFormsField("PAY-AT-END-OF-MONTH", "PayATEndOFMonth");
        public static WinFormsField ONCallRate = new WinFormsField("ON-CALL-RATE", "ONCallRate");
        public static WinFormsField ScripIssueOption = new WinFormsField("SCRIP-ISSUE-OPTION", "ScripIssueOption");
        public static WinFormsField PartialInstalmentsInd = new WinFormsField("PARTIAL-INSTALMENTS-IND", "PartialInstalmentsInd");
        public static WinFormsField ONCallInd = new WinFormsField("ON-CALL-IND", "ONCallInd");
        public static WinFormsField PreviousBcloseRunNbr = new WinFormsField("PREVIOUS-BCLOSE-RUN-NBR", "PreviousBcloseRunNbr");
        public static WinFormsField CalculateAccruedInd = new WinFormsField("CALCULATE-ACCRUED-IND", "CalculateAccruedInd");
        public static WinFormsField DBFirstPaymentDate = new WinFormsField("DB-FIRST-PAYMENT-DATE", "DBFirstPaymentDate");
        public static WinFormsField LastPaymentDate = new WinFormsField("LAST-PAYMENT-DATE", "LastPaymentDate");
        public static WinFormsField AccruedTradingOption = new WinFormsField("ACCRUED-TRADING-OPTION", "AccruedTradingOption");
        public static WinFormsField IncludeMaturityDayFD = new WinFormsField("INCLUDE-MATURITY-DAY-FD", "IncludeMaturityDayFD");
        public static WinFormsField IncludeMaturityDayLD = new WinFormsField("INCLUDE-MATURITY-DAY-LD", "IncludeMaturityDayLD");
        public static WinFormsField NextPaymentDate = new WinFormsField("NEXT-PAYMENT-DATE", "NextPaymentDate");
        public static WinFormsField AccruedCalcOption = new WinFormsField("ACCRUED-CALC-OPTION", "AccruedCalcOption");
        public static WinFormsField IncludePrevPayDayFD = new WinFormsField("INCLUDE-PREV-PAY-DAY-FD", "IncludePrevPayDayFD");
        public static WinFormsField IncludePrevPayDayFP = new WinFormsField("INCLUDE-PREV-PAY-DAY-FP", "IncludePrevPayDayFP");
        public static WinFormsField DaysIntYear = new WinFormsField("DAYS-INT-YEAR", "DaysIntYear");
        public static WinFormsField AccruedRoundOption = new WinFormsField("ACCRUED-ROUND-OPTION", "AccruedRoundOption");
        public static WinFormsField IncludeIcfDay = new WinFormsField("INCLUDE-ICF-DAY", "IncludeIcfDay");
        public static WinFormsField IncludeThisPayDay = new WinFormsField("INCLUDE-THIS-PAY-DAY", "IncludeThisPayDay");
        public static WinFormsField FrnDays = new WinFormsField("FRN-DAYS", "FrnDays");
        public static WinFormsField IssueScripComment = new WinFormsField("ISSUE-SCRIP-COMMENT", "IssueScripComment");
        public static WinFormsField CommentLineStructure = new WinFormsField("COMMENT-LINE-STRUCTURE", "CommentLineStructure");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
