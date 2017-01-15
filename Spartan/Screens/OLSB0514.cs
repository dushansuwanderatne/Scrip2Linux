using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB0514

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB0514", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField BulkStatus = new WinFormsField("BULK-STATUS", "BulkStatus");
        public static WinFormsField BulkID = new WinFormsField("BULK-ID", "BulkID");
        public static WinFormsField BulkTotal = new WinFormsField("BULK-TOTAL", "BulkTotal");
        public static WinFormsField BulkCount = new WinFormsField("BULK-COUNT", "BulkCount");
        public static WinFormsField RequiredUnits = new WinFormsField("REQUIRED-UNITS", "RequiredUnits");
        public static WinFormsField SessionUnits = new WinFormsField("SESSION-UNITS", "SessionUnits");
        public static WinFormsField SessionCount = new WinFormsField("SESSION-COUNT", "SessionCount");
    }
}
