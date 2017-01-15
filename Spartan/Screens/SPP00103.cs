using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPP00103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPP00103", "FormName");
		//Fields


        public static WinFormsField MenuItemCT = new WinFormsField("MENU-ITEM-CT", "CT.  SPP Cash Transaction Report", "SPPCashTransactionReport");
        public static WinFormsField MenuItemCD = new WinFormsField("MENU-ITEM-CD", "CD.  SPP Cash Deposit Report", "SPPCashDepositReport");
        public static WinFormsField MenuItemSE = new WinFormsField("MENU-ITEM-SE", "SE.  SPP Extract Reporting", "SPPExtractReporting");
        public static WinFormsField MenuItemFC = new WinFormsField("MENU-ITEM-FC", "FC.  SPP File Integrity Check", "SPPFileIntegrityCheck");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit from Reporting Menu", "ExitfromReportingMenu");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
