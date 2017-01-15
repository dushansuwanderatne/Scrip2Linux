using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB0601

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB0601", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField BulkCode = new WinFormsField("BULK-CODE", "BulkCode");
        public static WinFormsField BulkDescription = new WinFormsField("BULK-DESCRIPTION", "BulkDescription");
        public static WinFormsField BulkStatus = new WinFormsField("BULK-STATUS", "BulkStatus");
        public static WinFormsField BulkNumberFrom = new WinFormsField("BULK-NUMBER-FROM", "BulkNumberFrom");
        public static WinFormsField BulkNumberTO = new WinFormsField("BULK-NUMBER-TO", "BulkNumberTO");
        public static WinFormsField TransNumberFrom = new WinFormsField("TRANS-NUMBER-FROM", "TransNumberFrom");
        public static WinFormsField TransNumberTO = new WinFormsField("TRANS-NUMBER-TO", "TransNumberTO");
        public static WinFormsField SessionNumberFrom = new WinFormsField("SESSION-NUMBER-FROM", "SessionNumberFrom");
        public static WinFormsField SessionNumberTO = new WinFormsField("SESSION-NUMBER-TO", "SessionNumberTO");
        public static WinFormsField UnitsFrom = new WinFormsField("UNITS-FROM", "UnitsFrom");
        public static WinFormsField UnitsTO = new WinFormsField("UNITS-TO", "UnitsTO");
        public static WinFormsField Audit = new WinFormsField("AUDIT", "Audit");
        public static WinFormsField TransStatus = new WinFormsField("TRANS-STATUS", "TransStatus");
        public static WinFormsField BsbDetails = new WinFormsField("BSB-DETAILS", "BsbDetails");
        public static WinFormsField XtractFileName = new WinFormsField("XTRACT-FILE-NAME", "XtractFileName");
    }
}
