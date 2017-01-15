using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FHK01105

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FHK01105", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField IssueNumber = new WinFormsField("ISSUE-NUMBER", "IssueNumber");
        public static WinFormsField IssueDescription = new WinFormsField("ISSUE-DESCRIPTION", "IssueDescription");
        public static WinFormsField PaymentCalcMethod = new WinFormsField("PAYMENT-CALC-METHOD", "PaymentCalcMethod");
        public static WinFormsField DayCountOption = new WinFormsField("DAY-COUNT-OPTION", "DayCountOption");
        public static WinFormsField DaysNextPay = new WinFormsField("DAYS-NEXT-PAY", "DaysNextPay");
        public static WinFormsField DaysIntYear = new WinFormsField("DAYS-INT-YEAR", "DaysIntYear");
        public static WinFormsField DaysNextPay1 = new WinFormsField("DAYS-NEXT-PAY1", "DaysNextPay1");
        public static WinFormsField DaysIntYear1 = new WinFormsField("DAYS-INT-YEAR1", "DaysIntYear1");
        public static WinFormsField DaysNextPay2 = new WinFormsField("DAYS-NEXT-PAY2", "DaysNextPay2");
        public static WinFormsField DaysIntYear2 = new WinFormsField("DAYS-INT-YEAR2", "DaysIntYear2");
        public static WinFormsField IssueTradeMinimum = new WinFormsField("ISSUE-TRADE-MINIMUM", "IssueTradeMinimum");
        public static WinFormsField IssueTradeMultiple = new WinFormsField("ISSUE-TRADE-MULTIPLE", "IssueTradeMultiple");
        public static WinFormsField ScripIssueOption = new WinFormsField("SCRIP-ISSUE-OPTION", "ScripIssueOption");
        public static WinFormsField IssueScripFormat = new WinFormsField("ISSUE-SCRIP-FORMAT", "IssueScripFormat");
        public static WinFormsField CommentStructure = new WinFormsField("COMMENT-STRUCTURE", "CommentStructure");
        public static WinFormsField CompoundTradeOption = new WinFormsField("COMPOUND-TRADE-OPTION", "CompoundTradeOption");
        public static WinFormsField IssueInvalidReg = new WinFormsField("ISSUE-INVALID-REG", "IssueInvalidReg");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
