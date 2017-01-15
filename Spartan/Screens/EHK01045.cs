using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01045

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01045", "FormName");
		//Fields
        public static WinFormsField EventType = new WinFormsField("EVENT-TYPE", "EventType");
        public static WinFormsField EventCurrentInd = new WinFormsField("EVENT-CURRENT-IND", "EventCurrentInd");
        public static WinFormsField EventCode = new WinFormsField("EVENT-CODE", "EventCode");
        public static WinFormsField EventDescription = new WinFormsField("EVENT-DESCRIPTION", "EventDescription");
        public static WinFormsField EventClosedInd = new WinFormsField("EVENT-CLOSED-IND", "EventClosedInd");
        public static WinFormsField EventDate = new WinFormsField("EVENT-DATE", "EventDate");
        public static WinFormsField EvtPeriodSta = new WinFormsField("EVT-PERIOD-STA", "EvtPeriodSta");
        public static WinFormsField EvtPeriodEnd = new WinFormsField("EVT-PERIOD-END", "EvtPeriodEnd");
        public static WinFormsField EvtNotificationDT = new WinFormsField("EVT-NOTIFICATION-DT", "EvtNotificationDT");
        public static WinFormsField EvtApplicationDT = new WinFormsField("EVT-APPLICATION-DT", "EvtApplicationDT");
        public static WinFormsField EvtCommMethod = new WinFormsField("EVT-COMM-METHOD", "EvtCommMethod");
        public static WinFormsField DefaultBulkType = new WinFormsField("DEFAULT-BULK-TYPE", "DefaultBulkType");
        public static WinFormsField DefaultBulkCode = new WinFormsField("DEFAULT-BULK-CODE", "DefaultBulkCode");
        public static WinFormsField DfltPaytMethod = new WinFormsField("DFLT-PAYT-METHOD", "DfltPaytMethod");
        public static WinFormsField DefaultXferCode = new WinFormsField("DEFAULT-XFER-CODE", "DefaultXferCode");
        public static WinFormsField DfltNtxDspslchoic = new WinFormsField("DFLT-NTX-DSPSLCHOIC", "DfltNtxDspslchoic");
        public static WinFormsField DfltNtxDspslchoices = new WinFormsField("DFLT-NTX-DSPSLCHOICES", "DfltNtxDspslchoices");
        public static WinFormsField TXRteAplcableInd = new WinFormsField("TX-RTE-APLCABLE-IND", "TXRteAplcableInd");
        public static WinFormsField DfltTaxDspslchoic = new WinFormsField("DFLT-TAX-DSPSLCHOIC", "DfltTaxDspslchoic");
        public static WinFormsField DfltTaxDspslchoices = new WinFormsField("DFLT-TAX-DSPSLCHOICES", "DfltTaxDspslchoices");
        public static WinFormsField TaxEventPointFlg = new WinFormsField("TAX-EVENT-POINT-FLG", "TaxEventPointFlg");
        public static WinFormsField DfltRblDspslchoic = new WinFormsField("DFLT-RBL-DSPSLCHOIC", "DfltRblDspslchoic");
        public static WinFormsField EvtElctnPerdInd = new WinFormsField("EVT-ELCTN-PERD-IND", "EvtElctnPerdInd");
        public static WinFormsField ConsolidatePayments = new WinFormsField("CONSOLIDATE-PAYMENTS", "ConsolidatePayments");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
