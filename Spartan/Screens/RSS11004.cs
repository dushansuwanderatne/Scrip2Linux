using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS11004
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS11004", "FormName");
        //Fields
        public static WinFormsField MenuItemA = new WinFormsField("MENU-ITEM-A", "A.  Alpha", "Alpha");
        public static WinFormsField MenuItemP = new WinFormsField("MENU-ITEM-P", "P.  Postcode", "Postcode");
        public static WinFormsField MenuItemC = new WinFormsField("MENU-ITEM-C", "C.  Payment Cheque Account", "PaymentChequeAccount");
        public static WinFormsField Sequence = new WinFormsField("SEQUENCE", "Sequence");
        public static WinFormsField PrintCompany = new WinFormsField("PRINT-COMPANY", "PrintCompany");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField SpecialProgram = new WinFormsField("SPECIAL-PROGRAM", "SpecialProgram");
        public static WinFormsField SaveExtractFile = new WinFormsField("SAVE-EXTRACT-FILE", "SaveExtractFile");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
