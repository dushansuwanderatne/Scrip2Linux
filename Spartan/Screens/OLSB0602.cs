using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB0602

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB0602", "FormName");
		//Fields
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ReportType = new WinFormsField("REPORT-TYPE", "ReportType");
        public static WinFormsField BulkCodeLine1 = new WinFormsField("BULK-CODE-LINE1", "BulkCodeLine1");
        public static WinFormsField BulkCodeLine2 = new WinFormsField("BULK-CODE-LINE2", "BulkCodeLine2");
        public static WinFormsField BulkNumberFrom = new WinFormsField("BULK-NUMBER-FROM", "BulkNumberFrom");
        public static WinFormsField BulkNumberTO = new WinFormsField("BULK-NUMBER-TO", "BulkNumberTO");
        public static WinFormsField BulkStatus = new WinFormsField("BULK-STATUS", "BulkStatus");
        public static WinFormsField SettlementDateFrom = new WinFormsField("SETTLEMENT-DATE-FROM", "SettlementDateFrom");
        public static WinFormsField SettlementDateTO = new WinFormsField("SETTLEMENT-DATE-TO", "SettlementDateTO");
    }
}
