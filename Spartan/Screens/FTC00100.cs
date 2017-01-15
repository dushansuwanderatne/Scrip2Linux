using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FTC00100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FTC00100", "FormName");
		//Fields


        public static WinFormsField TipsterName = new WinFormsField("TIPSTER-NAME", "TipsterName");
        public static WinFormsField DeadlineLiteral = new WinFormsField("DEADLINE-LITERAL", "DeadlineLiteral");
        public static WinFormsField Round = new WinFormsField("ROUND", "Round");
        public static WinFormsField HomeTeam = new WinFormsField("HOME-TEAM", "HomeTeam");
        public static WinFormsField AwayTeam = new WinFormsField("AWAY-TEAM", "AwayTeam");
        public static WinFormsField WT1 = new WinFormsField("WT-1", "WT1");
        public static WinFormsField VenueInd = new WinFormsField("VENUE-IND", "VenueInd");
        public static WinFormsField PlayDate = new WinFormsField("PLAY-DATE", "PlayDate");
        public static WinFormsField WT2 = new WinFormsField("WT-2", "WT2");
        public static WinFormsField WT3 = new WinFormsField("WT-3", "WT3");
        public static WinFormsField WT4 = new WinFormsField("WT-4", "WT4");
        public static WinFormsField WT5 = new WinFormsField("WT-5", "WT5");
        public static WinFormsField WT6 = new WinFormsField("WT-6", "WT6");
        public static WinFormsField WT7 = new WinFormsField("WT-7", "WT7");
        public static WinFormsField WT8 = new WinFormsField("WT-8", "WT8");
        public static WinFormsField WT9 = new WinFormsField("WT-9", "WT9");
        public static WinFormsField HighPoints = new WinFormsField("HIGH-POINTS", "HighPoints");
        public static WinFormsField JackpotValue = new WinFormsField("JACKPOT-VALUE", "JackpotValue");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField SearchData = new WinFormsField("SEARCH-DATA", "SearchData");
    }
}
