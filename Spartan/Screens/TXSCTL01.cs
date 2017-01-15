using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TXSCTL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TXSCTL01", "FormName");
		//Fields


        public static WinFormsField TxsctlKey0 = new WinFormsField("TXSCTL-KEY0", "TxsctlKey0");
        public static WinFormsField Mtx0FinYear = new WinFormsField("MTX0-FIN-YEAR", "Mtx0FinYear");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField TaxSeqNumber = new WinFormsField("TAX-SEQ-NUMBER", "TaxSeqNumber");
        public static WinFormsField TaxEventInd = new WinFormsField("TAX-EVENT-IND", "TaxEventInd");
        public static WinFormsField BuildDate = new WinFormsField("BUILD-DATE", "BuildDate");
        public static WinFormsField BuildTime = new WinFormsField("BUILD-TIME", "BuildTime");
        public static WinFormsField BuildUserID = new WinFormsField("BUILD-USER-ID", "BuildUserID");
        public static WinFormsField TaxFileName = new WinFormsField("TAX-FILE-NAME", "TaxFileName");
        public static WinFormsField BuildProcessCode = new WinFormsField("BUILD-PROCESS-CODE", "BuildProcessCode");
        public static WinFormsField WorkStreamInd = new WinFormsField("WORK-STREAM-IND", "WorkStreamInd");
        public static WinFormsField Mtx0AmendmentIndicator = new WinFormsField("MTX0-AMENDMENT-INDICATOR", "Mtx0AmendmentIndicator");
        public static WinFormsField Mtx0DividendReportedInd = new WinFormsField("MTX0-DIVIDEND-REPORTED-IND", "Mtx0DividendReportedInd");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField LastUpdtdDate = new WinFormsField("LAST-UPDTD-DATE", "LastUpdtdDate");
        public static WinFormsField LastUpdtdTime = new WinFormsField("LAST-UPDTD-TIME", "LastUpdtdTime");
        public static WinFormsField LastUpdtdUserID = new WinFormsField("LAST-UPDTD-USER-ID", "LastUpdtdUserID");
        public static WinFormsField LastUpdtdProcessCode = new WinFormsField("LAST-UPDTD-PROCESS-CODE", "LastUpdtdProcessCode");
        public static WinFormsField NumberHolders = new WinFormsField("NUMBER-HOLDERS", "NumberHolders");
        public static WinFormsField FileAutoFtpInd = new WinFormsField("FILE-AUTO-FTP-IND", "FileAutoFtpInd");
        public static WinFormsField TfnAmtInd = new WinFormsField("TFN-AMT-IND", "TfnAmtInd");
        public static WinFormsField EncompassJobID = new WinFormsField("ENCOMPASS-JOB-ID", "EncompassJobID");
        public static WinFormsField EncompassDesc1 = new WinFormsField("ENCOMPASS-DESC-1", "EncompassDesc1");
        public static WinFormsField EncompassDesc2 = new WinFormsField("ENCOMPASS-DESC-2", "EncompassDesc2");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
