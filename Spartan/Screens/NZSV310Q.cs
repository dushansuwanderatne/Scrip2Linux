using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZSV310Q

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZSV310Q", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Nzlsrv310qInstrumentCode = new WinFormsField("NZLSRV310Q-INSTRUMENT-CODE", "Nzlsrv310qInstrumentCode");
        public static WinFormsField Nzlsrv310qParticipantCode = new WinFormsField("NZLSRV310Q-PARTICIPANT-CODE", "Nzlsrv310qParticipantCode");
        public static WinFormsField Nzlsrv310qHolderNumber = new WinFormsField("NZLSRV310Q-HOLDER-NUMBER", "Nzlsrv310qHolderNumber");
        public static WinFormsField Nzlsrv310qHolderOrigin = new WinFormsField("NZLSRV310Q-HOLDER-ORIGIN", "Nzlsrv310qHolderOrigin");
        public static WinFormsField Nzlsrv310qRegisterCode = new WinFormsField("NZLSRV310Q-REGISTER-CODE", "Nzlsrv310qRegisterCode");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
