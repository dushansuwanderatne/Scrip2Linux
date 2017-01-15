using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDRSP12

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDRSP12", "FormName");
		//Fields


        public static WinFormsField FormHeading = new WinFormsField("FORM-HEADING", "FormHeading");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField TrdCntrlCode = new WinFormsField("TRD-CNTRL-CODE", "TrdCntrlCode");
        public static WinFormsField TrdType = new WinFormsField("TRD-TYPE", "TrdType");
        public static WinFormsField ReportNonCurrent = new WinFormsField("REPORT-NON-CURRENT", "ReportNonCurrent");
        public static WinFormsField ReportEventBulks = new WinFormsField("REPORT-EVENT-BULKS", "ReportEventBulks");
        public static WinFormsField ApplyTransactions = new WinFormsField("APPLY-TRANSACTIONS", "ApplyTransactions");
        public static WinFormsField ONMarketTradeInd = new WinFormsField("ON-MARKET-TRADE-IND", "ONMarketTradeInd");
        public static WinFormsField RealTimeTrdInd = new WinFormsField("REAL-TIME-TRD-IND", "RealTimeTrdInd");
        public static WinFormsField OnlineEntryInd = new WinFormsField("ONLINE-ENTRY-IND", "OnlineEntryInd");
        public static WinFormsField WebEntryInd = new WinFormsField("WEB-ENTRY-IND", "WebEntryInd");
        public static WinFormsField TransactionAuditInd = new WinFormsField("TRANSACTION-AUDIT-IND", "TransactionAuditInd");
        public static WinFormsField ReconciliationCode = new WinFormsField("RECONCILIATION-CODE", "ReconciliationCode");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
