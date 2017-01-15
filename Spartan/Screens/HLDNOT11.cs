using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HLDNOT11

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HLDNOT11", "FormName");
		//Fields


        public static WinFormsField HldnotKey0 = new WinFormsField("HLDNOT-KEY0", "HldnotKey0");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField LCRunNumber = new WinFormsField("LC-RUN-NUMBER", "LCRunNumber");
        public static WinFormsField NotingTypeCode = new WinFormsField("NOTING-TYPE-CODE", "NotingTypeCode");
        public static WinFormsField LCTransNumber = new WinFormsField("LC-TRANS-NUMBER", "LCTransNumber");
        public static WinFormsField NotingNumber = new WinFormsField("NOTING-NUMBER", "NotingNumber");
        public static WinFormsField IncorpedIN = new WinFormsField("INCORPED-IN", "IncorpedIN");
        public static WinFormsField IncorpedDate = new WinFormsField("INCORPED-DATE", "IncorpedDate");
        public static WinFormsField MsaTwodirFlag = new WinFormsField("MSA-TWODIR-FLAG", "MsaTwodirFlag");
        public static WinFormsField MsaGovdirFlag = new WinFormsField("MSA-GOVDIR-FLAG", "MsaGovdirFlag");
        public static WinFormsField MsaAuthsigFlag = new WinFormsField("MSA-AUTHSIG-FLAG", "MsaAuthsigFlag");
        public static WinFormsField MsaOtherComent = new WinFormsField("MSA-OTHER-COMENT", "MsaOtherComent");
        public static WinFormsField NotingNameLine = new WinFormsField("NOTING-NAME-LINE", "NotingNameLine");
        public static WinFormsField LodgedBYComment = new WinFormsField("LODGED-BY-COMMENT", "LodgedBYComment");
        public static WinFormsField NotingComment70 = new WinFormsField("NOTING-COMMENT70", "NotingComment70");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
