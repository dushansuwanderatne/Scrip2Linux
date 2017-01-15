using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSVST01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSVST01", "FormName");
		//Fields


        public static WinFormsField VestingCode = new WinFormsField("VESTING-CODE", "VestingCode");
        public static WinFormsField TrancheNumber = new WinFormsField("TRANCHE-NUMBER", "TrancheNumber");
        public static WinFormsField PerformanceCode = new WinFormsField("PERFORMANCE-CODE", "PerformanceCode");
        public static WinFormsField TestNumber = new WinFormsField("TEST-NUMBER", "TestNumber");
        public static WinFormsField VestingDescription = new WinFormsField("VESTING-DESCRIPTION", "VestingDescription");
        public static WinFormsField VestingTermINMonths = new WinFormsField("VESTING-TERM-IN-MONTHS", "VestingTermINMonths");
        public static WinFormsField VestingTermINDays = new WinFormsField("VESTING-TERM-IN-DAYS", "VestingTermINDays");
        public static WinFormsField UnitRounding = new WinFormsField("UNIT-ROUNDING", "UnitRounding");
        public static WinFormsField MonthsFromVestStart = new WinFormsField("MONTHS-FROM-VEST-START", "MonthsFromVestStart");
        public static WinFormsField DaysFromVestStart = new WinFormsField("DAYS-FROM-VEST-START", "DaysFromVestStart");
        public static WinFormsField VestingPercentage = new WinFormsField("VESTING-PERCENTAGE", "VestingPercentage");
        public static WinFormsField VestingDate = new WinFormsField("VESTING-DATE", "VestingDate");
        public static WinFormsField PerformanceDescription = new WinFormsField("PERFORMANCE-DESCRIPTION", "PerformanceDescription");
        public static WinFormsField TestDate = new WinFormsField("TEST-DATE", "TestDate");
        public static WinFormsField TestPercentage = new WinFormsField("TEST-PERCENTAGE", "TestPercentage");
        public static WinFormsField CancelUnvestedInd = new WinFormsField("CANCEL-UNVESTED-IND", "CancelUnvestedInd");
        public static WinFormsField CommentLine = new WinFormsField("COMMENT-LINE", "CommentLine");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
