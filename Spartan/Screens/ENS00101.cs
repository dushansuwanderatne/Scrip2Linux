using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    class ENS00101
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("ENS00101", "FormName");
        //Fields
        public static WinFormsField MenuItemE = new WinFormsField("MENU-ITEM-E", "E.  Holder Enquiry System", "HolderEnquirySystem");
        public static WinFormsField MenuItemCX = new WinFormsField("MENU-ITEM-CX", "CX.  Consolidate Extract Files", "ConsolidateExtractFiles");
        public static WinFormsField MenuItemPE = new WinFormsField("MENU-ITEM-PE", "PE.  Payment Enquiry System", "PaymentEnquirySystem");
        public static WinFormsField MenuItemEP = new WinFormsField("MENU-ITEM-EP", "EP.  Enquiry Print", "EnquiryPrint");
        public static WinFormsField MenuItemSE = new WinFormsField("MENU-ITEM-SE", "SE.  Statistics Enquiry", "StatisticsEnquiry");
        public static WinFormsField MenuItemIR = new WinFormsField("MENU-ITEM-IR", "IR.  Issued Capital Report", "IssuedCapitalReport");
        public static WinFormsField MenuItemSP = new WinFormsField("MENU-ITEM-SP", "SP.  Iss Spon'ship Statement Print", "IssSpon'shipStatementPrint");
        public static WinFormsField MenuItemHR = new WinFormsField("MENU-ITEM-HR", "HR.  Holder Request Print", "HolderRequestPrint");
        public static WinFormsField MenuItemFP = new WinFormsField("MENU-ITEM-FP", "FP.  Faster Scripless Stmnt Print", "FasterScriplessStmntPrint");
        public static WinFormsField MenuItemBE = new WinFormsField("MENU-ITEM-BE", "BE.  BHP Employee Enquiry Print", "BHPEmployeeEnquiryPrint");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit Enquiry", "ExitEnquiry");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree2 = new WinFormsField("SYSTEM-INFO-FREE-2", "16", "16");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
        
}
