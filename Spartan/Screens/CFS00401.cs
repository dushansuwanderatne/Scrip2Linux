using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS00401

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS00401", "FormName");
		//Fields


        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField CompanyUfdsel = new WinFormsField("COMPANY-UFDSEL", "CompanyUfdsel");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField BatchQueue = new WinFormsField("BATCH-QUEUE", "BatchQueue");
        public static WinFormsField BillingClient = new WinFormsField("BILLING-CLIENT", "BillingClient");
        public static WinFormsField CompanyType = new WinFormsField("COMPANY-TYPE", "CompanyType");
        public static WinFormsField CompanySubTypeInd = new WinFormsField("COMPANY-SUB-TYPE-IND", "CompanySubTypeInd");
        public static WinFormsField BusinessDate = new WinFormsField("BUSINESS-DATE", "BusinessDate");
        public static WinFormsField DivsPer2years = new WinFormsField("DIVS-PER-2YEARS", "DivsPer2years");
        public static WinFormsField StopCoyServerFlag = new WinFormsField("STOP-COY-SERVER-FLAG", "StopCoyServerFlag");
        public static WinFormsField HolderMaintIncrease = new WinFormsField("HOLDER-MAINT-INCREASE", "HolderMaintIncrease");
        public static WinFormsField CoyBeingTkoInd = new WinFormsField("COY-BEING-TKO-IND", "CoyBeingTkoInd");
        public static WinFormsField HolderMaintRedctn = new WinFormsField("HOLDER-MAINT-REDCTN", "HolderMaintRedctn");
        public static WinFormsField DirectorReportInd = new WinFormsField("DIRECTOR-REPORT-IND", "DirectorReportInd");
        public static WinFormsField TransactionRedctn = new WinFormsField("TRANSACTION-REDCTN", "TransactionRedctn");
        public static WinFormsField CoyNonCharge = new WinFormsField("COY-NON-CHARGE", "CoyNonCharge");
        public static WinFormsField OptimizeFlag = new WinFormsField("OPTIMIZE-FLAG", "OptimizeFlag");
        public static WinFormsField RestrictFlag = new WinFormsField("RESTRICT-FLAG", "RestrictFlag");
        public static WinFormsField CompanyTypeInd = new WinFormsField("COMPANY-TYPE-IND", "CompanyTypeInd");
        public static WinFormsField AltPrnArea = new WinFormsField("ALT-PRN-AREA", "AltPrnArea");
        public static WinFormsField CompanyNumber = new WinFormsField("COMPANY-NUMBER", "CompanyNumber");
        public static WinFormsField GlobalEnabledInd = new WinFormsField("GLOBAL-ENABLED-IND", "GlobalEnabledInd");
        public static WinFormsField ChessAic = new WinFormsField("CHESS-AIC", "ChessAic");
        public static WinFormsField WorkflowAuditInd = new WinFormsField("WORKFLOW-AUDIT-IND", "WorkflowAuditInd");
        public static WinFormsField IcrEnabledInd = new WinFormsField("ICR-ENABLED-IND", "IcrEnabledInd");
        public static WinFormsField AspReleaseUrrInd = new WinFormsField("ASP-RELEASE-URR-IND", "AspReleaseUrrInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SearchClient = new WinFormsField("SEARCH-CLIENT", "SearchClient");
        public static WinFormsField SearchUfdsel = new WinFormsField("SEARCH-UFDSEL", "SearchUfdsel");
    }
}
