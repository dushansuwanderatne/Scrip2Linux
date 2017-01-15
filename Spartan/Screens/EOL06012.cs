using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL06012

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL06012", "FormName");
		//Fields


        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField CertID = new WinFormsField("CERT-ID", "CertID");
        public static WinFormsField VestingCode = new WinFormsField("VESTING-CODE", "VestingCode");
        public static WinFormsField VestStar = new WinFormsField("VEST-STAR", "VestStar");
        public static WinFormsField VestingMonth1 = new WinFormsField("VESTING-MONTH-1", "VestingMonth1");
        public static WinFormsField VestMonStar = new WinFormsField("VEST-MON-STAR", "VestMonStar");
        public static WinFormsField VestingDay1 = new WinFormsField("VESTING-DAY-1", "VestingDay1");
        public static WinFormsField VestDayStar = new WinFormsField("VEST-DAY-STAR", "VestDayStar");
        public static WinFormsField VestStartDate1 = new WinFormsField("VEST-START-DATE-1", "VestStartDate1");
        public static WinFormsField VestStartStar = new WinFormsField("VEST-START-STAR", "VestStartStar");
        public static WinFormsField VestExpiry1 = new WinFormsField("VEST-EXPIRY-1", "VestExpiry1");
        public static WinFormsField VestExpStar = new WinFormsField("VEST-EXP-STAR", "VestExpStar");
        public static WinFormsField TrancheNbr = new WinFormsField("TRANCHE-NBR", "TrancheNbr");
        public static WinFormsField MthsFrmVstST1 = new WinFormsField("MTHS-FRM-VST-ST-1", "MthsFrmVstST1");
        public static WinFormsField MnthsStar = new WinFormsField("MNTHS-STAR", "MnthsStar");
        public static WinFormsField DaysFrmVstST1 = new WinFormsField("DAYS-FRM-VST-ST-1", "DaysFrmVstST1");
        public static WinFormsField DaysStar = new WinFormsField("DAYS-STAR", "DaysStar");
        public static WinFormsField VestingPercent1 = new WinFormsField("VESTING-PERCENT-1", "VestingPercent1");
        public static WinFormsField VestPercStar = new WinFormsField("VEST-PERC-STAR", "VestPercStar");
        public static WinFormsField VestingDate1 = new WinFormsField("VESTING-DATE-1", "VestingDate1");
        public static WinFormsField VestDateStar = new WinFormsField("VEST-DATE-STAR", "VestDateStar");
        public static WinFormsField PerfCode = new WinFormsField("PERF-CODE", "PerfCode");
        public static WinFormsField PerfCodeStar = new WinFormsField("PERF-CODE-STAR", "PerfCodeStar");
        public static WinFormsField TestNumber = new WinFormsField("TEST-NUMBER", "TestNumber");
        public static WinFormsField TestDate1 = new WinFormsField("TEST-DATE-1", "TestDate1");
        public static WinFormsField TestDateStar = new WinFormsField("TEST-DATE-STAR", "TestDateStar");
        public static WinFormsField TestPercent1 = new WinFormsField("TEST-PERCENT-1", "TestPercent1");
        public static WinFormsField TestPercStar = new WinFormsField("TEST-PERC-STAR", "TestPercStar");
        public static WinFormsField CancelUnv1 = new WinFormsField("CANCEL-UNV-1", "CancelUnv1");
        public static WinFormsField CancelUnvStar = new WinFormsField("CANCEL-UNV-STAR", "CancelUnvStar");
        public static WinFormsField VestingMonth2 = new WinFormsField("VESTING-MONTH-2", "VestingMonth2");
        public static WinFormsField VestingDay2 = new WinFormsField("VESTING-DAY-2", "VestingDay2");
        public static WinFormsField VestStartDate2 = new WinFormsField("VEST-START-DATE-2", "VestStartDate2");
        public static WinFormsField VestExpiry2 = new WinFormsField("VEST-EXPIRY-2", "VestExpiry2");
        public static WinFormsField MthsFrmVstST2 = new WinFormsField("MTHS-FRM-VST-ST-2", "MthsFrmVstST2");
        public static WinFormsField DaysFrmVstST2 = new WinFormsField("DAYS-FRM-VST-ST-2", "DaysFrmVstST2");
        public static WinFormsField VestingPercent2 = new WinFormsField("VESTING-PERCENT-2", "VestingPercent2");
        public static WinFormsField VestingDate2 = new WinFormsField("VESTING-DATE-2", "VestingDate2");
        public static WinFormsField TestDate2 = new WinFormsField("TEST-DATE-2", "TestDate2");
        public static WinFormsField TestPercent2 = new WinFormsField("TEST-PERCENT-2", "TestPercent2");
        public static WinFormsField CancelUnv2 = new WinFormsField("CANCEL-UNV-2", "CancelUnv2");
        public static WinFormsField VestingMonth3 = new WinFormsField("VESTING-MONTH-3", "VestingMonth3");
        public static WinFormsField VestingDay3 = new WinFormsField("VESTING-DAY-3", "VestingDay3");
        public static WinFormsField VestStartDate3 = new WinFormsField("VEST-START-DATE-3", "VestStartDate3");
        public static WinFormsField VestExpiry3 = new WinFormsField("VEST-EXPIRY-3", "VestExpiry3");
        public static WinFormsField MthsFrmVstST3 = new WinFormsField("MTHS-FRM-VST-ST-3", "MthsFrmVstST3");
        public static WinFormsField DaysFrmVstST3 = new WinFormsField("DAYS-FRM-VST-ST-3", "DaysFrmVstST3");
        public static WinFormsField VestingPercent3 = new WinFormsField("VESTING-PERCENT-3", "VestingPercent3");
        public static WinFormsField VestingDate3 = new WinFormsField("VESTING-DATE-3", "VestingDate3");
        public static WinFormsField TestDate3 = new WinFormsField("TEST-DATE-3", "TestDate3");
        public static WinFormsField TestPercent3 = new WinFormsField("TEST-PERCENT-3", "TestPercent3");
        public static WinFormsField CancelUnv3 = new WinFormsField("CANCEL-UNV-3", "CancelUnv3");
        public static WinFormsField VestingMonth4 = new WinFormsField("VESTING-MONTH-4", "VestingMonth4");
        public static WinFormsField VestingDay4 = new WinFormsField("VESTING-DAY-4", "VestingDay4");
        public static WinFormsField VestStartDate4 = new WinFormsField("VEST-START-DATE-4", "VestStartDate4");
        public static WinFormsField VestExpiry4 = new WinFormsField("VEST-EXPIRY-4", "VestExpiry4");
        public static WinFormsField MthsFrmVstST4 = new WinFormsField("MTHS-FRM-VST-ST-4", "MthsFrmVstST4");
        public static WinFormsField DaysFrmVstST4 = new WinFormsField("DAYS-FRM-VST-ST-4", "DaysFrmVstST4");
        public static WinFormsField VestingPercent4 = new WinFormsField("VESTING-PERCENT-4", "VestingPercent4");
        public static WinFormsField VestingDate4 = new WinFormsField("VESTING-DATE-4", "VestingDate4");
        public static WinFormsField TestDate4 = new WinFormsField("TEST-DATE-4", "TestDate4");
        public static WinFormsField TestPercent4 = new WinFormsField("TEST-PERCENT-4", "TestPercent4");
        public static WinFormsField CancelUnv4 = new WinFormsField("CANCEL-UNV-4", "CancelUnv4");
        public static WinFormsField VestingMonth5 = new WinFormsField("VESTING-MONTH-5", "VestingMonth5");
        public static WinFormsField VestingDay5 = new WinFormsField("VESTING-DAY-5", "VestingDay5");
        public static WinFormsField VestStartDate5 = new WinFormsField("VEST-START-DATE-5", "VestStartDate5");
        public static WinFormsField VestExpiry5 = new WinFormsField("VEST-EXPIRY-5", "VestExpiry5");
        public static WinFormsField MthsFrmVstST5 = new WinFormsField("MTHS-FRM-VST-ST-5", "MthsFrmVstST5");
        public static WinFormsField DaysFrmVstST5 = new WinFormsField("DAYS-FRM-VST-ST-5", "DaysFrmVstST5");
        public static WinFormsField VestingPercent5 = new WinFormsField("VESTING-PERCENT-5", "VestingPercent5");
        public static WinFormsField VestingDate5 = new WinFormsField("VESTING-DATE-5", "VestingDate5");
        public static WinFormsField TestDate5 = new WinFormsField("TEST-DATE-5", "TestDate5");
        public static WinFormsField TestPercent5 = new WinFormsField("TEST-PERCENT-5", "TestPercent5");
        public static WinFormsField CancelUnv5 = new WinFormsField("CANCEL-UNV-5", "CancelUnv5");
        public static WinFormsField VestingMonth6 = new WinFormsField("VESTING-MONTH-6", "VestingMonth6");
        public static WinFormsField VestingDay6 = new WinFormsField("VESTING-DAY-6", "VestingDay6");
        public static WinFormsField VestStartDate6 = new WinFormsField("VEST-START-DATE-6", "VestStartDate6");
        public static WinFormsField VestExpiry6 = new WinFormsField("VEST-EXPIRY-6", "VestExpiry6");
        public static WinFormsField MthsFrmVstST6 = new WinFormsField("MTHS-FRM-VST-ST-6", "MthsFrmVstST6");
        public static WinFormsField DaysFrmVstST6 = new WinFormsField("DAYS-FRM-VST-ST-6", "DaysFrmVstST6");
        public static WinFormsField VestingPercent6 = new WinFormsField("VESTING-PERCENT-6", "VestingPercent6");
        public static WinFormsField VestingDate6 = new WinFormsField("VESTING-DATE-6", "VestingDate6");
        public static WinFormsField TestDate6 = new WinFormsField("TEST-DATE-6", "TestDate6");
        public static WinFormsField TestPercent6 = new WinFormsField("TEST-PERCENT-6", "TestPercent6");
        public static WinFormsField CancelUnv6 = new WinFormsField("CANCEL-UNV-6", "CancelUnv6");
        public static WinFormsField VestingMonth7 = new WinFormsField("VESTING-MONTH-7", "VestingMonth7");
        public static WinFormsField VestingDay7 = new WinFormsField("VESTING-DAY-7", "VestingDay7");
        public static WinFormsField VestStartDate7 = new WinFormsField("VEST-START-DATE-7", "VestStartDate7");
        public static WinFormsField VestExpiry7 = new WinFormsField("VEST-EXPIRY-7", "VestExpiry7");
        public static WinFormsField MthsFrmVstST7 = new WinFormsField("MTHS-FRM-VST-ST-7", "MthsFrmVstST7");
        public static WinFormsField DaysFrmVstST7 = new WinFormsField("DAYS-FRM-VST-ST-7", "DaysFrmVstST7");
        public static WinFormsField VestingPercent7 = new WinFormsField("VESTING-PERCENT-7", "VestingPercent7");
        public static WinFormsField VestingDate7 = new WinFormsField("VESTING-DATE-7", "VestingDate7");
        public static WinFormsField TestDate7 = new WinFormsField("TEST-DATE-7", "TestDate7");
        public static WinFormsField TestPercent7 = new WinFormsField("TEST-PERCENT-7", "TestPercent7");
        public static WinFormsField CancelUnv7 = new WinFormsField("CANCEL-UNV-7", "CancelUnv7");
        public static WinFormsField VestingMonth8 = new WinFormsField("VESTING-MONTH-8", "VestingMonth8");
        public static WinFormsField VestingDay8 = new WinFormsField("VESTING-DAY-8", "VestingDay8");
        public static WinFormsField VestStartDate8 = new WinFormsField("VEST-START-DATE-8", "VestStartDate8");
        public static WinFormsField VestExpiry8 = new WinFormsField("VEST-EXPIRY-8", "VestExpiry8");
        public static WinFormsField MthsFrmVstST8 = new WinFormsField("MTHS-FRM-VST-ST-8", "MthsFrmVstST8");
        public static WinFormsField DaysFrmVstST8 = new WinFormsField("DAYS-FRM-VST-ST-8", "DaysFrmVstST8");
        public static WinFormsField VestingPercent8 = new WinFormsField("VESTING-PERCENT-8", "VestingPercent8");
        public static WinFormsField VestingDate8 = new WinFormsField("VESTING-DATE-8", "VestingDate8");
        public static WinFormsField TestDate8 = new WinFormsField("TEST-DATE-8", "TestDate8");
        public static WinFormsField TestPercent8 = new WinFormsField("TEST-PERCENT-8", "TestPercent8");
        public static WinFormsField CancelUnv8 = new WinFormsField("CANCEL-UNV-8", "CancelUnv8");
        public static WinFormsField VestingMonth9 = new WinFormsField("VESTING-MONTH-9", "VestingMonth9");
        public static WinFormsField VestingDay9 = new WinFormsField("VESTING-DAY-9", "VestingDay9");
        public static WinFormsField VestStartDate9 = new WinFormsField("VEST-START-DATE-9", "VestStartDate9");
        public static WinFormsField VestExpiry9 = new WinFormsField("VEST-EXPIRY-9", "VestExpiry9");
        public static WinFormsField MthsFrmVstST9 = new WinFormsField("MTHS-FRM-VST-ST-9", "MthsFrmVstST9");
        public static WinFormsField DaysFrmVstST9 = new WinFormsField("DAYS-FRM-VST-ST-9", "DaysFrmVstST9");
        public static WinFormsField VestingPercent9 = new WinFormsField("VESTING-PERCENT-9", "VestingPercent9");
        public static WinFormsField VestingDate9 = new WinFormsField("VESTING-DATE-9", "VestingDate9");
        public static WinFormsField TestDate9 = new WinFormsField("TEST-DATE-9", "TestDate9");
        public static WinFormsField TestPercent9 = new WinFormsField("TEST-PERCENT-9", "TestPercent9");
        public static WinFormsField CancelUnv9 = new WinFormsField("CANCEL-UNV-9", "CancelUnv9");
        public static WinFormsField VestingMonth10 = new WinFormsField("VESTING-MONTH-10", "VestingMonth10");
        public static WinFormsField VestingDay10 = new WinFormsField("VESTING-DAY-10", "VestingDay10");
        public static WinFormsField VestStartDate10 = new WinFormsField("VEST-START-DATE-10", "VestStartDate10");
        public static WinFormsField VestExpiry10 = new WinFormsField("VEST-EXPIRY-10", "VestExpiry10");
        public static WinFormsField MthsFrmVstST10 = new WinFormsField("MTHS-FRM-VST-ST-10", "MthsFrmVstST10");
        public static WinFormsField DaysFrmVstST10 = new WinFormsField("DAYS-FRM-VST-ST-10", "DaysFrmVstST10");
        public static WinFormsField VestingPercent10 = new WinFormsField("VESTING-PERCENT-10", "VestingPercent10");
        public static WinFormsField VestingDate10 = new WinFormsField("VESTING-DATE-10", "VestingDate10");
        public static WinFormsField TestDate10 = new WinFormsField("TEST-DATE-10", "TestDate10");
        public static WinFormsField TestPercent10 = new WinFormsField("TEST-PERCENT-10", "TestPercent10");
        public static WinFormsField CancelUnv10 = new WinFormsField("CANCEL-UNV-10", "CancelUnv10");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
