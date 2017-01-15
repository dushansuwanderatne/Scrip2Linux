using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS04201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS04201", "FormName");
		//Fields


        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField FileDate = new WinFormsField("FILE-DATE", "FileDate");
        public static WinFormsField FileTime = new WinFormsField("FILE-TIME", "FileTime");
        public static WinFormsField NbrOFHolders = new WinFormsField("NBR-OF-HOLDERS", "NbrOFHolders");
        public static WinFormsField TotalEntitlement = new WinFormsField("TOTAL-ENTITLEMENT", "TotalEntitlement");
        public static WinFormsField CutoffPoint = new WinFormsField("CUTOFF-POINT", "CutoffPoint");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField Entitlement = new WinFormsField("ENTITLEMENT", "Entitlement");
        public static WinFormsField Ranking = new WinFormsField("RANKING", "Ranking");
        public static WinFormsField LodgmentDate = new WinFormsField("LODGMENT-DATE", "LodgmentDate");
        public static WinFormsField VotingMethod = new WinFormsField("VOTING-METHOD", "VotingMethod");
        public static WinFormsField MaxUnfaVote = new WinFormsField("MAX-UNFA-VOTE", "MaxUnfaVote");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField HolderSearchKey = new WinFormsField("HOLDER-SEARCH-KEY", "HolderSearchKey");
        public static WinFormsField RatioClass = new WinFormsField("RATIO-CLASS", "RatioClass");
        public static WinFormsField ClassGroup = new WinFormsField("CLASS-GROUP", "ClassGroup");
        public static WinFormsField TotalNbrOFHolders = new WinFormsField("TOTAL-NBR-OF-HOLDERS", "TotalNbrOFHolders");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
    }
}
