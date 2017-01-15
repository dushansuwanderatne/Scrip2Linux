using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSEVT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSEVT01", "FormName");
		//Fields


        public static WinFormsField EventType = new WinFormsField("EVENT-TYPE", "EventType");
        public static WinFormsField EventCurrentInd = new WinFormsField("EVENT-CURRENT-IND", "EventCurrentInd");
        public static WinFormsField EventClosedInd = new WinFormsField("EVENT-CLOSED-IND", "EventClosedInd");
        public static WinFormsField EventCode = new WinFormsField("EVENT-CODE", "EventCode");
        public static WinFormsField EventCommMethod = new WinFormsField("EVENT-COMM-METHOD", "EventCommMethod");
        public static WinFormsField EventDate = new WinFormsField("EVENT-DATE", "EventDate");
        public static WinFormsField AllowdElectionChannel = new WinFormsField("ALLOWD-ELECTION-CHANNEL", "AllowdElectionChannel");
        public static WinFormsField EventPeriodStart = new WinFormsField("EVENT-PERIOD-START", "EventPeriodStart");
        public static WinFormsField EventPeriodEnd = new WinFormsField("EVENT-PERIOD-END", "EventPeriodEnd");
        public static WinFormsField ElectnStartHH = new WinFormsField("ELECTN-START-HH", "ElectnStartHH");
        public static WinFormsField ElectnStartMM = new WinFormsField("ELECTN-START-MM", "ElectnStartMM");
        public static WinFormsField EventNotificationDate = new WinFormsField("EVENT-NOTIFICATION-DATE", "EventNotificationDate");
        public static WinFormsField ElectnCutoffHH = new WinFormsField("ELECTN-CUTOFF-HH", "ElectnCutoffHH");
        public static WinFormsField ElectnCutoffMM = new WinFormsField("ELECTN-CUTOFF-MM", "ElectnCutoffMM");
        public static WinFormsField EventElectnPeriodInd = new WinFormsField("EVENT-ELECTN-PERIOD-IND", "EventElectnPeriodInd");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField EventElectnStaDate = new WinFormsField("EVENT-ELECTN-STA-DATE", "EventElectnStaDate");
        public static WinFormsField EventElectnEndDate = new WinFormsField("EVENT-ELECTN-END-DATE", "EventElectnEndDate");
        public static WinFormsField AmendmentIndicator = new WinFormsField("AMENDMENT-INDICATOR", "AmendmentIndicator");
        public static WinFormsField EventReconcileStaDate = new WinFormsField("EVENT-RECONCILE-STA-DATE", "EventReconcileStaDate");
        public static WinFormsField EventReconcileEndDate = new WinFormsField("EVENT-RECONCILE-END-DATE", "EventReconcileEndDate");
        public static WinFormsField HolderSelectionInd = new WinFormsField("HOLDER-SELECTION-IND", "HolderSelectionInd");
        public static WinFormsField EventApplicationDate = new WinFormsField("EVENT-APPLICATION-DATE", "EventApplicationDate");
        public static WinFormsField IncludeLeaversInd = new WinFormsField("INCLUDE-LEAVERS-IND", "IncludeLeaversInd");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField IncludeBlkoutHldrsInd = new WinFormsField("INCLUDE-BLKOUT-HLDRS-IND", "IncludeBlkoutHldrsInd");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterType = new WinFormsField("REGISTER-TYPE", "RegisterType");
        public static WinFormsField DefaultBulkCode = new WinFormsField("DEFAULT-BULK-CODE", "DefaultBulkCode");
        public static WinFormsField DefaultXferCode = new WinFormsField("DEFAULT-XFER-CODE", "DefaultXferCode");
        public static WinFormsField TaxDisposalChoice = new WinFormsField("TAX-DISPOSAL-CHOICE", "TaxDisposalChoice");
        public static WinFormsField NtaxDisposalChoice = new WinFormsField("NTAX-DISPOSAL-CHOICE", "NtaxDisposalChoice");
        public static WinFormsField DfltTaxDispslChoice = new WinFormsField("DFLT-TAX-DISPSL-CHOICE", "DfltTaxDispslChoice");
        public static WinFormsField DfltNtaxDispslChoice = new WinFormsField("DFLT-NTAX-DISPSL-CHOICE", "DfltNtaxDispslChoice");
        public static WinFormsField TaxRateApplicableInd = new WinFormsField("TAX-RATE-APPLICABLE-IND", "TaxRateApplicableInd");
        public static WinFormsField AllowedPaymentMethod = new WinFormsField("ALLOWED-PAYMENT-METHOD", "AllowedPaymentMethod");
        public static WinFormsField CmplctdTaxScenarioInd = new WinFormsField("CMPLCTD-TAX-SCENARIO-IND", "CmplctdTaxScenarioInd");
        public static WinFormsField DefaultPaymentMethod = new WinFormsField("DEFAULT-PAYMENT-METHOD", "DefaultPaymentMethod");
        public static WinFormsField TaxJurisdiction = new WinFormsField("TAX-JURISDICTION", "TaxJurisdiction");
        public static WinFormsField DfltRblDispslChoice = new WinFormsField("DFLT-RBL-DISPSL-CHOICE", "DfltRblDispslChoice");
        public static WinFormsField WebElectionsInd = new WinFormsField("WEB-ELECTIONS-IND", "WebElectionsInd");
        public static WinFormsField ConsolidatePaymentsInd = new WinFormsField("CONSOLIDATE-PAYMENTS-IND", "ConsolidatePaymentsInd");
        public static WinFormsField ElectionConfInd = new WinFormsField("ELECTION-CONF-IND", "ElectionConfInd");
        public static WinFormsField MultiLangSuppFlg = new WinFormsField("MULTI-LANG-SUPP-FLG", "MultiLangSuppFlg");
        public static WinFormsField CustomTemplateFlg = new WinFormsField("CUSTOM-TEMPLATE-FLG", "CustomTemplateFlg");
        public static WinFormsField ConfTemplateName = new WinFormsField("CONF-TEMPLATE-NAME", "ConfTemplateName");
        public static WinFormsField ConfComments = new WinFormsField("CONF-COMMENTS", "ConfComments");
        public static WinFormsField NtxEXMethod = new WinFormsField("NTX-EX-METHOD", "NtxEXMethod");
        public static WinFormsField TaxEXMethod = new WinFormsField("TAX-EX-METHOD", "TaxEXMethod");
        public static WinFormsField TaxEventPointFlg = new WinFormsField("TAX-EVENT-POINT-FLG", "TaxEventPointFlg");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
