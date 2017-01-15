using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FTC00300

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FTC00300", "FormName");
		//Fields


        public static WinFormsField SystemInfoDate6 = new WinFormsField("SYSTEM-INFO-DATE-6", "10", "10");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 4", "4");
        public static WinFormsField SystemInfoUser1 = new WinFormsField("SYSTEM-INFO-USER-1", "11", "11");
        public static WinFormsField HomeTeam = new WinFormsField("HOME-TEAM", "HomeTeam");
        public static WinFormsField AwayTeam = new WinFormsField("AWAY-TEAM", "AwayTeam");
        public static WinFormsField RoundNbrL = new WinFormsField("ROUND-NBR-L", "RoundNbrL");
        public static WinFormsField HomeTeamL = new WinFormsField("HOME-TEAM-L", "HomeTeamL");
        public static WinFormsField AwayTeamL = new WinFormsField("AWAY-TEAM-L", "AwayTeamL");
        public static WinFormsField RoundNbrR = new WinFormsField("ROUND-NBR-R", "RoundNbrR");
        public static WinFormsField HomeTeamR = new WinFormsField("HOME-TEAM-R", "HomeTeamR");
        public static WinFormsField AwayTeamR = new WinFormsField("AWAY-TEAM-R", "AwayTeamR");
        public static WinFormsField WonL = new WinFormsField("WON-L", "WonL");
        public static WinFormsField LostL = new WinFormsField("LOST-L", "LostL");
        public static WinFormsField DrawnL = new WinFormsField("DRAWN-L", "DrawnL");
        public static WinFormsField WonR = new WinFormsField("WON-R", "WonR");
        public static WinFormsField LostR = new WinFormsField("LOST-R", "LostR");
        public static WinFormsField DrawnR = new WinFormsField("DRAWN-R", "DrawnR");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
