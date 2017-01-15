using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS02003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS02003", "FormName");
		//Fields
        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField Nal = new WinFormsField("NAL", "Nal");
        public static WinFormsField RefNum = new WinFormsField("REF-NUM", "RefNum");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField LodgDate = new WinFormsField("LODG-DATE", "LodgDate");
        public static WinFormsField Noma = new WinFormsField("NOMA", "Noma");
        public static WinFormsField FailingA = new WinFormsField("FAILING-A", "FailingA");
        public static WinFormsField Dsc01 = new WinFormsField("DSC-01", "Dsc01");
        public static WinFormsField For01 = new WinFormsField("FOR-01", "For01");
        public static WinFormsField Against01 = new WinFormsField("AGAINST-01", "Against01");
        public static WinFormsField OpenTicked01 = new WinFormsField("OPEN-TICKED-01", "OpenTicked01");
        public static WinFormsField OpenUnticked01 = new WinFormsField("OPEN-UNTICKED-01", "OpenUnticked01");
        public static WinFormsField Abstain01 = new WinFormsField("ABSTAIN-01", "Abstain01");
        public static WinFormsField Exclude01 = new WinFormsField("EXCLUDE-01", "Exclude01");
        public static WinFormsField ExcludeInd01 = new WinFormsField("EXCLUDE-IND-01", "ExcludeInd01");
        public static WinFormsField Dsc02 = new WinFormsField("DSC-02", "Dsc02");
        public static WinFormsField For02 = new WinFormsField("FOR-02", "For02");
        public static WinFormsField Against02 = new WinFormsField("AGAINST-02", "Against02");
        public static WinFormsField OpenTicked02 = new WinFormsField("OPEN-TICKED-02", "OpenTicked02");
        public static WinFormsField OpenUnticked02 = new WinFormsField("OPEN-UNTICKED-02", "OpenUnticked02");
        public static WinFormsField Abstain02 = new WinFormsField("ABSTAIN-02", "Abstain02");
        public static WinFormsField Exclude02 = new WinFormsField("EXCLUDE-02", "Exclude02");
        public static WinFormsField ExcludeInd02 = new WinFormsField("EXCLUDE-IND-02", "ExcludeInd02");
        public static WinFormsField Dsc03 = new WinFormsField("DSC-03", "Dsc03");
        public static WinFormsField For03 = new WinFormsField("FOR-03", "For03");
        public static WinFormsField Against03 = new WinFormsField("AGAINST-03", "Against03");
        public static WinFormsField OpenTicked03 = new WinFormsField("OPEN-TICKED-03", "OpenTicked03");
        public static WinFormsField OpenUnticked03 = new WinFormsField("OPEN-UNTICKED-03", "OpenUnticked03");
        public static WinFormsField Abstain03 = new WinFormsField("ABSTAIN-03", "Abstain03");
        public static WinFormsField Exclude03 = new WinFormsField("EXCLUDE-03", "Exclude03");
        public static WinFormsField ExcludeInd03 = new WinFormsField("EXCLUDE-IND-03", "ExcludeInd03");
        public static WinFormsField Dsc04 = new WinFormsField("DSC-04", "Dsc04");
        public static WinFormsField For04 = new WinFormsField("FOR-04", "For04");
        public static WinFormsField Against04 = new WinFormsField("AGAINST-04", "Against04");
        public static WinFormsField OpenTicked04 = new WinFormsField("OPEN-TICKED-04", "OpenTicked04");
        public static WinFormsField OpenUnticked04 = new WinFormsField("OPEN-UNTICKED-04", "OpenUnticked04");
        public static WinFormsField Abstain04 = new WinFormsField("ABSTAIN-04", "Abstain04");
        public static WinFormsField Exclude04 = new WinFormsField("EXCLUDE-04", "Exclude04");
        public static WinFormsField ExcludeInd04 = new WinFormsField("EXCLUDE-IND-04", "ExcludeInd04");
        public static WinFormsField Dsc05 = new WinFormsField("DSC-05", "Dsc05");
        public static WinFormsField For05 = new WinFormsField("FOR-05", "For05");
        public static WinFormsField Against05 = new WinFormsField("AGAINST-05", "Against05");
        public static WinFormsField OpenTicked05 = new WinFormsField("OPEN-TICKED-05", "OpenTicked05");
        public static WinFormsField OpenUnticked05 = new WinFormsField("OPEN-UNTICKED-05", "OpenUnticked05");
        public static WinFormsField Abstain05 = new WinFormsField("ABSTAIN-05", "Abstain05");
        public static WinFormsField Exclude05 = new WinFormsField("EXCLUDE-05", "Exclude05");
        public static WinFormsField ExcludeInd05 = new WinFormsField("EXCLUDE-IND-05", "ExcludeInd05");
        public static WinFormsField Dsc06 = new WinFormsField("DSC-06", "Dsc06");
        public static WinFormsField For06 = new WinFormsField("FOR-06", "For06");
        public static WinFormsField Against06 = new WinFormsField("AGAINST-06", "Against06");
        public static WinFormsField OpenTicked06 = new WinFormsField("OPEN-TICKED-06", "OpenTicked06");
        public static WinFormsField OpenUnticked06 = new WinFormsField("OPEN-UNTICKED-06", "OpenUnticked06");
        public static WinFormsField Abstain06 = new WinFormsField("ABSTAIN-06", "Abstain06");
        public static WinFormsField Exclude06 = new WinFormsField("EXCLUDE-06", "Exclude06");
        public static WinFormsField ExcludeInd06 = new WinFormsField("EXCLUDE-IND-06", "ExcludeInd06");
        public static WinFormsField Dsc07 = new WinFormsField("DSC-07", "Dsc07");
        public static WinFormsField For07 = new WinFormsField("FOR-07", "For07");
        public static WinFormsField Against07 = new WinFormsField("AGAINST-07", "Against07");
        public static WinFormsField OpenTicked07 = new WinFormsField("OPEN-TICKED-07", "OpenTicked07");
        public static WinFormsField OpenUnticked07 = new WinFormsField("OPEN-UNTICKED-07", "OpenUnticked07");
        public static WinFormsField Abstain07 = new WinFormsField("ABSTAIN-07", "Abstain07");
        public static WinFormsField Exclude07 = new WinFormsField("EXCLUDE-07", "Exclude07");
        public static WinFormsField ExcludeInd07 = new WinFormsField("EXCLUDE-IND-07", "ExcludeInd07");
        public static WinFormsField Dsc08 = new WinFormsField("DSC-08", "Dsc08");
        public static WinFormsField For08 = new WinFormsField("FOR-08", "For08");
        public static WinFormsField Against08 = new WinFormsField("AGAINST-08", "Against08");
        public static WinFormsField OpenTicked08 = new WinFormsField("OPEN-TICKED-08", "OpenTicked08");
        public static WinFormsField OpenUnticked08 = new WinFormsField("OPEN-UNTICKED-08", "OpenUnticked08");
        public static WinFormsField Abstain08 = new WinFormsField("ABSTAIN-08", "Abstain08");
        public static WinFormsField Exclude08 = new WinFormsField("EXCLUDE-08", "Exclude08");
        public static WinFormsField ExcludeInd08 = new WinFormsField("EXCLUDE-IND-08", "ExcludeInd08");
        public static WinFormsField Dsc09 = new WinFormsField("DSC-09", "Dsc09");
        public static WinFormsField For09 = new WinFormsField("FOR-09", "For09");
        public static WinFormsField Against09 = new WinFormsField("AGAINST-09", "Against09");
        public static WinFormsField OpenTicked09 = new WinFormsField("OPEN-TICKED-09", "OpenTicked09");
        public static WinFormsField OpenUnticked09 = new WinFormsField("OPEN-UNTICKED-09", "OpenUnticked09");
        public static WinFormsField Abstain09 = new WinFormsField("ABSTAIN-09", "Abstain09");
        public static WinFormsField Exclude09 = new WinFormsField("EXCLUDE-09", "Exclude09");
        public static WinFormsField ExcludeInd09 = new WinFormsField("EXCLUDE-IND-09", "ExcludeInd09");
        public static WinFormsField Dsc10 = new WinFormsField("DSC-10", "Dsc10");
        public static WinFormsField For10 = new WinFormsField("FOR-10", "For10");
        public static WinFormsField Against10 = new WinFormsField("AGAINST-10", "Against10");
        public static WinFormsField OpenTicked10 = new WinFormsField("OPEN-TICKED-10", "OpenTicked10");
        public static WinFormsField OpenUnticked10 = new WinFormsField("OPEN-UNTICKED-10", "OpenUnticked10");
        public static WinFormsField Abstain10 = new WinFormsField("ABSTAIN-10", "Abstain10");
        public static WinFormsField Exclude10 = new WinFormsField("EXCLUDE-10", "Exclude10");
        public static WinFormsField ExcludeInd10 = new WinFormsField("EXCLUDE-IND-10", "ExcludeInd10");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
