using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEP00202

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEP00202", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField ProxyDescription = new WinFormsField("PROXY-DESCRIPTION", "ProxyDescription");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField SpecialCalcInd = new WinFormsField("SPECIAL-CALC-IND", "SpecialCalcInd");
        public static WinFormsField AllCalc = new WinFormsField("ALL-CALC", "AllCalc");
        public static WinFormsField ExcludeTypesInd = new WinFormsField("EXCLUDE-TYPES-IND", "ExcludeTypesInd");
        public static WinFormsField CorpRepNotingNum = new WinFormsField("CORP-REP-NOTING-NUM", "CorpRepNotingNum");
        public static WinFormsField PreEncodedNotInp = new WinFormsField("PRE-ENCODED-NOT-INP", "PreEncodedNotInp");
        public static WinFormsField VotingRedistMethod = new WinFormsField("VOTING-REDIST-METHOD", "VotingRedistMethod");
        public static WinFormsField PostalVoteCode = new WinFormsField("POSTAL-VOTE-CODE", "PostalVoteCode");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
