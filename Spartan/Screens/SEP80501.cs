using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEP80501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEP80501", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField CandBrief1 = new WinFormsField("CAND-BRIEF-1", "CandBrief1");
        public static WinFormsField CandName1 = new WinFormsField("CAND-NAME-1", "CandName1");
        public static WinFormsField Votes1 = new WinFormsField("VOTES-1", "Votes1");
        public static WinFormsField Perc1 = new WinFormsField("PERC-1", "Perc1");
        public static WinFormsField Pref1Cand1 = new WinFormsField("PREF-1-CAND-1", "Pref1Cand1");
        public static WinFormsField Pref2Cand1 = new WinFormsField("PREF-2-CAND-1", "Pref2Cand1");
        public static WinFormsField CandBrief2 = new WinFormsField("CAND-BRIEF-2", "CandBrief2");
        public static WinFormsField CandName2 = new WinFormsField("CAND-NAME-2", "CandName2");
        public static WinFormsField Votes2 = new WinFormsField("VOTES-2", "Votes2");
        public static WinFormsField Perc2 = new WinFormsField("PERC-2", "Perc2");
        public static WinFormsField Pref1Cand2 = new WinFormsField("PREF-1-CAND-2", "Pref1Cand2");
        public static WinFormsField Pref2Cand2 = new WinFormsField("PREF-2-CAND-2", "Pref2Cand2");
        public static WinFormsField CandBrief3 = new WinFormsField("CAND-BRIEF-3", "CandBrief3");
        public static WinFormsField CandName3 = new WinFormsField("CAND-NAME-3", "CandName3");
        public static WinFormsField Votes3 = new WinFormsField("VOTES-3", "Votes3");
        public static WinFormsField Perc3 = new WinFormsField("PERC-3", "Perc3");
        public static WinFormsField Pref1Cand3 = new WinFormsField("PREF-1-CAND-3", "Pref1Cand3");
        public static WinFormsField Pref2Cand3 = new WinFormsField("PREF-2-CAND-3", "Pref2Cand3");
        public static WinFormsField CandBrief4 = new WinFormsField("CAND-BRIEF-4", "CandBrief4");
        public static WinFormsField CandName4 = new WinFormsField("CAND-NAME-4", "CandName4");
        public static WinFormsField Votes4 = new WinFormsField("VOTES-4", "Votes4");
        public static WinFormsField Perc4 = new WinFormsField("PERC-4", "Perc4");
        public static WinFormsField Pref1Cand4 = new WinFormsField("PREF-1-CAND-4", "Pref1Cand4");
        public static WinFormsField Pref2Cand4 = new WinFormsField("PREF-2-CAND-4", "Pref2Cand4");
        public static WinFormsField CandBrief5 = new WinFormsField("CAND-BRIEF-5", "CandBrief5");
        public static WinFormsField CandName5 = new WinFormsField("CAND-NAME-5", "CandName5");
        public static WinFormsField Votes5 = new WinFormsField("VOTES-5", "Votes5");
        public static WinFormsField Perc5 = new WinFormsField("PERC-5", "Perc5");
        public static WinFormsField Pref1Cand5 = new WinFormsField("PREF-1-CAND-5", "Pref1Cand5");
        public static WinFormsField Pref2Cand5 = new WinFormsField("PREF-2-CAND-5", "Pref2Cand5");
        public static WinFormsField CandBrief6 = new WinFormsField("CAND-BRIEF-6", "CandBrief6");
        public static WinFormsField CandName6 = new WinFormsField("CAND-NAME-6", "CandName6");
        public static WinFormsField Votes6 = new WinFormsField("VOTES-6", "Votes6");
        public static WinFormsField Perc6 = new WinFormsField("PERC-6", "Perc6");
        public static WinFormsField Pref1Cand6 = new WinFormsField("PREF-1-CAND-6", "Pref1Cand6");
        public static WinFormsField Pref2Cand6 = new WinFormsField("PREF-2-CAND-6", "Pref2Cand6");
        public static WinFormsField CandBrief7 = new WinFormsField("CAND-BRIEF-7", "CandBrief7");
        public static WinFormsField CandName7 = new WinFormsField("CAND-NAME-7", "CandName7");
        public static WinFormsField Votes7 = new WinFormsField("VOTES-7", "Votes7");
        public static WinFormsField Perc7 = new WinFormsField("PERC-7", "Perc7");
        public static WinFormsField Pref1Cand7 = new WinFormsField("PREF-1-CAND-7", "Pref1Cand7");
        public static WinFormsField Pref2Cand7 = new WinFormsField("PREF-2-CAND-7", "Pref2Cand7");
        public static WinFormsField CandBrief8 = new WinFormsField("CAND-BRIEF-8", "CandBrief8");
        public static WinFormsField CandName8 = new WinFormsField("CAND-NAME-8", "CandName8");
        public static WinFormsField Votes8 = new WinFormsField("VOTES-8", "Votes8");
        public static WinFormsField Perc8 = new WinFormsField("PERC-8", "Perc8");
        public static WinFormsField Pref1Cand8 = new WinFormsField("PREF-1-CAND-8", "Pref1Cand8");
        public static WinFormsField Pref2Cand8 = new WinFormsField("PREF-2-CAND-8", "Pref2Cand8");
        public static WinFormsField CandBrief9 = new WinFormsField("CAND-BRIEF-9", "CandBrief9");
        public static WinFormsField CandName9 = new WinFormsField("CAND-NAME-9", "CandName9");
        public static WinFormsField Votes9 = new WinFormsField("VOTES-9", "Votes9");
        public static WinFormsField Perc9 = new WinFormsField("PERC-9", "Perc9");
        public static WinFormsField Pref1Cand9 = new WinFormsField("PREF-1-CAND-9", "Pref1Cand9");
        public static WinFormsField Pref2Cand9 = new WinFormsField("PREF-2-CAND-9", "Pref2Cand9");
        public static WinFormsField SelectedCand = new WinFormsField("SELECTED-CAND", "SelectedCand");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
