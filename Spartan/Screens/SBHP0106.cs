using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBHP0106

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBHP0106", "FormName");
		//Fields


        public static WinFormsField MenuItemBE = new WinFormsField("MENU-ITEM-BE", "BE. BHP Extract Reporting (Menu)", "BHPExtractReporting(Menu)");
        public static WinFormsField MenuItemCA = new WinFormsField("MENU-ITEM-CA", "CA. Centre Accounting Report", "CentreAccountingReport");
        public static WinFormsField MenuItemOA = new WinFormsField("MENU-ITEM-OA", "OA. Option Exercise/Allotment Report", "OptionExercise/AllotmentReport");
        public static WinFormsField MenuItemOL = new WinFormsField("MENU-ITEM-OL", "OL. Option Lapse Report/Notices", "OptionLapseReport/Notices");
        public static WinFormsField MenuItemOC = new WinFormsField("MENU-ITEM-OC", "OC. Option Control Report", "OptionControlReport");
        public static WinFormsField MenuItemIT = new WinFormsField("MENU-ITEM-IT", "IT. Imputed Tax Report", "ImputedTaxReport");
        public static WinFormsField MenuItemMD = new WinFormsField("MENU-ITEM-MD", "MD. Mismatched Dividend Elections Report", "MismatchedDividendElectionsReport");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit BHP Reporting System", "ExitBHPReportingSystem");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
