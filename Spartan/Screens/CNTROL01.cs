using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CNTROL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CNTROL01", "FormName");
		//Fields


        public static WinFormsField CntrolKey0 = new WinFormsField("CNTROL-KEY0", "CntrolKey0");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField ClientName = new WinFormsField("CLIENT-NAME", "ClientName");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField CompanyStatusFlag = new WinFormsField("COMPANY-STATUS-FLAG", "CompanyStatusFlag");
        public static WinFormsField LastHolderNumber = new WinFormsField("LAST-HOLDER-NUMBER", "LastHolderNumber");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField SessionNumber = new WinFormsField("SESSION-NUMBER", "SessionNumber");
        public static WinFormsField CompanyCountry = new WinFormsField("COMPANY-COUNTRY", "CompanyCountry");
        public static WinFormsField PrincipalRegister = new WinFormsField("PRINCIPAL-REGISTER", "PrincipalRegister");
        public static WinFormsField VarFlag1Opt = new WinFormsField("VAR-FLAG-1-OPT", "VarFlag1Opt");
        public static WinFormsField VarFlag2Opt = new WinFormsField("VAR-FLAG-2-OPT", "VarFlag2Opt");
        public static WinFormsField AcnArbnType = new WinFormsField("ACN-ARBN-TYPE", "AcnArbnType");
        public static WinFormsField AustralianCoyNumber = new WinFormsField("AUSTRALIAN-COY-NUMBER", "AustralianCoyNumber");
        public static WinFormsField PreviousUfdname = new WinFormsField("PREVIOUS-UFDNAME", "PreviousUfdname");
        public static WinFormsField AmcPeriodMmyy = new WinFormsField("AMC-PERIOD-MMYY", "AmcPeriodMmyy");
        public static WinFormsField CompanySin = new WinFormsField("COMPANY-SIN", "CompanySin");
        public static WinFormsField LastSinsHin = new WinFormsField("LAST-SINS-HIN", "LastSinsHin");
        public static WinFormsField LastBulkNbr = new WinFormsField("LAST-BULK-NBR", "LastBulkNbr");
        public static WinFormsField StateTaxLodgement = new WinFormsField("STATE-TAX-LODGEMENT", "StateTaxLodgement");
        public static WinFormsField AtoWithholdTaxNumber = new WinFormsField("ATO-WITHHOLD-TAX-NUMBER", "AtoWithholdTaxNumber");
        public static WinFormsField NsnFormName = new WinFormsField("NSN-FORM-NAME", "NsnFormName");
        public static WinFormsField NonResAll = new WinFormsField("NON-RES-ALL", "NonResAll");
        public static WinFormsField MergeNoticeOption = new WinFormsField("MERGE-NOTICE-OPTION", "MergeNoticeOption");
        public static WinFormsField KeepDivhisFlag = new WinFormsField("KEEP-DIVHIS-FLAG", "KeepDivhisFlag");
        public static WinFormsField AutoNsn = new WinFormsField("AUTO-NSN", "AutoNsn");
        public static WinFormsField AutoAcknowledge = new WinFormsField("AUTO-ACKNOWLEDGE", "AutoAcknowledge");
        public static WinFormsField IndividualTax = new WinFormsField("INDIVIDUAL-TAX", "IndividualTax");
        public static WinFormsField ChangeNoticeOption = new WinFormsField("CHANGE-NOTICE-OPTION", "ChangeNoticeOption");
        public static WinFormsField UnitTrustCompanyFlag = new WinFormsField("UNIT-TRUST-COMPANY-FLAG", "UnitTrustCompanyFlag");
        public static WinFormsField AutoFast = new WinFormsField("AUTO-FAST", "AutoFast");
        public static WinFormsField AutoPdfOption = new WinFormsField("AUTO-PDF-OPTION", "AutoPdfOption");
        public static WinFormsField NonStandardTax = new WinFormsField("NON-STANDARD-TAX", "NonStandardTax");
        public static WinFormsField ScripSequence = new WinFormsField("SCRIP-SEQUENCE", "ScripSequence");
        public static WinFormsField FloatModeInd = new WinFormsField("FLOAT-MODE-IND", "FloatModeInd");
        public static WinFormsField ResTaxDeducted = new WinFormsField("RES-TAX-DEDUCTED", "ResTaxDeducted");
        public static WinFormsField StatDecFlag = new WinFormsField("STAT-DEC-FLAG", "StatDecFlag");
        public static WinFormsField CompanyTax = new WinFormsField("COMPANY-TAX", "CompanyTax");
        public static WinFormsField OSSequenceOption = new WinFormsField("OS-SEQUENCE-OPTION", "OSSequenceOption");
        public static WinFormsField FullyUncertificatedInd = new WinFormsField("FULLY-UNCERTIFICATED-IND", "FullyUncertificatedInd");
        public static WinFormsField DrpBspAcknowlege = new WinFormsField("DRP-BSP-ACKNOWLEGE", "DrpBspAcknowlege");
        public static WinFormsField DividendAcknowlege = new WinFormsField("DIVIDEND-ACKNOWLEGE", "DividendAcknowlege");
        public static WinFormsField AtoIdentifierType = new WinFormsField("ATO-IDENTIFIER-TYPE", "AtoIdentifierType");
        public static WinFormsField ScripListNAFormat = new WinFormsField("SCRIP-LIST-NA-FORMAT", "ScripListNAFormat");
        public static WinFormsField RestrictSEAccessInd = new WinFormsField("RESTRICT-SE-ACCESS-IND", "RestrictSEAccessInd");
        public static WinFormsField LastTrajnlSeqnum = new WinFormsField("LAST-TRAJNL-SEQNUM", "LastTrajnlSeqnum");
        public static WinFormsField ChkdgtModulus = new WinFormsField("CHKDGT-MODULUS", "ChkdgtModulus");
        public static WinFormsField RetainHldTrans = new WinFormsField("RETAIN-HLD-TRANS", "RetainHldTrans");
        public static WinFormsField PinsAllocated = new WinFormsField("PINS-ALLOCATED", "PinsAllocated");
        public static WinFormsField LastTrajnlRun = new WinFormsField("LAST-TRAJNL-RUN", "LastTrajnlRun");
        public static WinFormsField NewshnOption = new WinFormsField("NEWSHN-OPTION", "NewshnOption");
        public static WinFormsField RetainAid = new WinFormsField("RETAIN-AID", "RetainAid");
        public static WinFormsField EomLastFromRun = new WinFormsField("EOM-LAST-FROM-RUN", "EomLastFromRun");
        public static WinFormsField LastDiasRun = new WinFormsField("LAST-DIAS-RUN", "LastDiasRun");
        public static WinFormsField NsnFormatNumber = new WinFormsField("NSN-FORMAT-NUMBER", "NsnFormatNumber");
        public static WinFormsField BrokerAnalysisOption = new WinFormsField("BROKER-ANALYSIS-OPTION", "BrokerAnalysisOption");
        public static WinFormsField EomLastTORun = new WinFormsField("EOM-LAST-TO-RUN", "EomLastTORun");
        public static WinFormsField InvestBodyEntType = new WinFormsField("INVEST-BODY-ENT-TYPE", "InvestBodyEntType");
        public static WinFormsField InvestBodyEntSubType = new WinFormsField("INVEST-BODY-ENT-SUB-TYPE", "InvestBodyEntSubType");
        public static WinFormsField OldFastEnable = new WinFormsField("OLD-FAST-ENABLE", "OldFastEnable");
        public static WinFormsField TfnEntryDisallowedInd = new WinFormsField("TFN-ENTRY-DISALLOWED-IND", "TfnEntryDisallowedInd");
        public static WinFormsField TfnImplemented = new WinFormsField("TFN-IMPLEMENTED", "TfnImplemented");
        public static WinFormsField TfnsEnteredInd = new WinFormsField("TFNS-ENTERED-IND", "TfnsEnteredInd");
        public static WinFormsField UpdateAutoForm = new WinFormsField("UPDATE-AUTO-FORM", "UpdateAutoForm");
        public static WinFormsField OldFasterEnable = new WinFormsField("OLD-FASTER-ENABLE", "OldFasterEnable");
        public static WinFormsField LtfnqrtRunFrom = new WinFormsField("LTFNQRT-RUN-FROM", "LtfnqrtRunFrom");
        public static WinFormsField LtfnqrtRunTO = new WinFormsField("LTFNQRT-RUN-TO", "LtfnqrtRunTO");
        public static WinFormsField LtfnqrtDateTO = new WinFormsField("LTFNQRT-DATE-TO", "LtfnqrtDateTO");
        public static WinFormsField ReferenceType = new WinFormsField("REFERENCE-TYPE", "ReferenceType");
        public static WinFormsField UpdateAutospool = new WinFormsField("UPDATE-AUTOSPOOL", "UpdateAutospool");
        public static WinFormsField UpdateAutoCopies = new WinFormsField("UPDATE-AUTO-COPIES", "UpdateAutoCopies");
        public static WinFormsField DualSiteFlag = new WinFormsField("DUAL-SITE-FLAG", "DualSiteFlag");
        public static WinFormsField RunDate = new WinFormsField("RUN-DATE", "RunDate");
        public static WinFormsField AdhocRunVersion = new WinFormsField("ADHOC-RUN-VERSION", "AdhocRunVersion");
        public static WinFormsField AdhocLogRecord = new WinFormsField("ADHOC-LOG-RECORD", "AdhocLogRecord");
        public static WinFormsField EisCompanyFlag = new WinFormsField("EIS-COMPANY-FLAG", "EisCompanyFlag");
        public static WinFormsField NspForRetradesInd = new WinFormsField("NSP-FOR-RETRADES-IND", "NspForRetradesInd");
        public static WinFormsField ReactivatedTolerance = new WinFormsField("REACTIVATED-TOLERANCE", "ReactivatedTolerance");
        public static WinFormsField ExcludeNightlyUrrInd = new WinFormsField("EXCLUDE-NIGHTLY-URR-IND", "ExcludeNightlyUrrInd");
        public static WinFormsField HldChgAppliesInd = new WinFormsField("HLD-CHG-APPLIES-IND", "HldChgAppliesInd");
        public static WinFormsField StopChqThresholdAmt = new WinFormsField("STOP-CHQ-THRESHOLD-AMT", "StopChqThresholdAmt");
        public static WinFormsField HldChgThresholdChqAmt = new WinFormsField("HLD-CHG-THRESHOLD-CHQ-AMT", "HldChgThresholdChqAmt");
        public static WinFormsField PreApprovalChqAmt = new WinFormsField("PRE-APPROVAL-CHQ-AMT", "PreApprovalChqAmt");
        public static WinFormsField HldChgThresholdDCAmt = new WinFormsField("HLD-CHG-THRESHOLD-DC-AMT", "HldChgThresholdDCAmt");
        public static WinFormsField PreApprovalDCAmt = new WinFormsField("PRE-APPROVAL-DC-AMT", "PreApprovalDCAmt");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
