using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSESS04

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSESS04", "FormName");
		//Fields
        public static WinFormsField PageNum = new WinFormsField("PAGE-NUM", "PageNum");
        public static WinFormsField NameAddress = new WinFormsField("NAME-ADDRESS", "NameAddress");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField EmployeeIdentifier = new WinFormsField("EMPLOYEE-IDENTIFIER", "EmployeeIdentifier");
        public static WinFormsField NationalInsNbr = new WinFormsField("NATIONAL-INS-NBR", "NationalInsNbr");
        public static WinFormsField Msgid = new WinFormsField("MSGID", "Msgid");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField OldDesc = new WinFormsField("OLD-DESC", "OldDesc");
        public static WinFormsField NewDesc = new WinFormsField("NEW-DESC", "NewDesc");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField Reg = new WinFormsField("REG", "Reg");
        public static WinFormsField Cert = new WinFormsField("CERT", "Cert");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField Ttype = new WinFormsField("TTYPE", "Ttype");
        public static WinFormsField Run = new WinFormsField("RUN", "Run");
        public static WinFormsField Trans = new WinFormsField("TRANS", "Trans");
        public static WinFormsField Seq = new WinFormsField("SEQ", "Seq");
        public static WinFormsField OldValue = new WinFormsField("OLD-VALUE", "OldValue");
        public static WinFormsField NewValue = new WinFormsField("NEW-VALUE", "NewValue");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField PayrollID = new WinFormsField("PAYROLL-ID", "PayrollID");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
