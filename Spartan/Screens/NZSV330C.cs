using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZSV330C

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZSV330C", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Nzlsrv330cStartRestart = new WinFormsField("NZLSRV330C-START-RESTART", "Nzlsrv330cStartRestart");
        public static WinFormsField Nzlsrv330cParticipantCode = new WinFormsField("NZLSRV330C-PARTICIPANT-CODE", "Nzlsrv330cParticipantCode");
        public static WinFormsField Nzlsrv330cBalanceDate = new WinFormsField("NZLSRV330C-BALANCE-DATE", "Nzlsrv330cBalanceDate");
        public static WinFormsField Nzlsrv330cInstCodeStart = new WinFormsField("NZLSRV330C-INST-CODE-START", "Nzlsrv330cInstCodeStart");
        public static WinFormsField Nzlsrv330cInstCodeEnd = new WinFormsField("NZLSRV330C-INST-CODE-END", "Nzlsrv330cInstCodeEnd");
        public static WinFormsField Nzlsrv330cMaxReplies = new WinFormsField("NZLSRV330C-MAX-REPLIES", "Nzlsrv330cMaxReplies");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
