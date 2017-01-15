using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBSMAIN0

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBSMAIN0", "FormName");
		//Fields


        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField MenuItemEnq = new WinFormsField("MENU-ITEM-ENQ", "ENQ.  Enquiries", "Enquiries");
        public static WinFormsField MenuItemRep = new WinFormsField("MENU-ITEM-REP", "REP.  Reporting System", "ReportingSystem");
        public static WinFormsField MenuItemTra = new WinFormsField("MENU-ITEM-TRA", "TRA.  Trade Processing", "TradeProcessing");
        public static WinFormsField MenuItemTrf = new WinFormsField("MENU-ITEM-TRF", "TRF.  Transfer Processing", "TransferProcessing");
        public static WinFormsField MenuItemFtr = new WinFormsField("MENU-ITEM-FTR", "FTR.  File Transfers (Import/Export)", "FileTransfers(Import/Export)");
        public static WinFormsField MenuItemSys = new WinFormsField("MENU-ITEM-SYS", "SYS.  System Administration", "SystemAdministration");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit from the system", "Exitfromthesystem");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
