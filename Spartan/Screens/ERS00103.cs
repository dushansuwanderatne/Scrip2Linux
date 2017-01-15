using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS00103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS00103", "FormName");
		//Fields


        public static WinFormsField MenuItemGR = new WinFormsField("MENU-ITEM-GR", "GR.  Grant Report", "GrantReport");
        public static WinFormsField MenuItemOO = new WinFormsField("MENU-ITEM-OO", "OO.  Outstanding Options Report", "OutstandingOptionsReport");
        public static WinFormsField MenuItemPM = new WinFormsField("MENU-ITEM-PM", "PM.  Pending Maturity Report", "PendingMaturityReport");
        public static WinFormsField MenuItemPL = new WinFormsField("MENU-ITEM-PL", "PL.  Pending Lapse Report", "PendingLapseReport");
        public static WinFormsField MenuItemEF = new WinFormsField("MENU-ITEM-EF", "EF.  Produce Employee Export File", "ProduceEmployeeExportFile");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportSelection = new WinFormsField("REPORT-SELECTION", "ReportSelection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
