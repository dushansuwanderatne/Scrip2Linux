using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLFLT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLFLT01", "FormName");
		//Fields


        public static WinFormsField MenuItemBU = new WinFormsField("MENU-ITEM-BU", "BU. Batch Register Updating", "BatchRegisterUpdating");
        public static WinFormsField MenuItemAU = new WinFormsField("MENU-ITEM-AU", "AU. Agent Code Updating", "AgentCodeUpdating");
        public static WinFormsField MenuItemBR = new WinFormsField("MENU-ITEM-BR", "BR. Batch Register Reporting", "BatchRegisterReporting");
        public static WinFormsField MenuItemAE = new WinFormsField("MENU-ITEM-AE", "AE. Agent/Application Enquiry", "Agent/ApplicationEnquiry");
        public static WinFormsField MenuItemAL = new WinFormsField("MENU-ITEM-AL", "AL. Broker/Agent Application Report", "Broker/AgentApplicationReport");
        public static WinFormsField MenuItemBT = new WinFormsField("MENU-ITEM-BT", "BT. Batch/Trans# Enquiry", "Batch/Trans#Enquiry");
        public static WinFormsField MenuItemAA = new WinFormsField("MENU-ITEM-AA", "AA. Applications in Alpha Order", "ApplicationsinAlphaOrder");
        public static WinFormsField MenuItemBC = new WinFormsField("MENU-ITEM-BC", "BC. Broker Commission Report", "BrokerCommissionReport");
        public static WinFormsField MenuItemCH = new WinFormsField("MENU-ITEM-CH", "CH. Cumulative CHS/CSN Mismatch Report", "CumulativeCHS/CSNMismatchReport");
        public static WinFormsField MenuItemAN = new WinFormsField("MENU-ITEM-AN", "AN. Pre-Reserved Not Returned Report", "Pre-ReservedNotReturnedReport");
        public static WinFormsField MenuItemAT = new WinFormsField("MENU-ITEM-AT", "AT. Application Transactions", "ApplicationTransactions");
        public static WinFormsField MenuItemUB = new WinFormsField("MENU-ITEM-UB", "UB. Upload Bank Details", "UploadBankDetails");
        public static WinFormsField MenuItemSN = new WinFormsField("MENU-ITEM-SN", "SN. Schedule Nightly Processing", "ScheduleNightlyProcessing");
        public static WinFormsField MenuItemCR = new WinFormsField("MENU-ITEM-CR", "CR. Cumulative Exception Reporting", "CumulativeExceptionReporting");
        public static WinFormsField MenuItemIC = new WinFormsField("MENU-ITEM-IC", "IC. Chess/Issuer/Faster Conversion", "Chess/Issuer/FasterConversion");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. EXIT from FLOAT menu", "EXITfromFLOATmenu");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
