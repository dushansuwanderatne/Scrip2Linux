using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBHP6001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBHP6001", "FormName");
		//Fields


        public static WinFormsField MenuItemEL = new WinFormsField("MENU-ITEM-EL", "EL. ESP Loan Statements", "ESPLoanStatements");
        public static WinFormsField MenuItemDR = new WinFormsField("MENU-ITEM-DR", "DR. Delinquency/Overdue Report/Notices", "Delinquency/OverdueReport/Notices");
        public static WinFormsField MenuItemPL = new WinFormsField("MENU-ITEM-PL", "PL. Centre Listing of Paid Out Loans", "CentreListingofPaidOutLoans");
        public static WinFormsField MenuItemCR = new WinFormsField("MENU-ITEM-CR", "CR. Centre Register Report", "CentreRegisterReport");
        public static WinFormsField MenuItemAS = new WinFormsField("MENU-ITEM-AS", "AS. Application Summary Report", "ApplicationSummaryReport");
        public static WinFormsField MenuItemAC = new WinFormsField("MENU-ITEM-AC", "AC. Allot Confirmation Report/Notices", "AllotConfirmationReport/Notices");
        public static WinFormsField MenuItemDL = new WinFormsField("MENU-ITEM-DL", "DL. Directors Loan Report", "DirectorsLoanReport");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit BHP Extract Reporting System", "ExitBHPExtractReportingSystem");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
