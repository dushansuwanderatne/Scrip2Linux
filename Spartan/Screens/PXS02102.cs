using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS02102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS02102", "FormName");
		//Fields
        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField RefNum = new WinFormsField("REF-NUM", "RefNum");
        public static WinFormsField LodgDate = new WinFormsField("LODG-DATE", "LodgDate");
        public static WinFormsField SPFlag = new WinFormsField("SP-FLAG", "SPFlag");
        public static WinFormsField OveOneBox = new WinFormsField("OVE-ONE-BOX", "OveOneBox");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField Noma = new WinFormsField("NOMA", "Noma");
        public static WinFormsField PerA = new WinFormsField("PER-A", "PerA");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField Nomb = new WinFormsField("NOMB", "Nomb");
        public static WinFormsField SharesA = new WinFormsField("SHARES-A", "SharesA");
        public static WinFormsField FailingA = new WinFormsField("FAILING-A", "FailingA");
        public static WinFormsField Nal = new WinFormsField("NAL", "Nal");
        public static WinFormsField R01Dsc = new WinFormsField("R01-DSC", "R01Dsc");
        public static WinFormsField R01 = new WinFormsField("R01", "R01");
        public static WinFormsField R01Ove = new WinFormsField("R01-OVE", "R01Ove");
        public static WinFormsField R02Dsc = new WinFormsField("R02-DSC", "R02Dsc");
        public static WinFormsField R02 = new WinFormsField("R02", "R02");
        public static WinFormsField R02Ove = new WinFormsField("R02-OVE", "R02Ove");
        public static WinFormsField R03Dsc = new WinFormsField("R03-DSC", "R03Dsc");
        public static WinFormsField R03 = new WinFormsField("R03", "R03");
        public static WinFormsField R03Ove = new WinFormsField("R03-OVE", "R03Ove");
        public static WinFormsField R04Dsc = new WinFormsField("R04-DSC", "R04Dsc");
        public static WinFormsField R04 = new WinFormsField("R04", "R04");
        public static WinFormsField R04Ove = new WinFormsField("R04-OVE", "R04Ove");
        public static WinFormsField R05Dsc = new WinFormsField("R05-DSC", "R05Dsc");
        public static WinFormsField R05 = new WinFormsField("R05", "R05");
        public static WinFormsField R05Ove = new WinFormsField("R05-OVE", "R05Ove");
        public static WinFormsField R06Dsc = new WinFormsField("R06-DSC", "R06Dsc");
        public static WinFormsField R06 = new WinFormsField("R06", "R06");
        public static WinFormsField R06Ove = new WinFormsField("R06-OVE", "R06Ove");
        public static WinFormsField R07Dsc = new WinFormsField("R07-DSC", "R07Dsc");
        public static WinFormsField R07 = new WinFormsField("R07", "R07");
        public static WinFormsField R07Ove = new WinFormsField("R07-OVE", "R07Ove");
        public static WinFormsField R08Dsc = new WinFormsField("R08-DSC", "R08Dsc");
        public static WinFormsField R08 = new WinFormsField("R08", "R08");
        public static WinFormsField R08Ove = new WinFormsField("R08-OVE", "R08Ove");
        public static WinFormsField R09Dsc = new WinFormsField("R09-DSC", "R09Dsc");
        public static WinFormsField R09 = new WinFormsField("R09", "R09");
        public static WinFormsField R09Ove = new WinFormsField("R09-OVE", "R09Ove");
        public static WinFormsField R10Dsc = new WinFormsField("R10-DSC", "R10Dsc");
        public static WinFormsField R10 = new WinFormsField("R10", "R10");
        public static WinFormsField R10Ove = new WinFormsField("R10-OVE", "R10Ove");
        public static WinFormsField R11Dsc = new WinFormsField("R11-DSC", "R11Dsc");
        public static WinFormsField R11 = new WinFormsField("R11", "R11");
        public static WinFormsField R11Ove = new WinFormsField("R11-OVE", "R11Ove");
        public static WinFormsField R12Dsc = new WinFormsField("R12-DSC", "R12Dsc");
        public static WinFormsField R12 = new WinFormsField("R12", "R12");
        public static WinFormsField R12Ove = new WinFormsField("R12-OVE", "R12Ove");
        public static WinFormsField War = new WinFormsField("WAR", "War");
        public static WinFormsField R13Dsc = new WinFormsField("R13-DSC", "R13Dsc");
        public static WinFormsField R13 = new WinFormsField("R13", "R13");
        public static WinFormsField R13Ove = new WinFormsField("R13-OVE", "R13Ove");
        public static WinFormsField R14Dsc = new WinFormsField("R14-DSC", "R14Dsc");
        public static WinFormsField R14 = new WinFormsField("R14", "R14");
        public static WinFormsField R14Ove = new WinFormsField("R14-OVE", "R14Ove");
        public static WinFormsField R15Dsc = new WinFormsField("R15-DSC", "R15Dsc");
        public static WinFormsField R15 = new WinFormsField("R15", "R15");
        public static WinFormsField R15Ove = new WinFormsField("R15-OVE", "R15Ove");
        public static WinFormsField R16Dsc = new WinFormsField("R16-DSC", "R16Dsc");
        public static WinFormsField R16 = new WinFormsField("R16", "R16");
        public static WinFormsField R16Ove = new WinFormsField("R16-OVE", "R16Ove");
        public static WinFormsField R17Dsc = new WinFormsField("R17-DSC", "R17Dsc");
        public static WinFormsField R17 = new WinFormsField("R17", "R17");
        public static WinFormsField R17Ove = new WinFormsField("R17-OVE", "R17Ove");
        public static WinFormsField R18Dsc = new WinFormsField("R18-DSC", "R18Dsc");
        public static WinFormsField R18 = new WinFormsField("R18", "R18");
        public static WinFormsField R18Ove = new WinFormsField("R18-OVE", "R18Ove");
        public static WinFormsField R19Dsc = new WinFormsField("R19-DSC", "R19Dsc");
        public static WinFormsField R19 = new WinFormsField("R19", "R19");
        public static WinFormsField R19Ove = new WinFormsField("R19-OVE", "R19Ove");
        public static WinFormsField R20Dsc = new WinFormsField("R20-DSC", "R20Dsc");
        public static WinFormsField R20 = new WinFormsField("R20", "R20");
        public static WinFormsField R20Ove = new WinFormsField("R20-OVE", "R20Ove");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
