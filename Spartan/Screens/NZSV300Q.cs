using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZSV300Q

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZSV300Q", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Nzlsrv300qInstrumentCode = new WinFormsField("NZLSRV300Q-INSTRUMENT-CODE", "Nzlsrv300qInstrumentCode");
        public static WinFormsField Nzlsrv300qParticipantCode = new WinFormsField("NZLSRV300Q-PARTICIPANT-CODE", "Nzlsrv300qParticipantCode");
        public static WinFormsField Nzlsrv300qHolderNumber = new WinFormsField("NZLSRV300Q-HOLDER-NUMBER", "Nzlsrv300qHolderNumber");
        public static WinFormsField Nzlsrv300qHolderOrigin = new WinFormsField("NZLSRV300Q-HOLDER-ORIGIN", "Nzlsrv300qHolderOrigin");
        public static WinFormsField Nzlsrv300qRegisterCode = new WinFormsField("NZLSRV300Q-REGISTER-CODE", "Nzlsrv300qRegisterCode");
        public static WinFormsField Nzlsrv300qFin = new WinFormsField("NZLSRV300Q-FIN", "Nzlsrv300qFin");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
