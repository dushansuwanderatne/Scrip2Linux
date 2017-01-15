using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZSV100C

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZSV100C", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Nzlsrv100cStartRestart = new WinFormsField("NZLSRV100C-START-RESTART", "Nzlsrv100cStartRestart");
        public static WinFormsField Nzlsrv100cBalanceDate = new WinFormsField("NZLSRV100C-BALANCE-DATE", "Nzlsrv100cBalanceDate");
        public static WinFormsField Nzlsrv100cInstrumentCode = new WinFormsField("NZLSRV100C-INSTRUMENT-CODE", "Nzlsrv100cInstrumentCode");
        public static WinFormsField Nzlsrv100c1stParticCode = new WinFormsField("NZLSRV100C-1ST-PARTIC-CODE", "Nzlsrv100c1stParticCode");
        public static WinFormsField Nzlsrv100cRestartInformation = new WinFormsField("NZLSRV100C-RESTART-INFORMATION", "Nzlsrv100cRestartInformation");
        public static WinFormsField Nzlsrv100cMaxReplies = new WinFormsField("NZLSRV100C-MAX-REPLIES", "Nzlsrv100cMaxReplies");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
