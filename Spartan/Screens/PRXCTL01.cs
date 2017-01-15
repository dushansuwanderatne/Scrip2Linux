using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PRXCTL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PRXCTL01", "FormName");
		//Fields


        public static WinFormsField PrxctlKey0 = new WinFormsField("PRXCTL-KEY0", "PrxctlKey0");
        public static WinFormsField ProxyDescription = new WinFormsField("PROXY-DESCRIPTION", "ProxyDescription");
        public static WinFormsField ATMeeting = new WinFormsField("AT-MEETING", "ATMeeting");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField ChairmanCode = new WinFormsField("CHAIRMAN-CODE", "ChairmanCode");
        public static WinFormsField AllvotRun = new WinFormsField("ALLVOT-RUN", "AllvotRun");
        public static WinFormsField NbrResolutions = new WinFormsField("NBR-RESOLUTIONS", "NbrResolutions");
        public static WinFormsField ReportingRun = new WinFormsField("REPORTING-RUN", "ReportingRun");
        public static WinFormsField SchemeMeetingInd = new WinFormsField("SCHEME-MEETING-IND", "SchemeMeetingInd");
        public static WinFormsField LastBatchRefNum = new WinFormsField("LAST-BATCH-REF-NUM", "LastBatchRefNum");
        public static WinFormsField InternetMeetingInd = new WinFormsField("INTERNET-MEETING-IND", "InternetMeetingInd");
        public static WinFormsField AllvotPastCutoff = new WinFormsField("ALLVOT-PAST-CUTOFF", "AllvotPastCutoff");
        public static WinFormsField InternetNomPerson = new WinFormsField("INTERNET-NOM-PERSON", "InternetNomPerson");
        public static WinFormsField ExtraResolutionsInd = new WinFormsField("EXTRA-RESOLUTIONS-IND", "ExtraResolutionsInd");
        public static WinFormsField AlgorithmNbr = new WinFormsField("ALGORITHM-NBR", "AlgorithmNbr");
        public static WinFormsField PrxmbrCreatedStage = new WinFormsField("PRXMBR-CREATED-STAGE", "PrxmbrCreatedStage");
        public static WinFormsField OveApplies = new WinFormsField("OVE-APPLIES", "OveApplies");
        public static WinFormsField OtherVoteRestrict = new WinFormsField("OTHER-VOTE-RESTRICT", "OtherVoteRestrict");
        public static WinFormsField SpecialCondInd = new WinFormsField("SPECIAL-COND-IND", "SpecialCondInd");
        public static WinFormsField OveOneTick = new WinFormsField("OVE-ONE-TICK", "OveOneTick");
        public static WinFormsField MinBalanceYN = new WinFormsField("MIN-BALANCE-YN", "MinBalanceYN");
        public static WinFormsField SameClasses = new WinFormsField("SAME-CLASSES", "SameClasses");
        public static WinFormsField RunUpto = new WinFormsField("RUN-UPTO", "RunUpto");
        public static WinFormsField ClassVotesInd = new WinFormsField("CLASS-VOTES-IND", "ClassVotesInd");
        public static WinFormsField MaxVotesYN = new WinFormsField("MAX-VOTES-YN", "MaxVotesYN");
        public static WinFormsField DirectVotingInd = new WinFormsField("DIRECT-VOTING-IND", "DirectVotingInd");
        public static WinFormsField MaxVotes = new WinFormsField("MAX-VOTES", "MaxVotes");
        public static WinFormsField ProcessingCutoffInd = new WinFormsField("PROCESSING-CUTOFF-IND", "ProcessingCutoffInd");
        public static WinFormsField GroupCodeApply = new WinFormsField("GROUP-CODE-APPLY", "GroupCodeApply");
        public static WinFormsField AutoReportInd = new WinFormsField("AUTO-REPORT-IND", "AutoReportInd");
        public static WinFormsField ManualProcCutoffInd = new WinFormsField("MANUAL-PROC-CUTOFF-IND", "ManualProcCutoffInd");
        public static WinFormsField AutoDateFrom = new WinFormsField("AUTO-DATE-FROM", "AutoDateFrom");
        public static WinFormsField ClassExclusionInd = new WinFormsField("CLASS-EXCLUSION-IND", "ClassExclusionInd");
        public static WinFormsField AllocateVoteCalc = new WinFormsField("ALLOCATE-VOTE-CALC", "AllocateVoteCalc");
        public static WinFormsField AutoDateTO = new WinFormsField("AUTO-DATE-TO", "AutoDateTO");
        public static WinFormsField CorpRepNotingNum = new WinFormsField("CORP-REP-NOTING-NUM", "CorpRepNotingNum");
        public static WinFormsField AutoTopReportInd = new WinFormsField("AUTO-TOP-REPORT-IND", "AutoTopReportInd");
        public static WinFormsField ColourCodingYN = new WinFormsField("COLOUR-CODING-YN", "ColourCodingYN");
        public static WinFormsField PreEncodedNotInp = new WinFormsField("PRE-ENCODED-NOT-INP", "PreEncodedNotInp");
        public static WinFormsField AutoSavReportInd = new WinFormsField("AUTO-SAV-REPORT-IND", "AutoSavReportInd");
        public static WinFormsField AttendeeConfirmYN = new WinFormsField("ATTENDEE-CONFIRM-YN", "AttendeeConfirmYN");
        public static WinFormsField DisplayProxyWatchInd = new WinFormsField("DISPLAY-PROXY-WATCH-IND", "DisplayProxyWatchInd");
        public static WinFormsField UnitsUpdMethodInd = new WinFormsField("UNITS-UPD-METHOD-IND", "UnitsUpdMethodInd");
        public static WinFormsField CompanyWarningYN = new WinFormsField("COMPANY-WARNING-YN", "CompanyWarningYN");
        public static WinFormsField Polling = new WinFormsField("POLLING", "Polling");
        public static WinFormsField NomPersonProcess = new WinFormsField("NOM-PERSON-PROCESS", "NomPersonProcess");
        public static WinFormsField ConsolidateRes = new WinFormsField("CONSOLIDATE-RES", "ConsolidateRes");
        public static WinFormsField ImoProcessFlag = new WinFormsField("IMO-PROCESS-FLAG", "ImoProcessFlag");
        public static WinFormsField AutoAttendeeNbrs = new WinFormsField("AUTO-ATTENDEE-NBRS", "AutoAttendeeNbrs");
        public static WinFormsField SecondaryClassesInd = new WinFormsField("SECONDARY-CLASSES-IND", "SecondaryClassesInd");
        public static WinFormsField ImoOvervoteCutoffInd = new WinFormsField("IMO-OVERVOTE-CUTOFF-IND", "ImoOvervoteCutoffInd");
        public static WinFormsField PWFinalProxyFigInd = new WinFormsField("PW-FINAL-PROXY-FIG-IND", "PWFinalProxyFigInd");
        public static WinFormsField ImoCosmosMeetingID = new WinFormsField("IMO-COSMOS-MEETING-ID", "ImoCosmosMeetingID");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
