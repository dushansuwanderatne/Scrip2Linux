using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CNV03002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CNV03002", "FormName");
		//Fields


        public static WinFormsField CompanyID = new WinFormsField("COMPANY-ID", "CompanyID");
        public static WinFormsField RecordType = new WinFormsField("RECORD-TYPE", "RecordType");
        public static WinFormsField ForeignCodeX9 = new WinFormsField("FOREIGN-CODE-X9", "ForeignCodeX9");
        public static WinFormsField DescriptionO1to30 = new WinFormsField("DESCRIPTION-O1TO30", "DescriptionO1to30");
        public static WinFormsField MigrateInd = new WinFormsField("MIGRATE-IND", "MigrateInd");
        public static WinFormsField Cusip = new WinFormsField("CUSIP", "Cusip");
        public static WinFormsField Symbol = new WinFormsField("SYMBOL", "Symbol");
        public static WinFormsField ExchangeCode = new WinFormsField("EXCHANGE-CODE", "ExchangeCode");
        public static WinFormsField ScripCodeX3 = new WinFormsField("SCRIP-CODE-X3", "ScripCodeX3");
        public static WinFormsField ClassType = new WinFormsField("CLASS-TYPE", "ClassType");
        public static WinFormsField AssocPlanClass = new WinFormsField("ASSOC-PLAN-CLASS", "AssocPlanClass");
        public static WinFormsField PlanID = new WinFormsField("PLAN-ID", "PlanID");
        public static WinFormsField EssSecurityInd = new WinFormsField("ESS-SECURITY-IND", "EssSecurityInd");
        public static WinFormsField CusipQualified423 = new WinFormsField("CUSIP-QUALIFIED-423", "CusipQualified423");
        public static WinFormsField ReorgFractionClass = new WinFormsField("REORG-FRACTION-CLASS", "ReorgFractionClass");
        public static WinFormsField NciInd = new WinFormsField("NCI-IND", "NciInd");
        public static WinFormsField FastIssueInd = new WinFormsField("FAST-ISSUE-IND", "FastIssueInd");
        public static WinFormsField NsnInd = new WinFormsField("NSN-IND", "NsnInd");
        public static WinFormsField NbrDecimalsX = new WinFormsField("NBR-DECIMALS-X", "NbrDecimalsX");
        public static WinFormsField StopTradeInd = new WinFormsField("STOP-TRADE-IND", "StopTradeInd");
        public static WinFormsField IntInvestorClass = new WinFormsField("INT-INVESTOR-CLASS", "IntInvestorClass");
        public static WinFormsField IntEmployeeClass = new WinFormsField("INT-EMPLOYEE-CLASS", "IntEmployeeClass");
        public static WinFormsField BondClassInd = new WinFormsField("BOND-CLASS-IND", "BondClassInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchCompanyID = new WinFormsField("SEARCH-COMPANY-ID", "SearchCompanyID");
        public static WinFormsField SearchRecordType = new WinFormsField("SEARCH-RECORD-TYPE", "SearchRecordType");
        public static WinFormsField SearchForeignCode = new WinFormsField("SEARCH-FOREIGN-CODE", "SearchForeignCode");
        public static WinFormsField AddRecordType = new WinFormsField("ADD-RECORD-TYPE", "AddRecordType");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
    }
}
