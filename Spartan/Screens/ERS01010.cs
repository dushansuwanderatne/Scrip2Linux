using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01010", "FormName");
		//Fields
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderCat = new WinFormsField("HOLDER-CAT", "HolderCat");
        public static WinFormsField HolderNumber = new WinFormsField("HOLDER-NUMBER", "HolderNumber");
        public static WinFormsField RegAddress = new WinFormsField("REG-ADDRESS", "RegAddress");
        public static WinFormsField RegAddrCase = new WinFormsField("REG-ADDR-CASE", "RegAddrCase");
        public static WinFormsField HolderName = new WinFormsField("HOLDER-NAME", "HolderName");
        public static WinFormsField Fullnames = new WinFormsField("FULLNAMES", "Fullnames");
        public static WinFormsField CaseFull = new WinFormsField("CASE-FULL", "CaseFull");
        public static WinFormsField FormattedFull = new WinFormsField("FORMATTED-FULL", "FormattedFull");
        public static WinFormsField NameDetailed = new WinFormsField("NAME-DETAILED", "NameDetailed");
        public static WinFormsField CaseDetailed = new WinFormsField("CASE-DETAILED", "CaseDetailed");
        public static WinFormsField Surname = new WinFormsField("SURNAME", "Surname");
        public static WinFormsField FirstName = new WinFormsField("FIRST-NAME", "FirstName");
        public static WinFormsField SecondName = new WinFormsField("SECOND-NAME", "SecondName");
        public static WinFormsField ThirdName = new WinFormsField("THIRD-NAME", "ThirdName");
        public static WinFormsField Title = new WinFormsField("TITLE", "Title");
        public static WinFormsField Initials = new WinFormsField("INITIALS", "Initials");
        public static WinFormsField Designator = new WinFormsField("DESIGNATOR", "Designator");
        public static WinFormsField NameKey = new WinFormsField("NAME-KEY", "NameKey");
        public static WinFormsField NameType = new WinFormsField("NAME-TYPE", "NameType");
        public static WinFormsField HolderAddress = new WinFormsField("HOLDER-ADDRESS", "HolderAddress");
        public static WinFormsField HolderAddressCase = new WinFormsField("HOLDER-ADDRESS-CASE", "HolderAddressCase");
        public static WinFormsField IncludePcode = new WinFormsField("INCLUDE-PCODE", "IncludePcode");
        public static WinFormsField PcodeDomicile = new WinFormsField("PCODE-DOMICILE", "PcodeDomicile");
        public static WinFormsField Dpid = new WinFormsField("DPID", "Dpid");
        public static WinFormsField Barcode = new WinFormsField("BARCODE", "Barcode");
        public static WinFormsField AlternateID = new WinFormsField("ALTERNATE-ID", "AlternateID");
        public static WinFormsField Ers01010PersonalUrl = new WinFormsField("ERS01010-PERSONAL-URL", "Ers01010PersonalUrl");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
