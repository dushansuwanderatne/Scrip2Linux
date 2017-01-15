using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HLDADD01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HLDADD01", "FormName");
		//Fields
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField Dpid = new WinFormsField("DPID", "Dpid");
        public static WinFormsField HstDeceased = new WinFormsField("HST-DECEASED", "HstDeceased");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderOtherTaxCode = new WinFormsField("HOLDER-OTHER-TAX-CODE", "HolderOtherTaxCode");
        public static WinFormsField HstException = new WinFormsField("HST-EXCEPTION", "HstException");
        public static WinFormsField HolderGroupCode = new WinFormsField("HOLDER-GROUP-CODE", "HolderGroupCode");
        public static WinFormsField HstSuppress = new WinFormsField("HST-SUPPRESS", "HstSuppress");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField HstStopTrade = new WinFormsField("HST-STOP-TRADE", "HstStopTrade");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField HstAnnualReport = new WinFormsField("HST-ANNUAL-REPORT", "HstAnnualReport");
        public static WinFormsField HolderKeyModifier = new WinFormsField("HOLDER-KEY-MODIFIER", "HolderKeyModifier");
        public static WinFormsField ARNominatedInd = new WinFormsField("AR-NOMINATED-IND", "ARNominatedInd");
        public static WinFormsField HstDividendIntent = new WinFormsField("HST-DIVIDEND-INTENT", "HstDividendIntent");
        public static WinFormsField VariableField = new WinFormsField("VARIABLE-FIELD", "VariableField");
        public static WinFormsField FirstTradeThisRun = new WinFormsField("1ST-TRADE-THIS-RUN", "1stTradeThisRun");
        public static WinFormsField HolderAlternateID = new WinFormsField("HOLDER-ALTERNATE-ID", "HolderAlternateID");
        public static WinFormsField ResidencyInd = new WinFormsField("RESIDENCY-IND", "ResidencyInd");
        public static WinFormsField RunHolderAdded = new WinFormsField("RUN-HOLDER-ADDED", "RunHolderAdded");
        public static WinFormsField HolderCrtDumprun = new WinFormsField("HOLDER-CRT-DUMPRUN", "HolderCrtDumprun");
        public static WinFormsField HolderONDate = new WinFormsField("HOLDER-ON-DATE", "HolderONDate");
        public static WinFormsField HolderPayDumprun = new WinFormsField("HOLDER-PAY-DUMPRUN", "HolderPayDumprun");
        public static WinFormsField HolderOffDate = new WinFormsField("HOLDER-OFF-DATE", "HolderOffDate");
        public static WinFormsField RunLastChange = new WinFormsField("RUN-LAST-CHANGE", "RunLastChange");
        public static WinFormsField AddressNameKey = new WinFormsField("ADDRESS-NAME-KEY", "AddressNameKey");
        public static WinFormsField HsyNoteFlag = new WinFormsField("HSY-NOTE-FLAG", "HsyNoteFlag");
        public static WinFormsField FltBatchNumber = new WinFormsField("FLT-BATCH-NUMBER", "FltBatchNumber");
        public static WinFormsField HsyWireFlag = new WinFormsField("HSY-WIRE-FLAG", "HsyWireFlag");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField HsyDrpFlag = new WinFormsField("HSY-DRP-FLAG", "HsyDrpFlag");
        public static WinFormsField PinNumber = new WinFormsField("PIN-NUMBER", "PinNumber");
        public static WinFormsField HvfFlag = new WinFormsField("HVF-FLAG", "HvfFlag");
        public static WinFormsField HsyPayeeFlag = new WinFormsField("HSY-PAYEE-FLAG", "HsyPayeeFlag");
        public static WinFormsField HolderAddedDate = new WinFormsField("HOLDER-ADDED-DATE", "HolderAddedDate");
        public static WinFormsField UncertificatedType = new WinFormsField("UNCERTIFICATED-TYPE", "UncertificatedType");
        public static WinFormsField HsySpecialFlag = new WinFormsField("HSY-SPECIAL-FLAG", "HsySpecialFlag");
        public static WinFormsField HolderVersionNbr = new WinFormsField("HOLDER-VERSION-NBR", "HolderVersionNbr");
        public static WinFormsField JointTfn1 = new WinFormsField("JOINT-TFN-1", "JointTfn1");
        public static WinFormsField Tfn = new WinFormsField("TFN", "Tfn");
        public static WinFormsField ChessHolderStatus = new WinFormsField("CHESS-HOLDER-STATUS", "ChessHolderStatus");
        public static WinFormsField HsyMergeFlag = new WinFormsField("HSY-MERGE-FLAG", "HsyMergeFlag");
        public static WinFormsField RunTfnChange = new WinFormsField("RUN-TFN-CHANGE", "RunTfnChange");
        public static WinFormsField JointTfn2 = new WinFormsField("JOINT-TFN-2", "JointTfn2");
        public static WinFormsField MailUnclaimedDate = new WinFormsField("MAIL-UNCLAIMED-DATE", "MailUnclaimedDate");
        public static WinFormsField OriginHolderID = new WinFormsField("ORIGIN-HOLDER-ID", "OriginHolderID");
        public static WinFormsField RunHolderWentForeign = new WinFormsField("RUN-HOLDER-WENT-FOREIGN", "RunHolderWentForeign");
        public static WinFormsField CIUploadInd = new WinFormsField("CI-UPLOAD-IND", "CIUploadInd");
        public static WinFormsField BirthDate1 = new WinFormsField("BIRTH-DATE-1", "BirthDate1");
        public static WinFormsField BirthDate2 = new WinFormsField("BIRTH-DATE-2", "BirthDate2");
        public static WinFormsField BirthDate3 = new WinFormsField("BIRTH-DATE-3", "BirthDate3");
        public static WinFormsField HsyEmailEnabledFlag = new WinFormsField("HSY-EMAIL-ENABLED-FLAG", "HsyEmailEnabledFlag");
        public static WinFormsField HsyTaxStatusFlag = new WinFormsField("HSY-TAX-STATUS-FLAG", "HsyTaxStatusFlag");
        public static WinFormsField HolderAccessCode = new WinFormsField("HOLDER-ACCESS-CODE", "HolderAccessCode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
