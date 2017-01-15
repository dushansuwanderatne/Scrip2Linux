using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PRXVOT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PRXVOT01", "FormName");
		//Fields


        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField RefNumber = new WinFormsField("REF-NUMBER", "RefNumber");
        public static WinFormsField GroupCode = new WinFormsField("GROUP-CODE", "GroupCode");
        public static WinFormsField Resolution = new WinFormsField("RESOLUTION", "Resolution");
        public static WinFormsField NomPersonA = new WinFormsField("NOM-PERSON-A", "NomPersonA");
        public static WinFormsField NomPersonB = new WinFormsField("NOM-PERSON-B", "NomPersonB");
        public static WinFormsField FailingNomPerson = new WinFormsField("FAILING-NOM-PERSON", "FailingNomPerson");
        public static WinFormsField ProxyRunNumber = new WinFormsField("PROXY-RUN-NUMBER", "ProxyRunNumber");
        public static WinFormsField PercentA = new WinFormsField("PERCENT-A", "PercentA");
        public static WinFormsField VotingPercentOption = new WinFormsField("VOTING-PERCENT-OPTION", "VotingPercentOption");
        public static WinFormsField ProxyType = new WinFormsField("PROXY-TYPE", "ProxyType");
        public static WinFormsField LastAVHolding = new WinFormsField("LAST-AV-HOLDING", "LastAVHolding");
        public static WinFormsField VotingIntention = new WinFormsField("VOTING-INTENTION", "VotingIntention");
        public static WinFormsField TotalVotes = new WinFormsField("TOTAL-VOTES", "TotalVotes");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField TotalUnitsB = new WinFormsField("TOTAL-UNITS-B", "TotalUnitsB");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
