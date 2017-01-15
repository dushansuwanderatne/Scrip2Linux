using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NOTENQ11

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NOTENQ11", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField NotingNameLine = new WinFormsField("NOTING-NAME-LINE", "NotingNameLine");
        public static WinFormsField IncorpedIN = new WinFormsField("INCORPED-IN", "IncorpedIN");
        public static WinFormsField IncorpedDate = new WinFormsField("INCORPED-DATE", "IncorpedDate");
        public static WinFormsField MsaTwodirFlag = new WinFormsField("MSA-TWODIR-FLAG", "MsaTwodirFlag");
        public static WinFormsField MsaDirsecFlag = new WinFormsField("MSA-DIRSEC-FLAG", "MsaDirsecFlag");
        public static WinFormsField MsaGovdirFlag = new WinFormsField("MSA-GOVDIR-FLAG", "MsaGovdirFlag");
        public static WinFormsField MsaAuthsigFlag = new WinFormsField("MSA-AUTHSIG-FLAG", "MsaAuthsigFlag");
        public static WinFormsField MsaOtherComment = new WinFormsField("MSA-OTHER-COMMENT", "MsaOtherComment");
        public static WinFormsField NotingComment70 = new WinFormsField("NOTING-COMMENT70", "NotingComment70");
        public static WinFormsField LodgedBYComment = new WinFormsField("LODGED-BY-COMMENT", "LodgedBYComment");
    }
}
