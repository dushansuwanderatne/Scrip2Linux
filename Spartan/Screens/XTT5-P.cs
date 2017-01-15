using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    //public class XTT5-P
        public class XTT5P

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("XTT5-P", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField HldaddVersion = new WinFormsField("HLDADD-VERSION", "HldaddVersion");
        public static WinFormsField PrintOption = new WinFormsField("PRINT-OPTION", "PrintOption");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField AtsJointlyFlag = new WinFormsField("ATS-JOINTLY-FLAG", "AtsJointlyFlag");
        public static WinFormsField PptBuyFlag = new WinFormsField("PPT-BUY-FLAG", "PptBuyFlag");
        public static WinFormsField NotingTypeCode = new WinFormsField("NOTING-TYPE-CODE", "NotingTypeCode");
        public static WinFormsField NotingNumber = new WinFormsField("NOTING-NUMBER", "NotingNumber");
        public static WinFormsField AtsSeverallyFlag = new WinFormsField("ATS-SEVERALLY-FLAG", "AtsSeverallyFlag");
        public static WinFormsField PptSellFlag = new WinFormsField("PPT-SELL-FLAG", "PptSellFlag");
        public static WinFormsField LCRunNumber = new WinFormsField("LC-RUN-NUMBER", "LCRunNumber");
        public static WinFormsField AtsAnytwoFlag = new WinFormsField("ATS-ANYTWO-FLAG", "AtsAnytwoFlag");
        public static WinFormsField PptVoteFlag = new WinFormsField("PPT-VOTE-FLAG", "PptVoteFlag");
        public static WinFormsField LCTransNumber = new WinFormsField("LC-TRANS-NUMBER", "LCTransNumber");
        public static WinFormsField PptAppsubFlag = new WinFormsField("PPT-APPSUB-FLAG", "PptAppsubFlag");
        public static WinFormsField AtsOtherComment = new WinFormsField("ATS-OTHER-COMMENT", "AtsOtherComment");
        public static WinFormsField RegCode = new WinFormsField("REG-CODE", "RegCode");
        public static WinFormsField DonorNameLine = new WinFormsField("DONOR-NAME-LINE", "DonorNameLine");
        public static WinFormsField PowerDated = new WinFormsField("POWER-DATED", "PowerDated");
        public static WinFormsField AttorneysName = new WinFormsField("ATTORNEYS-NAME", "AttorneysName");
        public static WinFormsField PowerNoted = new WinFormsField("POWER-NOTED", "PowerNoted");
        public static WinFormsField Filler1 = new WinFormsField("FILLER1", "Filler1");
        public static WinFormsField StampedINComment = new WinFormsField("STAMPED-IN-COMMENT", "StampedINComment");
        public static WinFormsField NotingComment70 = new WinFormsField("NOTING-COMMENT70", "NotingComment70");
        public static WinFormsField LodgedBYComment = new WinFormsField("LODGED-BY-COMMENT", "LodgedBYComment");
    }
}
