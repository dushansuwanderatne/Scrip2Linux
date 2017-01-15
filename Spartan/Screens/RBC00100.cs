using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RBC00100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RBC00100", "FormName");
		//Fields


        public static WinFormsField TipsterName = new WinFormsField("TIPSTER-NAME", "TipsterName");
        public static WinFormsField TestINSeries = new WinFormsField("TEST-IN-SERIES", "TestINSeries");
        public static WinFormsField Venue = new WinFormsField("VENUE", "Venue");
        public static WinFormsField DeadlineDate = new WinFormsField("DEADLINE-DATE", "DeadlineDate");
        public static WinFormsField DeadlineTime = new WinFormsField("DEADLINE-TIME", "DeadlineTime");
        public static WinFormsField StartDate = new WinFormsField("START-DATE", "StartDate");
        public static WinFormsField Team1 = new WinFormsField("TEAM1", "Team1");
        public static WinFormsField Team2 = new WinFormsField("TEAM2", "Team2");
        public static WinFormsField Player1Selected = new WinFormsField("PLAYER-1-SELECTED", "Player1Selected");
        public static WinFormsField Player1 = new WinFormsField("PLAYER-1", "Player1");
        public static WinFormsField Player2Selected = new WinFormsField("PLAYER-2-SELECTED", "Player2Selected");
        public static WinFormsField Player2 = new WinFormsField("PLAYER-2", "Player2");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField SearchData = new WinFormsField("SEARCH-DATA", "SearchData");
    }
}
