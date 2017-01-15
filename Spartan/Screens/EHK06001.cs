using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK06001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK06001", "FormName");
		//Fields
        public static WinFormsField VestingCode = new WinFormsField("VESTING-CODE", "VestingCode");
        public static WinFormsField VestingDescription = new WinFormsField("VESTING-DESCRIPTION", "VestingDescription");
        public static WinFormsField VestingTermINMnths = new WinFormsField("VESTING-TERM-IN-MNTHS", "VestingTermINMnths");
        public static WinFormsField VestingTermINDays = new WinFormsField("VESTING-TERM-IN-DAYS", "VestingTermINDays");
        public static WinFormsField UnitRounding = new WinFormsField("UNIT-ROUNDING", "UnitRounding");
        public static WinFormsField TrancheNumber = new WinFormsField("TRANCHE-NUMBER", "TrancheNumber");
        public static WinFormsField MnthsFromVestStart = new WinFormsField("MNTHS-FROM-VEST-START", "MnthsFromVestStart");
        public static WinFormsField DaysFromVestStart = new WinFormsField("DAYS-FROM-VEST-START", "DaysFromVestStart");
        public static WinFormsField VestingPercentage = new WinFormsField("VESTING-PERCENTAGE", "VestingPercentage");
        public static WinFormsField VestingDate = new WinFormsField("VESTING-DATE", "VestingDate");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
        public static WinFormsField Comments1 = new WinFormsField("COMMENTS-1", "Comments1");
        public static WinFormsField Comments2 = new WinFormsField("COMMENTS-2", "Comments2");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
