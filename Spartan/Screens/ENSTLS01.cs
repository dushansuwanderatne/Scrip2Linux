using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSTLS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSTLS01", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField NoticeNumber = new WinFormsField("NOTICE-NUMBER", "NoticeNumber");
        public static WinFormsField UnitsLit = new WinFormsField("UNITS-LIT", "UnitsLit");
        public static WinFormsField LoyaltyLit1 = new WinFormsField("LOYALTY-LIT-1", "LoyaltyLit1");
        public static WinFormsField NonLoyaltyLit1 = new WinFormsField("NON-LOYALTY-LIT-1", "NonLoyaltyLit1");
        public static WinFormsField OwingLit = new WinFormsField("OWING-LIT", "OwingLit");
        public static WinFormsField LoyaltyLit2 = new WinFormsField("LOYALTY-LIT-2", "LoyaltyLit2");
        public static WinFormsField NonLoyaltyLit2 = new WinFormsField("NON-LOYALTY-LIT-2", "NonLoyaltyLit2");
        public static WinFormsField TotalUnpaidUnits = new WinFormsField("TOTAL-UNPAID-UNITS", "TotalUnpaidUnits");
        public static WinFormsField UnpaidUnits1 = new WinFormsField("UNPAID-UNITS-1", "UnpaidUnits1");
        public static WinFormsField UnpaidUnits2 = new WinFormsField("UNPAID-UNITS-2", "UnpaidUnits2");
        public static WinFormsField TotalUnpaidAmt = new WinFormsField("TOTAL-UNPAID-AMT", "TotalUnpaidAmt");
        public static WinFormsField UnpaidAmt1 = new WinFormsField("UNPAID-AMT-1", "UnpaidAmt1");
        public static WinFormsField UnpaidAmt2 = new WinFormsField("UNPAID-AMT-2", "UnpaidAmt2");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
