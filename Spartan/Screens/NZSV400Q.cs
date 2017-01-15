using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZSV400Q

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZSV400Q", "FormName");
		//Fields


        public static WinFormsField Nzlsrv400qInstrumentCode = new WinFormsField("NZLSRV400Q-INSTRUMENT-CODE", "Nzlsrv400qInstrumentCode");
        public static WinFormsField Nzlsrv400qBrokerCode = new WinFormsField("NZLSRV400Q-BROKER-CODE", "Nzlsrv400qBrokerCode");
        public static WinFormsField Nzlsrv400qHolderNumber = new WinFormsField("NZLSRV400Q-HOLDER-NUMBER", "Nzlsrv400qHolderNumber");
        public static WinFormsField Nzlsrv400qHolderOrigin = new WinFormsField("NZLSRV400Q-HOLDER-ORIGIN", "Nzlsrv400qHolderOrigin");
        public static WinFormsField Nzlsrv400qRegisterCode = new WinFormsField("NZLSRV400Q-REGISTER-CODE", "Nzlsrv400qRegisterCode");
        public static WinFormsField Nzlsrv400qTransferQty = new WinFormsField("NZLSRV400Q-TRANSFER-QTY", "Nzlsrv400qTransferQty");
        public static WinFormsField Nzlsrv400qBrokerReference = new WinFormsField("NZLSRV400Q-BROKER-REFERENCE", "Nzlsrv400qBrokerReference");
        public static WinFormsField Nzlsrv400qDuplicateFlag = new WinFormsField("NZLSRV400Q-DUPLICATE-FLAG", "Nzlsrv400qDuplicateFlag");
        public static WinFormsField Nzlsrv400qFin = new WinFormsField("NZLSRV400Q-FIN", "Nzlsrv400qFin");
        public static WinFormsField Nzlsrv400qReason = new WinFormsField("NZLSRV400Q-REASON", "Nzlsrv400qReason");
        public static WinFormsField Nzlsrv400qExpiryDate = new WinFormsField("NZLSRV400Q-EXPIRY-DATE", "Nzlsrv400qExpiryDate");
        public static WinFormsField Nzlsrv400qReservationDeal = new WinFormsField("NZLSRV400Q-RESERVATION-DEAL", "Nzlsrv400qReservationDeal");
        public static WinFormsField Nzlsrv400qNomParticipant = new WinFormsField("NZLSRV400Q-NOM-PARTICIPANT", "Nzlsrv400qNomParticipant");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
