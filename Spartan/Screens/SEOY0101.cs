using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEOY0101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEOY0101", "FormName");
		//Fields


        public static WinFormsField StatementDate = new WinFormsField("STATEMENT-DATE", "StatementDate");
        public static WinFormsField Comment = new WinFormsField("COMMENT", "Comment");
        public static WinFormsField ExtractFile = new WinFormsField("EXTRACT-FILE", "ExtractFile");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField StatementDtlReqd = new WinFormsField("STATEMENT-DTL-REQD", "StatementDtlReqd");
        public static WinFormsField TrustTaxRptReqd = new WinFormsField("TRUST-TAX-RPT-REQD", "TrustTaxRptReqd");
        public static WinFormsField PrtnrTrustCsvReqd = new WinFormsField("PRTNR-TRUST-CSV-REQD", "PrtnrTrustCsvReqd");
        public static WinFormsField ClsDtlCsvReqdInd = new WinFormsField("CLS-DTL-CSV-REQD-IND", "ClsDtlCsvReqdInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
    }
}
