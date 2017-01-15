using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01008

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01008", "FormName");
		//Fields
        public static WinFormsField Selcls = new WinFormsField("SELCLS", "Selcls");
        public static WinFormsField Selgrp = new WinFormsField("SELGRP", "Selgrp");
        public static WinFormsField Selreg = new WinFormsField("SELREG", "Selreg");
        public static WinFormsField reg = new WinFormsField("REG", "reg");
        public static WinFormsField RegType = new WinFormsField("REG-TYPE", "RegType");
        public static WinFormsField RunORDateRange = new WinFormsField("RUN-OR-DATE-RANGE", "RunORDateRange");
        public static WinFormsField RunRangeFrom = new WinFormsField("RUN-RANGE-FROM", "RunRangeFrom");
        public static WinFormsField RunRangeTO = new WinFormsField("RUN-RANGE-TO", "RunRangeTO");
        public static WinFormsField TransDateFrom = new WinFormsField("TRANS-DATE-FROM", "TransDateFrom");
        public static WinFormsField TransDateTO = new WinFormsField("TRANS-DATE-TO", "TransDateTO");
        public static WinFormsField TransactionType = new WinFormsField("TRANSACTION-TYPE", "TransactionType");
        public static WinFormsField TransType = new WinFormsField("TRANS-TYPE", "TransType");
        public static WinFormsField ReportingLevel = new WinFormsField("REPORTING-LEVEL", "ReportingLevel");
        public static WinFormsField SummaryReportCsvInd = new WinFormsField("SUMMARY-REPORT-CSV-IND", "SummaryReportCsvInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
