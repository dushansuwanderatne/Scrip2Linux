using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS05000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS05000", "FormName");
		//Fields


        public static WinFormsField MenuItemEL = new WinFormsField("MENU-ITEM-EL", "EL.  Entrepot Account Listing", "EntrepotAccountListing");
        public static WinFormsField MenuItemSS = new WinFormsField("MENU-ITEM-SS", "SS.  Standard Request Statement", "StandardRequestStatement");
        public static WinFormsField MenuItemAC = new WinFormsField("MENU-ITEM-AC", "AC.  Allotment Confirmation Notices", "AllotmentConfirmationNotices");
        public static WinFormsField MenuItemFE = new WinFormsField("MENU-ITEM-FE", "FE.  FASTER Extract Reporting", "FASTERExtractReporting");
        public static WinFormsField MenuItemFP = new WinFormsField("MENU-ITEM-FP", "FP.  FASTER Pending Extract Reporting (Online)", "FASTERPendingExtractReporting(Online)");
        public static WinFormsField MenuItemFS = new WinFormsField("MENU-ITEM-FS", "FS.  FASTER Standard Request Statement", "FASTERStandardRequestStatement");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportType = new WinFormsField("REPORT-TYPE", "ReportType");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
