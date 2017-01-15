using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSHLD02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSHLD02", "FormName");
		//Fields


        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField EsshldKey2 = new WinFormsField("ESSHLD-KEY2", "EsshldKey2");
        public static WinFormsField EsshldKey1 = new WinFormsField("ESSHLD-KEY1", "EsshldKey1");
        public static WinFormsField VestingCode = new WinFormsField("VESTING-CODE", "VestingCode");
        public static WinFormsField Meh0UnvestedBalance = new WinFormsField("MEH0-UNVESTED-BALANCE", "Meh0UnvestedBalance");
        public static WinFormsField IgnoreBlackoutInd = new WinFormsField("IGNORE-BLACKOUT-IND", "IgnoreBlackoutInd");
        public static WinFormsField Meh0UnvestedNOChgUnits = new WinFormsField("MEH0-UNVESTED-NO-CHG-UNITS", "Meh0UnvestedNOChgUnits");
        public static WinFormsField LeaverProcessedInd = new WinFormsField("LEAVER-PROCESSED-IND", "LeaverProcessedInd");
        public static WinFormsField Meh0VestedBalance = new WinFormsField("MEH0-VESTED-BALANCE", "Meh0VestedBalance");
        public static WinFormsField Meh0ScheduleTypeInd = new WinFormsField("MEH0-SCHEDULE-TYPE-IND", "Meh0ScheduleTypeInd");
        public static WinFormsField Meh0VestedNOChgUnits = new WinFormsField("MEH0-VESTED-NO-CHG-UNITS", "Meh0VestedNOChgUnits");
        public static WinFormsField VestingNoticeSentInd = new WinFormsField("VESTING-NOTICE-SENT-IND", "VestingNoticeSentInd");
        public static WinFormsField VestingNoticeSentDate = new WinFormsField("VESTING-NOTICE-SENT-DATE", "VestingNoticeSentDate");
        public static WinFormsField MaintainRestrictInd = new WinFormsField("MAINTAIN-RESTRICT-IND", "MaintainRestrictInd");
        public static WinFormsField LeaverBalance = new WinFormsField("LEAVER-BALANCE", "LeaverBalance");
        public static WinFormsField LapseNoticeSentInd = new WinFormsField("LAPSE-NOTICE-SENT-IND", "LapseNoticeSentInd");
        public static WinFormsField MaintainRestrictUnits = new WinFormsField("MAINTAIN-RESTRICT-UNITS", "MaintainRestrictUnits");
        public static WinFormsField LapseNoticeSentDate = new WinFormsField("LAPSE-NOTICE-SENT-DATE", "LapseNoticeSentDate");
        public static WinFormsField AvailONUnits = new WinFormsField("AVAIL-ON-UNITS", "AvailONUnits");
    }
}
