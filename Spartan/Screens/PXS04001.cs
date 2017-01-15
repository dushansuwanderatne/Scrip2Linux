using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS04001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS04001", "FormName");
		//Fields
        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField GroupCode = new WinFormsField("GROUP-CODE", "GroupCode");
        public static WinFormsField RefNumber = new WinFormsField("REF-NUMBER", "RefNumber");
        public static WinFormsField LodgmentDate = new WinFormsField("LODGMENT-DATE", "LodgmentDate");
        public static WinFormsField ProxyRunNumber = new WinFormsField("PROXY-RUN-NUMBER", "ProxyRunNumber");
        public static WinFormsField NomPersonA = new WinFormsField("NOM-PERSON-A", "NomPersonA");
        public static WinFormsField NomPersonB = new WinFormsField("NOM-PERSON-B", "NomPersonB");
        public static WinFormsField FailingNomPerson = new WinFormsField("FAILING-NOM-PERSON", "FailingNomPerson");
        public static WinFormsField PercentA = new WinFormsField("PERCENT-A", "PercentA");
        public static WinFormsField VotingIntention = new WinFormsField("VOTING-INTENTION", "VotingIntention");
        public static WinFormsField ProxySourceDesc = new WinFormsField("PROXY-SOURCE-DESC", "ProxySourceDesc");
        public static WinFormsField ResolutionLine = new WinFormsField("RESOLUTION-LINE", "ResolutionLine");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField HolderSearchKey = new WinFormsField("HOLDER-SEARCH-KEY", "HolderSearchKey");
        public static WinFormsField DisplayAction = new WinFormsField("DISPLAY-ACTION", "DisplayAction");
        public static WinFormsField FilterClass = new WinFormsField("FILTER-CLASS", "FilterClass");
        public static WinFormsField UnitCurrencyInd = new WinFormsField("UNIT-CURRENCY-IND", "UnitCurrencyInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
