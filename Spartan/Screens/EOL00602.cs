using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00602

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00602", "FormName");
		//Fields


        public static WinFormsField MenuItemA = new WinFormsField("MENU-ITEM-A", "A. Alpha", "Alpha");
        public static WinFormsField MenuItemH = new WinFormsField("MENU-ITEM-H", "H. Holder Number", "HolderNumber");
        public static WinFormsField MenuItemN = new WinFormsField("MENU-ITEM-N", "N. NI Number", "NINumber");
        public static WinFormsField MenuItemE = new WinFormsField("MENU-ITEM-E", "E. Employee Id", "EmployeeId");
        public static WinFormsField MenuItemP = new WinFormsField("MENU-ITEM-P", "P. Payroll Id", "PayrollId");
        public static WinFormsField MenuItemD = new WinFormsField("MENU-ITEM-D", "D. Division Code", "DivisionCode");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField ReportSequence = new WinFormsField("REPORT-SEQUENCE", "ReportSequence");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
