using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSESS09

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSESS09", "FormName");
		//Fields


        public static WinFormsField PageNum = new WinFormsField("PAGE-NUM", "PageNum");
        public static WinFormsField NameAddress = new WinFormsField("NAME-ADDRESS", "NameAddress");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField EmployeeNbr = new WinFormsField("EMPLOYEE-NBR", "EmployeeNbr");
        public static WinFormsField NationalInsNbr = new WinFormsField("NATIONAL-INS-NBR", "NationalInsNbr");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField SchemeCode = new WinFormsField("SCHEME-CODE", "SchemeCode");
        public static WinFormsField SchemeName = new WinFormsField("SCHEME-NAME", "SchemeName");
        public static WinFormsField Line1Grant = new WinFormsField("LINE1-GRANT", "Line1Grant");
        public static WinFormsField Line1Usan = new WinFormsField("LINE1-USAN", "Line1Usan");
        public static WinFormsField Line1PayDate = new WinFormsField("LINE1-PAY-DATE", "Line1PayDate");
        public static WinFormsField Line1Ttype = new WinFormsField("LINE1-TTYPE", "Line1Ttype");
        public static WinFormsField Line1RunTrans = new WinFormsField("LINE1-RUN-TRANS", "Line1RunTrans");
        public static WinFormsField Line1Amount = new WinFormsField("LINE1-AMOUNT", "Line1Amount");
        public static WinFormsField Line1Reversal = new WinFormsField("LINE1-REVERSAL", "Line1Reversal");
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
