using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSESS02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSESS02", "FormName");
		//Fields


        public static WinFormsField NameAddress = new WinFormsField("NAME-ADDRESS", "NameAddress");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField Msgid = new WinFormsField("MSGID", "Msgid");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField Reg = new WinFormsField("REG", "Reg");
        public static WinFormsField Cert = new WinFormsField("CERT", "Cert");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField Ttype = new WinFormsField("TTYPE", "Ttype");
        public static WinFormsField Run = new WinFormsField("RUN", "Run");
        public static WinFormsField Trans = new WinFormsField("TRANS", "Trans");
        public static WinFormsField Seq = new WinFormsField("SEQ", "Seq");
        public static WinFormsField OldRun = new WinFormsField("OLD-RUN", "OldRun");
        public static WinFormsField OldTrans = new WinFormsField("OLD-TRANS", "OldTrans");
        public static WinFormsField UnitPrice = new WinFormsField("UNIT-PRICE", "UnitPrice");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
