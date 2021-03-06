using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NOTENQ10

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NOTENQ10", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField NotingNumber = new WinFormsField("NOTING-NUMBER", "NotingNumber");
        public static WinFormsField DonorNameLine = new WinFormsField("DONOR-NAME-LINE", "DonorNameLine");
        public static WinFormsField AttorneysName = new WinFormsField("ATTORNEYS-NAME", "AttorneysName");
        public static WinFormsField PowerDated = new WinFormsField("POWER-DATED", "PowerDated");
        public static WinFormsField PowerNoted = new WinFormsField("POWER-NOTED", "PowerNoted");
        public static WinFormsField AtsJointlyFlag = new WinFormsField("ATS-JOINTLY-FLAG", "AtsJointlyFlag");
        public static WinFormsField AtsSeverallyFlag = new WinFormsField("ATS-SEVERALLY-FLAG", "AtsSeverallyFlag");
        public static WinFormsField AtsAnytwoFlag = new WinFormsField("ATS-ANYTWO-FLAG", "AtsAnytwoFlag");
        public static WinFormsField AtsOtherComment = new WinFormsField("ATS-OTHER-COMMENT", "AtsOtherComment");
        public static WinFormsField PptBuyFlag = new WinFormsField("PPT-BUY-FLAG", "PptBuyFlag");
        public static WinFormsField PptSellFlag = new WinFormsField("PPT-SELL-FLAG", "PptSellFlag");
        public static WinFormsField PptVoteFlag = new WinFormsField("PPT-VOTE-FLAG", "PptVoteFlag");
        public static WinFormsField PptAppsubFlag = new WinFormsField("PPT-APPSUB-FLAG", "PptAppsubFlag");
        public static WinFormsField StampedINComment = new WinFormsField("STAMPED-IN-COMMENT", "StampedINComment");
        public static WinFormsField NotingComment70 = new WinFormsField("NOTING-COMMENT70", "NotingComment70");
        public static WinFormsField LodgedBYComment = new WinFormsField("LODGED-BY-COMMENT", "LodgedBYComment");
    }
}
