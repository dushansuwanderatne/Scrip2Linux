using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FTC00200

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FTC00200", "FormName");
		//Fields


        public static WinFormsField SystemInfoDate6 = new WinFormsField("SYSTEM-INFO-DATE-6", "10", "10");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 4", "4");
        public static WinFormsField SystemInfoUser1 = new WinFormsField("SYSTEM-INFO-USER-1", "11", "11");
        public static WinFormsField Round = new WinFormsField("ROUND", "Round");
        public static WinFormsField HomeTeam = new WinFormsField("HOME-TEAM", "HomeTeam");
        public static WinFormsField AwayTeam = new WinFormsField("AWAY-TEAM", "AwayTeam");
        public static WinFormsField VenueLP = new WinFormsField("VENUE-LP", "VenueLP");
        public static WinFormsField VenueInd = new WinFormsField("VENUE-IND", "VenueInd");
        public static WinFormsField VenueRP = new WinFormsField("VENUE-RP", "VenueRP");
        public static WinFormsField PlayDate = new WinFormsField("PLAY-DATE", "PlayDate");
        public static WinFormsField DeadlineHH = new WinFormsField("DEADLINE-HH", "DeadlineHH");
        public static WinFormsField DeadlineColon = new WinFormsField("DEADLINE-COLON", "DeadlineColon");
        public static WinFormsField DeadlineMM = new WinFormsField("DEADLINE-MM", "DeadlineMM");
        public static WinFormsField WinTeam = new WinFormsField("WIN-TEAM", "WinTeam");
        public static WinFormsField HighPoints = new WinFormsField("HIGH-POINTS", "HighPoints");
        public static WinFormsField JackpotValue = new WinFormsField("JACKPOT-VALUE", "JackpotValue");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField SearchData = new WinFormsField("SEARCH-DATA", "SearchData");
    }
}
