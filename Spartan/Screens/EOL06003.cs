using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL06003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL06003", "FormName");
		//Fields


        public static WinFormsField VestingMonths = new WinFormsField("VESTING-MONTHS", "VestingMonths");
        public static WinFormsField VestingDays = new WinFormsField("VESTING-DAYS", "VestingDays");
        public static WinFormsField VestStartDate = new WinFormsField("VEST-START-DATE", "VestStartDate");
        public static WinFormsField VestExpiry = new WinFormsField("VEST-EXPIRY", "VestExpiry");
        public static WinFormsField TrancheNbr = new WinFormsField("TRANCHE-NBR", "TrancheNbr");
        public static WinFormsField MnthsFromVestStart = new WinFormsField("MNTHS-FROM-VEST-START", "MnthsFromVestStart");
        public static WinFormsField DaysFromVestStart = new WinFormsField("DAYS-FROM-VEST-START", "DaysFromVestStart");
        public static WinFormsField VestingPercentage = new WinFormsField("VESTING-PERCENTAGE", "VestingPercentage");
        public static WinFormsField VestingDate = new WinFormsField("VESTING-DATE", "VestingDate");
        public static WinFormsField VestMonStar = new WinFormsField("VEST-MON-STAR", "VestMonStar");
        public static WinFormsField VestExpStar = new WinFormsField("VEST-EXP-STAR", "VestExpStar");
        public static WinFormsField VestDayStar = new WinFormsField("VEST-DAY-STAR", "VestDayStar");
        public static WinFormsField VestStartStar = new WinFormsField("VEST-START-STAR", "VestStartStar");
        public static WinFormsField VestPercStar = new WinFormsField("VEST-PERC-STAR", "VestPercStar");
        public static WinFormsField DaysStar = new WinFormsField("DAYS-STAR", "DaysStar");
        public static WinFormsField MnthsStar = new WinFormsField("MNTHS-STAR", "MnthsStar");
        public static WinFormsField VestDateStar = new WinFormsField("VEST-DATE-STAR", "VestDateStar");
    }
}
