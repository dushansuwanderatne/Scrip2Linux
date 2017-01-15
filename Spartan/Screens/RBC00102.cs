using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RBC00102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RBC00102", "FormName");
		//Fields


        public static WinFormsField TestINSeries = new WinFormsField("TEST-IN-SERIES", "TestINSeries");
        public static WinFormsField Venue = new WinFormsField("VENUE", "Venue");
        public static WinFormsField TipsterName = new WinFormsField("TIPSTER-NAME", "TipsterName");
        public static WinFormsField Player = new WinFormsField("PLAYER", "Player");
        public static WinFormsField Team1 = new WinFormsField("TEAM1", "Team1");
        public static WinFormsField Team2 = new WinFormsField("TEAM2", "Team2");
        public static WinFormsField Result = new WinFormsField("RESULT", "Result");
        public static WinFormsField Ducks = new WinFormsField("DUCKS", "Ducks");
        public static WinFormsField Lbws = new WinFormsField("LBWS", "Lbws");
        public static WinFormsField Crowd = new WinFormsField("CROWD", "Crowd");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
