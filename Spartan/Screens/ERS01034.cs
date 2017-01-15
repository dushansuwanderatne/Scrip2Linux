using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01034

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01034", "FormName");
		//Fields
        public static WinFormsField AwardDate = new WinFormsField("AWARD-DATE", "AwardDate");
        public static WinFormsField AcqstnSharePrice = new WinFormsField("ACQSTN-SHARE-PRICE", "AcqstnSharePrice");
        public static WinFormsField AwardExchgRate = new WinFormsField("AWARD-EXCHG-RATE", "AwardExchgRate");
        public static WinFormsField IfrsFmv = new WinFormsField("IFRS-FMV", "IfrsFmv");
        public static WinFormsField ExpiryDate = new WinFormsField("EXPIRY-DATE", "ExpiryDate");
        public static WinFormsField VestingCode = new WinFormsField("VESTING-CODE", "VestingCode");
        public static WinFormsField VestingStartDate = new WinFormsField("VESTING-START-DATE", "VestingStartDate");
        public static WinFormsField PerformanceHurdles = new WinFormsField("PERFORMANCE-HURDLES", "PerformanceHurdles");
        public static WinFormsField PerformanceCode = new WinFormsField("PERFORMANCE-CODE", "PerformanceCode");
        public static WinFormsField CtlPayFreqDtls = new WinFormsField("CTL-PAY-FREQ-DTLS", "CtlPayFreqDtls");
        public static WinFormsField HlthIntgrtyModeInd = new WinFormsField("HLTH-INTGRTY-MODE-IND", "HlthIntgrtyModeInd");
        public static WinFormsField EnabledStatusInd = new WinFormsField("ENABLED-STATUS-IND", "EnabledStatusInd");
        public static WinFormsField PriceUpdatedInd = new WinFormsField("PRICE-UPDATED-IND", "PriceUpdatedInd");
        public static WinFormsField Comments = new WinFormsField("COMMENTS", "Comments");
        public static WinFormsField DisplayONWeb = new WinFormsField("DISPLAY-ON-WEB", "DisplayONWeb");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
