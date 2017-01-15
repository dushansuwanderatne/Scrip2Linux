using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZSV010Q

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZSV010Q", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Nzlsrv010qParticipantCode = new WinFormsField("NZLSRV010Q-PARTICIPANT-CODE", "Nzlsrv010qParticipantCode");
        public static WinFormsField Nzlsrv010qCsnHolderNumber = new WinFormsField("NZLSRV010Q-CSN-HOLDER-NUMBER", "Nzlsrv010qCsnHolderNumber");
        public static WinFormsField Nzlsrv010qOldFin = new WinFormsField("NZLSRV010Q-OLD-FIN", "Nzlsrv010qOldFin");
        public static WinFormsField Nzlsrv010qNewFin = new WinFormsField("NZLSRV010Q-NEW-FIN", "Nzlsrv010qNewFin");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
