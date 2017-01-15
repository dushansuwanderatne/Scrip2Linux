using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZSV340C

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZSV340C", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Nzlsrv340cStartRestart = new WinFormsField("NZLSRV340C-START-RESTART", "Nzlsrv340cStartRestart");
        public static WinFormsField Nzlsrv340cInstrumentCode = new WinFormsField("NZLSRV340C-INSTRUMENT-CODE", "Nzlsrv340cInstrumentCode");
        public static WinFormsField Nzlsrv340cParticipantCode = new WinFormsField("NZLSRV340C-PARTICIPANT-CODE", "Nzlsrv340cParticipantCode");
        public static WinFormsField Nzlsrv340cEnquiryDate = new WinFormsField("NZLSRV340C-ENQUIRY-DATE", "Nzlsrv340cEnquiryDate");
        public static WinFormsField Nzlsrv340cEnquiryTime = new WinFormsField("NZLSRV340C-ENQUIRY-TIME", "Nzlsrv340cEnquiryTime");
        public static WinFormsField Nzlsrv340cHolderOrigin = new WinFormsField("NZLSRV340C-HOLDER-ORIGIN", "Nzlsrv340cHolderOrigin");
        public static WinFormsField Nzlsrv340cHolderNumber = new WinFormsField("NZLSRV340C-HOLDER-NUMBER", "Nzlsrv340cHolderNumber");
        public static WinFormsField Nzlsrv340cRegistryCode = new WinFormsField("NZLSRV340C-REGISTRY-CODE", "Nzlsrv340cRegistryCode");
        public static WinFormsField Nzlsrv340cRegistryContext = new WinFormsField("NZLSRV340C-REGISTRY-CONTEXT", "Nzlsrv340cRegistryContext");
        public static WinFormsField Nzlsrv340cMaxReplies = new WinFormsField("NZLSRV340C-MAX-REPLIES", "Nzlsrv340cMaxReplies");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
