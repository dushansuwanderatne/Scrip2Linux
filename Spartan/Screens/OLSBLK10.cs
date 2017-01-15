using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSBLK10

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSBLK10", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField BulkID = new WinFormsField("BULK-ID", "BulkID");
        public static WinFormsField ReportUfd = new WinFormsField("REPORT-UFD", "ReportUfd");
        public static WinFormsField ReportName = new WinFormsField("REPORT-NAME", "ReportName");
        public static WinFormsField Printer = new WinFormsField("PRINTER", "Printer");
        public static WinFormsField NumberCopies = new WinFormsField("NUMBER-COPIES", "NumberCopies");
    }
}
