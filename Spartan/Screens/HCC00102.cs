using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HCC00102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HCC00102", "FormName");
		//Fields
        public static WinFormsField MenuItemCls = new WinFormsField("MENU-ITEM-CLS", "CLS. Class Control Parameters", "ClassControlParameters");
        public static WinFormsField MenuItemTtc = new WinFormsField("MENU-ITEM-TTC", "TTC. Transaction Type Codes", "TransactionTypeCodes");
        public static WinFormsField MenuItemClg = new WinFormsField("MENU-ITEM-CLG", "CLG. Class Groupings", "ClassGroupings");
        public static WinFormsField MenuItemHtc = new WinFormsField("MENU-ITEM-HTC", "HTC. Holder Type Codes", "HolderTypeCodes");
        public static WinFormsField MenuItemCfl = new WinFormsField("MENU-ITEM-CFL", "CFL. Company Flag Descriptions", "CompanyFlagDescriptions");
        public static WinFormsField MenuItemReg = new WinFormsField("MENU-ITEM-REG", "REG. Register Codes", "RegisterCodes");
        public static WinFormsField MenuItemCop = new WinFormsField("MENU-ITEM-COP", "COP. Company Options", "CompanyOptions");
        public static WinFormsField MenuItemTcp = new WinFormsField("MENU-ITEM-TCP", "TCP. Terminate CUM Processing", "TerminateCUMProcessing");
        public static WinFormsField MenuItemUrc = new WinFormsField("MENU-ITEM-URC", "URC. Update Reporting Control", "UpdateReportingControl");
        public static WinFormsField MenuItemCom = new WinFormsField("MENU-ITEM-COM", "COM. Commission/Stamp Duty Tables", "Commission/StampDutyTables");
        public static WinFormsField MenuItemBcc = new WinFormsField("MENU-ITEM-BCC", "BCC. Bulk Control Codes", "BulkControlCodes");
        public static WinFormsField MenuItemPid = new WinFormsField("MENU-ITEM-PID", "PID. Payroll Identifier", "PayrollIdentifier");
        public static WinFormsField MenuItemRfc = new WinFormsField("MENU-ITEM-RFC", "RFC. Reference Codes", "ReferenceCodes");
        public static WinFormsField MenuItemFog = new WinFormsField("MENU-ITEM-FOG", "FOG. Foreign Ownership Group", "ForeignOwnershipGroup");
        public static WinFormsField MenuItemBam = new WinFormsField("MENU-ITEM-BAM", "BAM. Bank Account Maintenance", "BankAccountMaintenance");
        public static WinFormsField MenuItemEss = new WinFormsField("MENU-ITEM-ESS", "ESS. ESS Control Options", "ESSControlOptions");
        public static WinFormsField MenuItemTcc = new WinFormsField("MENU-ITEM-TCC", "TCC. Trading Control Codes", "TradingControlCodes");
        public static WinFormsField MenuItemHgc = new WinFormsField("MENU-ITEM-HGC", "HGC. Holder Groups", "HolderGroups");
        public static WinFormsField MenuItemNot = new WinFormsField("MENU-ITEM-NOT", "NOT. Company Notice", "CompanyNotice");
        public static WinFormsField MenuItemCus = new WinFormsField("MENU-ITEM-CUS", "CUS. Custodian Setup Enquiry", "CustodianSetupEnquiry");
        public static WinFormsField MenuItemPcs = new WinFormsField("MENU-ITEM-PCS", "PCS. Process Codes and Steps", "ProcessCodesandSteps");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
