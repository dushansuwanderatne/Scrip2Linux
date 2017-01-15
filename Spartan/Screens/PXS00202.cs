using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00202

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00202", "FormName");
		//Fields
        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField ProxyDescription = new WinFormsField("PROXY-DESCRIPTION", "ProxyDescription");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField SpecialCondInd = new WinFormsField("SPECIAL-COND-IND", "SpecialCondInd");
        public static WinFormsField MinBalanceYN = new WinFormsField("MIN-BALANCE-YN", "MinBalanceYN");
        public static WinFormsField RunUpto = new WinFormsField("RUN-UPTO", "RunUpto");
        public static WinFormsField MaxVotesYN = new WinFormsField("MAX-VOTES-YN", "MaxVotesYN");
        public static WinFormsField MaxVotes = new WinFormsField("MAX-VOTES", "MaxVotes");
        public static WinFormsField GroupApply = new WinFormsField("GROUP-APPLY", "GroupApply");
        public static WinFormsField SpecialCalcInd = new WinFormsField("SPECIAL-CALC-IND", "SpecialCalcInd");
        public static WinFormsField AllCalc = new WinFormsField("ALL-CALC", "AllCalc");
        public static WinFormsField CorpRepNotingNum = new WinFormsField("CORP-REP-NOTING-NUM", "CorpRepNotingNum");
        public static WinFormsField PreEncodedNotInp = new WinFormsField("PRE-ENCODED-NOT-INP", "PreEncodedNotInp");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
