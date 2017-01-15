using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01006

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01006", "FormName");
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
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField CombSepRegisters = new WinFormsField("COMB-SEP-REGISTERS", "CombSepRegisters");
        public static WinFormsField StatementOutput = new WinFormsField("STATEMENT-OUTPUT", "StatementOutput");
        public static WinFormsField SpecialProgram = new WinFormsField("SPECIAL-PROGRAM", "SpecialProgram");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
