using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS04007

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS04007", "FormName");
		//Fields


        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField LineNumber = new WinFormsField("LINE-NUMBER", "LineNumber");
        public static WinFormsField TranType = new WinFormsField("TRAN-TYPE", "TranType");
        public static WinFormsField TranDate = new WinFormsField("TRAN-DATE", "TranDate");
        public static WinFormsField TranTime = new WinFormsField("TRAN-TIME", "TranTime");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField GroupCode = new WinFormsField("GROUP-CODE", "GroupCode");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField RefNumber = new WinFormsField("REF-NUMBER", "RefNumber");
        public static WinFormsField ProxyRunNumber = new WinFormsField("PROXY-RUN-NUMBER", "ProxyRunNumber");
        public static WinFormsField LodgmentDate = new WinFormsField("LODGMENT-DATE", "LodgmentDate");
        public static WinFormsField NomPersonA = new WinFormsField("NOM-PERSON-A", "NomPersonA");
        public static WinFormsField NomPersonB = new WinFormsField("NOM-PERSON-B", "NomPersonB");
        public static WinFormsField FailingNomPerson = new WinFormsField("FAILING-NOM-PERSON", "FailingNomPerson");
        public static WinFormsField PercentA = new WinFormsField("PERCENT-A", "PercentA");
        public static WinFormsField VotingIntention = new WinFormsField("VOTING-INTENTION", "VotingIntention");
        public static WinFormsField ProxySourceDesc = new WinFormsField("PROXY-SOURCE-DESC", "ProxySourceDesc");
        public static WinFormsField ResolutionLine = new WinFormsField("RESOLUTION-LINE", "ResolutionLine");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
