using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSSTM10

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSSTM10", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField HolderNameAddress1 = new WinFormsField("HOLDER-NAME-ADDRESS1", "HolderNameAddress1");
        public static WinFormsField HolderNameAddress2 = new WinFormsField("HOLDER-NAME-ADDRESS2", "HolderNameAddress2");
        public static WinFormsField NewDecdJntID = new WinFormsField("NEW-DECD-JNT-ID", "NewDecdJntID");
        public static WinFormsField OldDecdJntStatus = new WinFormsField("OLD-DECD-JNT-STATUS", "OldDecdJntStatus");
        public static WinFormsField NewDecdJntStatus = new WinFormsField("NEW-DECD-JNT-STATUS", "NewDecdJntStatus");
        public static WinFormsField NewDecdJntName = new WinFormsField("NEW-DECD-JNT-NAME", "NewDecdJntName");
        public static WinFormsField DecdReportedDod = new WinFormsField("DECD-REPORTED-DOD", "DecdReportedDod");
        public static WinFormsField Salutation = new WinFormsField("SALUTATION", "Salutation");
        public static WinFormsField YourReference = new WinFormsField("YOUR-REFERENCE", "YourReference");
        public static WinFormsField RecdSuppliedName = new WinFormsField("RECD-SUPPLIED-NAME", "RecdSuppliedName");
        public static WinFormsField RecdDocCnfrmID = new WinFormsField("RECD-DOC-CNFRM-ID", "RecdDocCnfrmID");
        public static WinFormsField IntestacyDeclaration = new WinFormsField("INTESTACY-DECLARATION", "IntestacyDeclaration");
        public static WinFormsField RecdProbateST = new WinFormsField("RECD-PROBATE-ST", "RecdProbateST");
        public static WinFormsField JntDecdLegals = new WinFormsField("JNT-DECD-LEGALS", "JntDecdLegals");
        public static WinFormsField AustProbateReqd = new WinFormsField("AUST-PROBATE-REQD", "AustProbateReqd");
        public static WinFormsField NameAddrFormReqd = new WinFormsField("NAME-ADDR-FORM-REQD", "NameAddrFormReqd");
        public static WinFormsField SurvNameInitInd = new WinFormsField("SURV-NAME-INIT-IND", "SurvNameInitInd");
        public static WinFormsField RecdDCST = new WinFormsField("RECD-DC-ST", "RecdDCST");
        public static WinFormsField LocateHoldings = new WinFormsField("LOCATE-HOLDINGS", "LocateHoldings");
        public static WinFormsField CertReqdInd = new WinFormsField("CERT-REQD-IND", "CertReqdInd");
        public static WinFormsField RecdWillST = new WinFormsField("RECD-WILL-ST", "RecdWillST");
        public static WinFormsField SpecificPoaReqd = new WinFormsField("SPECIFIC-POA-REQD", "SpecificPoaReqd");
        public static WinFormsField PrintStopTradeInd = new WinFormsField("PRINT-STOP-TRADE-IND", "PrintStopTradeInd");
        public static WinFormsField RecdREProbST = new WinFormsField("RECD-RE-PROB-ST", "RecdREProbST");
        public static WinFormsField SrnInd = new WinFormsField("SRN-IND", "SrnInd");
        public static WinFormsField Recd121aST = new WinFormsField("RECD-121A-ST", "Recd121aST");
        public static WinFormsField TfnUpdatedInd = new WinFormsField("TFN-UPDATED-IND", "TfnUpdatedInd");
        public static WinFormsField DodValueInd = new WinFormsField("DOD-VALUE-IND", "DodValueInd");
        public static WinFormsField Recd1071bST = new WinFormsField("RECD-1071B-ST", "Recd1071bST");
        public static WinFormsField CgtInd = new WinFormsField("CGT-IND", "CgtInd");
        public static WinFormsField RecdSmallEstST = new WinFormsField("RECD-SMALL-EST-ST", "RecdSmallEstST");
        public static WinFormsField TransHistoryYears = new WinFormsField("TRANS-HISTORY-YEARS", "TransHistoryYears");
        public static WinFormsField RecdConfirmIDST = new WinFormsField("RECD-CONFIRM-ID-ST", "RecdConfirmIDST");
        public static WinFormsField CalcEstateSizeInd = new WinFormsField("CALC-ESTATE-SIZE-IND", "CalcEstateSizeInd");
        public static WinFormsField PaymentHistYears = new WinFormsField("PAYMENT-HIST-YEARS", "PaymentHistYears");
        public static WinFormsField AllLegalsRecdInd = new WinFormsField("ALL-LEGALS-RECD-IND", "AllLegalsRecdInd");
        public static WinFormsField EstateSizeInd = new WinFormsField("ESTATE-SIZE-IND", "EstateSizeInd");
        public static WinFormsField PrintReceiptInd = new WinFormsField("PRINT-RECEIPT-IND", "PrintReceiptInd");
        public static WinFormsField OspRequestedInd = new WinFormsField("OSP-REQUESTED-IND", "OspRequestedInd");
        public static WinFormsField FwdinsTOApplyInd = new WinFormsField("FWDINS-TO-APPLY-IND", "FwdinsTOApplyInd");
        public static WinFormsField DateFirstRegInd = new WinFormsField("DATE-FIRST-REG-IND", "DateFirstRegInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField PayInstrInd = new WinFormsField("PAY-INSTR-IND", "PayInstrInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
