using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZSV360Q

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZSV360Q", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Nzlsrv360qInstrumentCode = new WinFormsField("NZLSRV360Q-INSTRUMENT-CODE", "Nzlsrv360qInstrumentCode");
        public static WinFormsField Nzlsrv360qParticipantCode = new WinFormsField("NZLSRV360Q-PARTICIPANT-CODE", "Nzlsrv360qParticipantCode");
        public static WinFormsField Nzlsrv360qTransNumber = new WinFormsField("NZLSRV360Q-TRANS-NUMBER", "Nzlsrv360qTransNumber");
        public static WinFormsField Nzlsrv360qTransferType = new WinFormsField("NZLSRV360Q-TRANSFER-TYPE", "Nzlsrv360qTransferType");
        public static WinFormsField Nzlsrv360qReference = new WinFormsField("NZLSRV360Q-REFERENCE", "Nzlsrv360qReference");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
