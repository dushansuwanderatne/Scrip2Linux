using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZSV220H

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZSV220H", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Nzlsrv220qhInstrumentCode = new WinFormsField("NZLSRV220QH-INSTRUMENT-CODE", "Nzlsrv220qhInstrumentCode");
        public static WinFormsField Nzlsrv220qhParticipantCode = new WinFormsField("NZLSRV220QH-PARTICIPANT-CODE", "Nzlsrv220qhParticipantCode");
        public static WinFormsField Nzlsrv220qhTransferRef = new WinFormsField("NZLSRV220QH-TRANSFER-REF", "Nzlsrv220qhTransferRef");
        public static WinFormsField Nzlsrv220qhDuplicateFlag = new WinFormsField("NZLSRV220QH-DUPLICATE-FLAG", "Nzlsrv220qhDuplicateFlag");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
