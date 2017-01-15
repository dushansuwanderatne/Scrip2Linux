using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEYT0100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEYT0100", "FormName");
		//Fields


        public static WinFormsField MenuItemPar = new WinFormsField("MENU-ITEM-PAR", "PAR.   EYT Parameters", "EYTParameters");
        public static WinFormsField MenuItemTot = new WinFormsField("MENU-ITEM-TOT", "TOT.   Generate Totals", "GenerateTotals");
        public static WinFormsField MenuItemGen = new WinFormsField("MENU-ITEM-GEN", "GEN.   Generate Files & Reports", "GenerateFiles&Reports");
        public static WinFormsField MenuItemSig = new WinFormsField("MENU-ITEM-SIG", "SIG.   Signoff EYT", "SignoffEYT");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.    Exit End of Year Tax Statements", "ExitEndofYearTaxStatements");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
