using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01003", "FormName");
		//Fields
        public static WinFormsField MenuItemA = new WinFormsField("MENU-ITEM-A", "A. Alpha", "Alpha");
        public static WinFormsField MenuItemU = new WinFormsField("MENU-ITEM-U", "U. Business Unit", "BusinessUnit");
        public static WinFormsField MenuItemH = new WinFormsField("MENU-ITEM-H", "H. Holder Number", "HolderNumber");
        public static WinFormsField MenuItemP = new WinFormsField("MENU-ITEM-P", "P. Postcode", "Postcode");
        public static WinFormsField MenuItemJ = new WinFormsField("MENU-ITEM-J", "J. Job Band", "JobBand");
        public static WinFormsField MenuItemO = new WinFormsField("MENU-ITEM-O", "O. Alpha within Aus (O/S at end)", "AlphawithinAus(O/Satend)");
        public static WinFormsField MenuItemE = new WinFormsField("MENU-ITEM-E", "E. Employee Id", "EmployeeId");
        public static WinFormsField MenuItemI = new WinFormsField("MENU-ITEM-I", "I. Payroll Id", "PayrollId");
        public static WinFormsField MenuItemB = new WinFormsField("MENU-ITEM-B", "B. Special Barcode Pre-sort Plan", "SpecialBarcodePre-sortPlan");
        public static WinFormsField MenuItemL = new WinFormsField("MENU-ITEM-L", "L. Location Code", "LocationCode");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField ASATRun = new WinFormsField("AS-AT-RUN", "ASATRun");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField TotalsOnly = new WinFormsField("TOTALS-ONLY", "TotalsOnly");
        public static WinFormsField CombSepRegisters = new WinFormsField("COMB-SEP-REGISTERS", "CombSepRegisters");
        public static WinFormsField MultSingleApprops = new WinFormsField("MULT-SINGLE-APPROPS", "MultSingleApprops");
        public static WinFormsField SpecialProgram = new WinFormsField("SPECIAL-PROGRAM", "SpecialProgram");
        public static WinFormsField ReturnMailATEnd = new WinFormsField("RETURN-MAIL-AT-END", "ReturnMailATEnd");
        public static WinFormsField ProduceEmailList = new WinFormsField("PRODUCE-EMAIL-LIST", "ProduceEmailList");
        public static WinFormsField FurtherSequencing = new WinFormsField("FURTHER-SEQUENCING", "FurtherSequencing");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
