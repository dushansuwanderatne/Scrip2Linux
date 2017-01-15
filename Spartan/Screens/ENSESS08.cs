using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSESS08

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSESS08", "FormName");
		//Fields


        public static WinFormsField PageNum = new WinFormsField("PAGE-NUM", "PageNum");
        public static WinFormsField NameAddress = new WinFormsField("NAME-ADDRESS", "NameAddress");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField EmployeeNbr = new WinFormsField("EMPLOYEE-NBR", "EmployeeNbr");
        public static WinFormsField NationalInsNbr = new WinFormsField("NATIONAL-INS-NBR", "NationalInsNbr");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField SchemeCode = new WinFormsField("SCHEME-CODE", "SchemeCode");
        public static WinFormsField SchemeName = new WinFormsField("SCHEME-NAME", "SchemeName");
        public static WinFormsField Line1NbrPay = new WinFormsField("LINE1-NBR-PAY", "Line1NbrPay");
        public static WinFormsField Line1Options = new WinFormsField("LINE1-OPTIONS", "Line1Options");
        public static WinFormsField Line1Overdue = new WinFormsField("LINE1-OVERDUE", "Line1Overdue");
        public static WinFormsField Line2Reg = new WinFormsField("LINE2-REG", "Line2Reg");
        public static WinFormsField Line2Pend = new WinFormsField("LINE2-PEND", "Line2Pend");
        public static WinFormsField Line2Usan = new WinFormsField("LINE2-USAN", "Line2Usan");
        public static WinFormsField Line2MatDate = new WinFormsField("LINE2-MAT-DATE", "Line2MatDate");
        public static WinFormsField Line2Term = new WinFormsField("LINE2-TERM", "Line2Term");
        public static WinFormsField Line2Savings = new WinFormsField("LINE2-SAVINGS", "Line2Savings");
        public static WinFormsField Line2NbrPay = new WinFormsField("LINE2-NBR-PAY", "Line2NbrPay");
        public static WinFormsField Line2Options = new WinFormsField("LINE2-OPTIONS", "Line2Options");
        public static WinFormsField Line2Total = new WinFormsField("LINE2-TOTAL", "Line2Total");
        public static WinFormsField Line2Overdue = new WinFormsField("LINE2-OVERDUE", "Line2Overdue");
        public static WinFormsField DetailLine = new WinFormsField("DETAIL-LINE", "DetailLine");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField PayrollID = new WinFormsField("PAYROLL-ID", "PayrollID");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
