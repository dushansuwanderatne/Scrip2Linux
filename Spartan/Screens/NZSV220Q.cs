using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZSV220Q

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZSV220Q", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Nzlsrv220qInstrumentCode = new WinFormsField("NZLSRV220Q-INSTRUMENT-CODE", "Nzlsrv220qInstrumentCode");
        public static WinFormsField Nzlsrv220qSellParticipant = new WinFormsField("NZLSRV220Q-SELL-PARTICIPANT", "Nzlsrv220qSellParticipant");
        public static WinFormsField Nzlsrv220qBuyParticipant = new WinFormsField("NZLSRV220Q-BUY-PARTICIPANT", "Nzlsrv220qBuyParticipant");
        public static WinFormsField Nzlsrv220qReference = new WinFormsField("NZLSRV220Q-REFERENCE", "Nzlsrv220qReference");
        public static WinFormsField Nzlsrv220qTransferQuantity = new WinFormsField("NZLSRV220Q-TRANSFER-QUANTITY", "Nzlsrv220qTransferQuantity");
        public static WinFormsField Nzlsrv220qTransferPayment = new WinFormsField("NZLSRV220Q-TRANSFER-PAYMENT", "Nzlsrv220qTransferPayment");
        public static WinFormsField Nzlsrv220qTransferCurrency = new WinFormsField("NZLSRV220Q-TRANSFER-CURRENCY", "Nzlsrv220qTransferCurrency");
        public static WinFormsField Nzlsrv220qDuplicateFlag = new WinFormsField("NZLSRV220Q-DUPLICATE-FLAG", "Nzlsrv220qDuplicateFlag");
        public static WinFormsField Nzlsrv220qHoldFlag = new WinFormsField("NZLSRV220Q-HOLD-FLAG", "Nzlsrv220qHoldFlag");
        public static WinFormsField Nzlsrv220qUnnotifiedFlag = new WinFormsField("NZLSRV220Q-UNNOTIFIED-FLAG", "Nzlsrv220qUnnotifiedFlag");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
