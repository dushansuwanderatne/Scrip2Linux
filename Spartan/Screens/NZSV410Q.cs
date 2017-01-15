using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZSV410Q

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZSV410Q", "FormName");
		//Fields


        public static WinFormsField Nzlsrv410qInstrumentCode = new WinFormsField("NZLSRV410Q-INSTRUMENT-CODE", "Nzlsrv410qInstrumentCode");
        public static WinFormsField Nzlsrv410qBrokerCode = new WinFormsField("NZLSRV410Q-BROKER-CODE", "Nzlsrv410qBrokerCode");
        public static WinFormsField Nzlsrv410qHolderNumber = new WinFormsField("NZLSRV410Q-HOLDER-NUMBER", "Nzlsrv410qHolderNumber");
        public static WinFormsField Nzlsrv410qHolderOrigin = new WinFormsField("NZLSRV410Q-HOLDER-ORIGIN", "Nzlsrv410qHolderOrigin");
        public static WinFormsField Nzlsrv410qRegisterCode = new WinFormsField("NZLSRV410Q-REGISTER-CODE", "Nzlsrv410qRegisterCode");
        public static WinFormsField Nzlsrv410qResNumber = new WinFormsField("NZLSRV410Q-RES-NUMBER", "Nzlsrv410qResNumber");
        public static WinFormsField Nzlsrv410qBrokerReference = new WinFormsField("NZLSRV410Q-BROKER-REFERENCE", "Nzlsrv410qBrokerReference");
        public static WinFormsField Nzlsrv410qDuplicateFlag = new WinFormsField("NZLSRV410Q-DUPLICATE-FLAG", "Nzlsrv410qDuplicateFlag");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
