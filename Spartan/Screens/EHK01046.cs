using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01046

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01046", "FormName");
		//Fields
        public static WinFormsField EventType = new WinFormsField("EVENT-TYPE", "EventType");
        public static WinFormsField EventCurrentInd = new WinFormsField("EVENT-CURRENT-IND", "EventCurrentInd");
        public static WinFormsField EventCode = new WinFormsField("EVENT-CODE", "EventCode");
        public static WinFormsField EventDescription = new WinFormsField("EVENT-DESCRIPTION", "EventDescription");
        public static WinFormsField EventClosedInd = new WinFormsField("EVENT-CLOSED-IND", "EventClosedInd");
        public static WinFormsField EventDate = new WinFormsField("EVENT-DATE", "EventDate");
        public static WinFormsField EvtPeriodSta = new WinFormsField("EVT-PERIOD-STA", "EvtPeriodSta");
        public static WinFormsField EvtPeriodEnd = new WinFormsField("EVT-PERIOD-END", "EvtPeriodEnd");
        public static WinFormsField EvtElctnStaDT = new WinFormsField("EVT-ELCTN-STA-DT", "EvtElctnStaDT");
        public static WinFormsField EvtElctnEndDT = new WinFormsField("EVT-ELCTN-END-DT", "EvtElctnEndDT");
        public static WinFormsField ElectnStartHH = new WinFormsField("ELECTN-START-HH", "ElectnStartHH");
        public static WinFormsField ElectnStartMM = new WinFormsField("ELECTN-START-MM", "ElectnStartMM");
        public static WinFormsField ElectnClosingHH = new WinFormsField("ELECTN-CLOSING-HH", "ElectnClosingHH");
        public static WinFormsField EvtReconclStaDT = new WinFormsField("EVT-RECONCL-STA-DT", "EvtReconclStaDT");
        public static WinFormsField EvtReconclEndDT = new WinFormsField("EVT-RECONCL-END-DT", "EvtReconclEndDT");
        public static WinFormsField NtaxDspslChoice = new WinFormsField("NTAX-DSPSL-CHOICE", "NtaxDspslChoice");
        public static WinFormsField AlwdNtaxDspsls = new WinFormsField("ALWD-NTAX-DSPSLS", "AlwdNtaxDspsls");
        public static WinFormsField DfltNtxDspslchoic = new WinFormsField("DFLT-NTX-DSPSLCHOIC", "DfltNtxDspslchoic");
        public static WinFormsField NtxEXMethod = new WinFormsField("NTX-EX-METHOD", "NtxEXMethod");
        public static WinFormsField TaxDspslChoice = new WinFormsField("TAX-DSPSL-CHOICE", "TaxDspslChoice");
        public static WinFormsField AlwdTaxDspsls = new WinFormsField("ALWD-TAX-DSPSLS", "AlwdTaxDspsls");
        public static WinFormsField DfltTaxDspslchoic = new WinFormsField("DFLT-TAX-DSPSLCHOIC", "DfltTaxDspslchoic");
        public static WinFormsField TaxEXMethod = new WinFormsField("TAX-EX-METHOD", "TaxEXMethod");
        public static WinFormsField AlowdPaytMethod = new WinFormsField("ALOWD-PAYT-METHOD", "AlowdPaytMethod");
        public static WinFormsField DfltPaytMethod = new WinFormsField("DFLT-PAYT-METHOD", "DfltPaytMethod");
        public static WinFormsField WebElectionsInd = new WinFormsField("WEB-ELECTIONS-IND", "WebElectionsInd");
        public static WinFormsField TaxJurisdiction = new WinFormsField("TAX-JURISDICTION", "TaxJurisdiction");
        public static WinFormsField CmplxTXScnrioInd = new WinFormsField("CMPLX-TX-SCNRIO-IND", "CmplxTXScnrioInd");
        public static WinFormsField ElectionConfInd = new WinFormsField("ELECTION-CONF-IND", "ElectionConfInd");
        public static WinFormsField MultiLangSuppFlg = new WinFormsField("MULTI-LANG-SUPP-FLG", "MultiLangSuppFlg");
        public static WinFormsField CustomTemplateFlg = new WinFormsField("CUSTOM-TEMPLATE-FLG", "CustomTemplateFlg");
        public static WinFormsField ConfTemplateName = new WinFormsField("CONF-TEMPLATE-NAME", "ConfTemplateName");
        public static WinFormsField ConfComments = new WinFormsField("CONF-COMMENTS", "ConfComments");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
