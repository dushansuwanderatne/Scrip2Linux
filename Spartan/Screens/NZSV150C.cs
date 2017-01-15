using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZSV150C

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZSV150C", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Nzlsrv150cStartRestart = new WinFormsField("NZLSRV150C-START-RESTART", "Nzlsrv150cStartRestart");
        public static WinFormsField Nzlsrv150cInstrumentCode = new WinFormsField("NZLSRV150C-INSTRUMENT-CODE", "Nzlsrv150cInstrumentCode");
        public static WinFormsField Nzlsrv150cRestartInfo = new WinFormsField("NZLSRV150C-RESTART-INFO", "Nzlsrv150cRestartInfo");
        public static WinFormsField Nzlsrv150cMaxReplies = new WinFormsField("NZLSRV150C-MAX-REPLIES", "Nzlsrv150cMaxReplies");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
