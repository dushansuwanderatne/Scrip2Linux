using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK06010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK06010", "FormName");
		//Fields
        public static WinFormsField VestingCode = new WinFormsField("VESTING-CODE", "VestingCode");
        public static WinFormsField VestingDescription = new WinFormsField("VESTING-DESCRIPTION", "VestingDescription");
        public static WinFormsField VestingPercentage = new WinFormsField("VESTING-PERCENTAGE", "VestingPercentage");
        public static WinFormsField VestingTrancheNbr = new WinFormsField("VESTING-TRANCHE-NBR", "VestingTrancheNbr");
        public static WinFormsField PerformanceCode = new WinFormsField("PERFORMANCE-CODE", "PerformanceCode");
        public static WinFormsField PerformanceDesc = new WinFormsField("PERFORMANCE-DESC", "PerformanceDesc");
        public static WinFormsField TestNumber = new WinFormsField("TEST-NUMBER", "TestNumber");
        public static WinFormsField TestDate = new WinFormsField("TEST-DATE", "TestDate");
        public static WinFormsField TestPercent = new WinFormsField("TEST-PERCENT", "TestPercent");
        public static WinFormsField CancelUnv = new WinFormsField("CANCEL-UNV", "CancelUnv");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField LocateVestCode = new WinFormsField("LOCATE-VEST-CODE", "LocateVestCode");
        public static WinFormsField LocateTrancheNbr = new WinFormsField("LOCATE-TRANCHE-NBR", "LocateTrancheNbr");
        public static WinFormsField LocatePerfCode = new WinFormsField("LOCATE-PERF-CODE", "LocatePerfCode");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
