using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSSRP10

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSSRP10", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField PageNumber = new WinFormsField("PAGE-NUMBER", "PageNumber");
        public static WinFormsField HolderNamekey = new WinFormsField("HOLDER-NAMEKEY", "HolderNamekey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderCategory = new WinFormsField("HOLDER-CATEGORY", "HolderCategory");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField AddressLine1 = new WinFormsField("ADDRESS-LINE1", "AddressLine1");
        public static WinFormsField AddressLine2 = new WinFormsField("ADDRESS-LINE2", "AddressLine2");
        public static WinFormsField EmpDesc = new WinFormsField("EMP-DESC", "EmpDesc");
        public static WinFormsField EmpShares = new WinFormsField("EMP-SHARES", "EmpShares");
        public static WinFormsField LoanDesc = new WinFormsField("LOAN-DESC", "LoanDesc");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField Ttype = new WinFormsField("TTYPE", "Ttype");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField Interest = new WinFormsField("INTEREST", "Interest");
        public static WinFormsField Balance = new WinFormsField("BALANCE", "Balance");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
