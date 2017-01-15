using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class REPCTL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("REPCTL01", "FormName");
		//Fields


        public static WinFormsField RepctlKey0 = new WinFormsField("REPCTL-KEY0", "RepctlKey0");
        public static WinFormsField TransSeqType = new WinFormsField("TRANS-SEQ-TYPE", "TransSeqType");
        public static WinFormsField TransSeqRest = new WinFormsField("TRANS-SEQ-REST", "TransSeqRest");
        public static WinFormsField PidParameter = new WinFormsField("PID-PARAMETER", "PidParameter");
        public static WinFormsField AcknowledgedFlag = new WinFormsField("ACKNOWLEDGED-FLAG", "AcknowledgedFlag");
        public static WinFormsField CompanyAsx = new WinFormsField("COMPANY-ASX", "CompanyAsx");
        public static WinFormsField HinParameter = new WinFormsField("HIN-PARAMETER", "HinParameter");
        public static WinFormsField CancelledFlag = new WinFormsField("CANCELLED-FLAG", "CancelledFlag");
        public static WinFormsField ClassAsx = new WinFormsField("CLASS-ASX", "ClassAsx");
        public static WinFormsField TkoCode = new WinFormsField("TKO-CODE", "TkoCode");
        public static WinFormsField ProcessedFlag = new WinFormsField("PROCESSED-FLAG", "ProcessedFlag");
        public static WinFormsField CorpAction = new WinFormsField("CORP-ACTION", "CorpAction");
        public static WinFormsField PositionType = new WinFormsField("POSITION-TYPE", "PositionType");
        public static WinFormsField RspprmFilename = new WinFormsField("RSPPRM-FILENAME", "RspprmFilename");
        public static WinFormsField StartDate = new WinFormsField("START-DATE", "StartDate");
        public static WinFormsField ReportReason = new WinFormsField("REPORT-REASON", "ReportReason");
        public static WinFormsField EndDate = new WinFormsField("END-DATE", "EndDate");
        public static WinFormsField ReportingStartDate = new WinFormsField("REPORTING-START-DATE", "ReportingStartDate");
        public static WinFormsField ASATDate = new WinFormsField("AS-AT-DATE", "ASATDate");
        public static WinFormsField ReportingEndDate = new WinFormsField("REPORTING-END-DATE", "ReportingEndDate");
        public static WinFormsField EXDate = new WinFormsField("EX-DATE", "EXDate");
        public static WinFormsField ReportingID = new WinFormsField("REPORTING-ID", "ReportingID");
        public static WinFormsField NumberDays = new WinFormsField("NUMBER-DAYS", "NumberDays");
        public static WinFormsField ReportIDParam = new WinFormsField("REPORT-ID-PARAM", "ReportIDParam");
        public static WinFormsField RepTransactionID = new WinFormsField("REP-TRANSACTION-ID", "RepTransactionID");
        public static WinFormsField RejectedReason = new WinFormsField("REJECTED-REASON", "RejectedReason");
        public static WinFormsField ProcessingPeriod = new WinFormsField("PROCESSING-PERIOD", "ProcessingPeriod");
        public static WinFormsField ProcessingDay = new WinFormsField("PROCESSING-DAY", "ProcessingDay");
        public static WinFormsField DateLastProcessed = new WinFormsField("DATE-LAST-PROCESSED", "DateLastProcessed");
        public static WinFormsField SubpositionType = new WinFormsField("SUBPOSITION-TYPE", "SubpositionType");
        public static WinFormsField ProcessingFrequency = new WinFormsField("PROCESSING-FREQUENCY", "ProcessingFrequency");
        public static WinFormsField DateSent = new WinFormsField("DATE-SENT", "DateSent");
        public static WinFormsField PaymentFacility = new WinFormsField("PAYMENT-FACILITY", "PaymentFacility");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
