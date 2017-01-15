using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPS00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPS00101", "FormName");
		//Fields
        public static WinFormsField MenuItemDiv = new WinFormsField("MENU-ITEM-DIV", "DIV. Dividend Payment Parameters", "DividendPaymentParameters");
        public static WinFormsField MenuItemTko = new WinFormsField("MENU-ITEM-TKO", "TKO. Takeover System Parameters", "TakeoverSystemParameters");
        public static WinFormsField MenuItemIss = new WinFormsField("MENU-ITEM-ISS", "ISS. Issue/Reconstruction Parameters", "Issue/ReconstructionParameters");
        public static WinFormsField MenuItemIsx = new WinFormsField("MENU-ITEM-ISX", "ISX. Issue Parameters (NEW)", "IssueParameters(NEW)");
        public static WinFormsField MenuItemAlt = new WinFormsField("MENU-ITEM-ALT", "ALT. Allotment System Parameters", "AllotmentSystemParameters");
        public static WinFormsField MenuItemDmp = new WinFormsField("MENU-ITEM-DMP", "DMP. Dump System Parameters", "DumpSystemParameters");
        public static WinFormsField MenuItemSdn = new WinFormsField("MENU-ITEM-SDN", "SDN. Scale Down System Parameters", "ScaleDownSystemParameters");
        public static WinFormsField MenuItemCur = new WinFormsField("MENU-ITEM-CUR", "CUR. Currency Conversion Setup ", "CurrencyConversionSetup");
        public static WinFormsField MenuItemRmt = new WinFormsField("MENU-ITEM-RMT", "RMT. Receipt Routing Parameters", "ReceiptRoutingParameters");
        public static WinFormsField MenuItemAsp = new WinFormsField("MENU-ITEM-ASP", "ASP. Acceptance Status Parameters", "AcceptanceStatusParameters");
        public static WinFormsField MenuItemFtc = new WinFormsField("MENU-ITEM-FTC", "FTC. Incoming File Transfer Control", "IncomingFileTransferControl");
        public static WinFormsField MenuItemUnc = new WinFormsField("MENU-ITEM-UNC", "UNC. Uncertificated Conversion Setup", "UncertificatedConversionSetup");
        public static WinFormsField MenuItemFlt = new WinFormsField("MENU-ITEM-FLT", "FLT. Float System Parameters", "FloatSystemParameters");
        public static WinFormsField MenuItemEal = new WinFormsField("MENU-ITEM-EAL", "EAL. Employee Allotment Parameters", "EmployeeAllotmentParameters");
        public static WinFormsField MenuItemDmu = new WinFormsField("MENU-ITEM-DMU", "DMU. Demutualisation Parameters", "DemutualisationParameters");
        public static WinFormsField MenuItemThc = new WinFormsField("MENU-ITEM-THC", "THC. Transfer History Classes Setup", "TransferHistoryClassesSetup");
        public static WinFormsField MenuItemStm = new WinFormsField("MENU-ITEM-STM", "STM. Statement Parameters", "StatementParameters");
        public static WinFormsField MenuItemHF = new WinFormsField("MENU-ITEM-HF", "HF. Host Functions", "HostFunctions");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit System Setups", "ExitSystemSetups");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
