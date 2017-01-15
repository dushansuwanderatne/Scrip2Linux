using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class COYCDE01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("COYCDE01", "FormName");
		//Fields


        public static WinFormsField CoycdeKey0 = new WinFormsField("COYCDE-KEY0", "CoycdeKey0");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField JobSubmitFlag = new WinFormsField("JOB-SUBMIT-FLAG", "JobSubmitFlag");
        public static WinFormsField CompanyUfdsel = new WinFormsField("COMPANY-UFDSEL", "CompanyUfdsel");
        public static WinFormsField ChessCompanyStatus = new WinFormsField("CHESS-COMPANY-STATUS", "ChessCompanyStatus");
        public static WinFormsField AtoInvestmentNbr = new WinFormsField("ATO-INVESTMENT-NBR", "AtoInvestmentNbr");
        public static WinFormsField ChessUic = new WinFormsField("CHESS-UIC", "ChessUic");
        public static WinFormsField BatchQueue = new WinFormsField("BATCH-QUEUE", "BatchQueue");
        public static WinFormsField ChessAic = new WinFormsField("CHESS-AIC", "ChessAic");
        public static WinFormsField CompanyType = new WinFormsField("COMPANY-TYPE", "CompanyType");
        public static WinFormsField ChessConversionDate = new WinFormsField("CHESS-CONVERSION-DATE", "ChessConversionDate");
        public static WinFormsField BusinessDate = new WinFormsField("BUSINESS-DATE", "BusinessDate");
        public static WinFormsField ChessStatus = new WinFormsField("CHESS-STATUS", "ChessStatus");
        public static WinFormsField CompanyTypeInd = new WinFormsField("COMPANY-TYPE-IND", "CompanyTypeInd");
        public static WinFormsField UncertificatedInd = new WinFormsField("UNCERTIFICATED-IND", "UncertificatedInd");
        public static WinFormsField CertificatedInd = new WinFormsField("CERTIFICATED-IND", "CertificatedInd");
        public static WinFormsField WorkflowAuditInd = new WinFormsField("WORKFLOW-AUDIT-IND", "WorkflowAuditInd");
        public static WinFormsField RestrictFlag = new WinFormsField("RESTRICT-FLAG", "RestrictFlag");
        public static WinFormsField StopCoyServerFlag = new WinFormsField("STOP-COY-SERVER-FLAG", "StopCoyServerFlag");
        public static WinFormsField CoyBeingTkoInd = new WinFormsField("COY-BEING-TKO-IND", "CoyBeingTkoInd");
        public static WinFormsField AltPrnArea = new WinFormsField("ALT-PRN-AREA", "AltPrnArea");
        public static WinFormsField CrestStatus = new WinFormsField("CREST-STATUS", "CrestStatus");
        public static WinFormsField CrestReconStatus = new WinFormsField("CREST-RECON-STATUS", "CrestReconStatus");
        public static WinFormsField CrestBadDeliverInd = new WinFormsField("CREST-BAD-DELIVER-IND", "CrestBadDeliverInd");
        public static WinFormsField GlobalRepEnabledInd = new WinFormsField("GLOBAL-REP-ENABLED-IND", "GlobalRepEnabledInd");
        public static WinFormsField ScripSubType = new WinFormsField("SCRIP-SUB-TYPE", "ScripSubType");
        public static WinFormsField DirectorReportInd = new WinFormsField("DIRECTOR-REPORT-IND", "DirectorReportInd");
        public static WinFormsField UnlistedTrustInd = new WinFormsField("UNLISTED-TRUST-IND", "UnlistedTrustInd");
        public static WinFormsField CompanyONDec = new WinFormsField("COMPANY-ON-DEC", "CompanyONDec");
        public static WinFormsField ForeignCharsInd = new WinFormsField("FOREIGN-CHARS-IND", "ForeignCharsInd");
        public static WinFormsField EmailAddressA = new WinFormsField("EMAIL-ADDRESS-A", "EmailAddressA");
        public static WinFormsField EmailAddressB = new WinFormsField("EMAIL-ADDRESS-B", "EmailAddressB");
        public static WinFormsField CoyNonCharge = new WinFormsField("COY-NON-CHARGE", "CoyNonCharge");
        public static WinFormsField DivsPer2years = new WinFormsField("DIVS-PER-2YEARS", "DivsPer2years");
        public static WinFormsField HolderMaintRedctn = new WinFormsField("HOLDER-MAINT-REDCTN", "HolderMaintRedctn");
        public static WinFormsField HolderMaintIncrease = new WinFormsField("HOLDER-MAINT-INCREASE", "HolderMaintIncrease");
        public static WinFormsField TransactionRedctn = new WinFormsField("TRANSACTION-REDCTN", "TransactionRedctn");
        public static WinFormsField BillingClient = new WinFormsField("BILLING-CLIENT", "BillingClient");
        public static WinFormsField HolderOrigin = new WinFormsField("HOLDER-ORIGIN", "HolderOrigin");
        public static WinFormsField OriginStatus = new WinFormsField("ORIGIN-STATUS", "OriginStatus");
        public static WinFormsField CosmosUploadInd = new WinFormsField("COSMOS-UPLOAD-IND", "CosmosUploadInd");
        public static WinFormsField LstRunCosmosUpload = new WinFormsField("LST-RUN-COSMOS-UPLOAD", "LstRunCosmosUpload");
        public static WinFormsField LstTransCosmosUpload = new WinFormsField("LST-TRANS-COSMOS-UPLOAD", "LstTransCosmosUpload");
        public static WinFormsField LstRecCosmosUpload = new WinFormsField("LST-REC-COSMOS-UPLOAD", "LstRecCosmosUpload");
        public static WinFormsField FasterScriplessNbr = new WinFormsField("FASTER-SCRIPLESS-NBR", "FasterScriplessNbr");
        public static WinFormsField CompanyNumber = new WinFormsField("COMPANY-NUMBER", "CompanyNumber");
        public static WinFormsField NodeName = new WinFormsField("NODE-NAME", "NodeName");
        public static WinFormsField IcrEnabledInd = new WinFormsField("ICR-ENABLED-IND", "IcrEnabledInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
