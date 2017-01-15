using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BLKSCH01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BLKSCH01", "FormName");
		//Fields
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField BulkCode = new WinFormsField("BULK-CODE", "BulkCode");
        public static WinFormsField BulkDesc = new WinFormsField("BULK-DESC", "BulkDesc");
        public static WinFormsField Heading1 = new WinFormsField("HEADING1", "Heading1");
        public static WinFormsField BulkID = new WinFormsField("BULK-ID", "BulkID");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField TransCount = new WinFormsField("TRANS-COUNT", "TransCount");
        public static WinFormsField TransTotal = new WinFormsField("TRANS-TOTAL", "TransTotal");
        public static WinFormsField CrestID = new WinFormsField("CREST-ID", "CrestID");
        public static WinFormsField SettlementDate = new WinFormsField("SETTLEMENT-DATE", "SettlementDate");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
