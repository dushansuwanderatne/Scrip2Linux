using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZSV240Q

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZSV240Q", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Nzlsrv240qInstrumentCode = new WinFormsField("NZLSRV240Q-INSTRUMENT-CODE", "Nzlsrv240qInstrumentCode");
        public static WinFormsField Nzlsrv240qParticipantCode = new WinFormsField("NZLSRV240Q-PARTICIPANT-CODE", "Nzlsrv240qParticipantCode");
        public static WinFormsField Nzlsrv240qHolderNumber = new WinFormsField("NZLSRV240Q-HOLDER-NUMBER", "Nzlsrv240qHolderNumber");
        public static WinFormsField Nzlsrv240qHolderOrigin = new WinFormsField("NZLSRV240Q-HOLDER-ORIGIN", "Nzlsrv240qHolderOrigin");
        public static WinFormsField Nzlsrv240qRegisterCode = new WinFormsField("NZLSRV240Q-REGISTER-CODE", "Nzlsrv240qRegisterCode");
        public static WinFormsField Nzlsrv240qTransferQuantity = new WinFormsField("NZLSRV240Q-TRANSFER-QUANTITY", "Nzlsrv240qTransferQuantity");
        public static WinFormsField Nzlsrv240qReference = new WinFormsField("NZLSRV240Q-REFERENCE", "Nzlsrv240qReference");
        public static WinFormsField Nzlsrv240qDuplicateFlag = new WinFormsField("NZLSRV240Q-DUPLICATE-FLAG", "Nzlsrv240qDuplicateFlag");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
