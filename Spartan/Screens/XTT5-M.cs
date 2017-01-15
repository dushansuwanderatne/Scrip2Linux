using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class XTT5M
          //public class XTT5-M

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("XTT5-M", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField HldaddVersion = new WinFormsField("HLDADD-VERSION", "HldaddVersion");
        public static WinFormsField PrintOption = new WinFormsField("PRINT-OPTION", "PrintOption");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField MsaTwodirFlag = new WinFormsField("MSA-TWODIR-FLAG", "MsaTwodirFlag");
        public static WinFormsField NotingTypeCode = new WinFormsField("NOTING-TYPE-CODE", "NotingTypeCode");
        public static WinFormsField NotingNumber = new WinFormsField("NOTING-NUMBER", "NotingNumber");
        public static WinFormsField MsaGovdirFlag = new WinFormsField("MSA-GOVDIR-FLAG", "MsaGovdirFlag");
        public static WinFormsField Filler1 = new WinFormsField("FILLER1", "Filler1");
        public static WinFormsField LCRunNumber = new WinFormsField("LC-RUN-NUMBER", "LCRunNumber");
        public static WinFormsField MsaDirsecFlag = new WinFormsField("MSA-DIRSEC-FLAG", "MsaDirsecFlag");
        public static WinFormsField LCTransNumber = new WinFormsField("LC-TRANS-NUMBER", "LCTransNumber");
        public static WinFormsField MsaAuthsigFlag = new WinFormsField("MSA-AUTHSIG-FLAG", "MsaAuthsigFlag");
        public static WinFormsField IncorpedDate = new WinFormsField("INCORPED-DATE", "IncorpedDate");
        public static WinFormsField IncorpedIN = new WinFormsField("INCORPED-IN", "IncorpedIN");
        public static WinFormsField MsaOtherComent = new WinFormsField("MSA-OTHER-COMENT", "MsaOtherComent");
        public static WinFormsField NotingNameLine = new WinFormsField("NOTING-NAME-LINE", "NotingNameLine");
        public static WinFormsField NotingComment70 = new WinFormsField("NOTING-COMMENT70", "NotingComment70");
        public static WinFormsField LodgedBYComment = new WinFormsField("LODGED-BY-COMMENT", "LodgedBYComment");
    }
}
