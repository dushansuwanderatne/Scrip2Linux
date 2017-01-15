using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS00002
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("CFS00002", "FormName");
        //Fields
        public static WinFormsField MenuItemSdc = new WinFormsField("MENU-ITEM-SDC", "SDC. Domicile Code", "DomicileCode");
        public static WinFormsField MenuItemSbc = new WinFormsField("MENU-ITEM-SBC", "SBC. Bank Code", "BankCode");
        public static WinFormsField MenuItemScs = new WinFormsField("MENU-ITEM-SCS", "SCS. Broker/Custodian Setup Menu", "Broker/CustodianSetupMenu");
        public static WinFormsField MenuItemKwd = new WinFormsField("MENU-ITEM-KWD", "KWD. Keywords", "Keywords");
        public static WinFormsField MenuItemStx = new WinFormsField("MENU-ITEM-STX", "STX. Tax File Exemption Codes", "TaxFileExemptionCodes");
        public static WinFormsField MenuItemSmg = new WinFormsField("MENU-ITEM-SMG", "SMG. Mailing Group Codes", "MailingGroupCodes");
        public static WinFormsField MenuItemSmr = new WinFormsField("MENU-ITEM-SMR", "SMR. Magnet File Update", "MagnetFileUpdate");
        public static WinFormsField MenuItemSce = new WinFormsField("MENU-ITEM-SCE", "SCE. System Error Codes", "SystemErrorCodes");
        public static WinFormsField MenuItemSbd = new WinFormsField("MENU-ITEM-SBD", "SBD. Business Date Calendars", "BusinessDateCalendars");
        public static WinFormsField MenuItemStc = new WinFormsField("MENU-ITEM-STC", "STC. Default Transaction Codes", "DefaultTransactionCodes");
        public static WinFormsField MenuItemShc = new WinFormsField("MENU-ITEM-SHC", "SHC. Default Holder Type Codes", "DefaultHolderTypeCodes");
        public static WinFormsField MenuItemSrc = new WinFormsField("MENU-ITEM-SRC", "SRC. Default Register Codes", "DefaultRegisterCodes");
        public static WinFormsField MenuItemPst = new WinFormsField("MENU-ITEM-PST", "PST. Postcode Update", "PostcodeUpdate");
        public static WinFormsField MenuItemCom = new WinFormsField("MENU-ITEM-COM", "COM. Commission/Stamp Duty Master Codes", "Commission/StampDutyMasterCodes");
        public static WinFormsField MenuItemCjr = new WinFormsField("MENU-ITEM-CJR", "CJR. Client Job Release", "ClientJobRelease");
        public static WinFormsField MenuItemUhf = new WinFormsField("MENU-ITEM-UHF", "UHF. Update Forms Help File", "UpdateFormsHelpFile");
        public static WinFormsField MenuItemCur = new WinFormsField("MENU-ITEM-CUR", "CUR. Currency Codes", "CurrencyCodes");
        public static WinFormsField MenuItemSrv = new WinFormsField("MENU-ITEM-SRV", "SRV. Default Service Codes", "DefaultServiceCodes");
        public static WinFormsField MenuItemPsp = new WinFormsField("MENU-ITEM-PSP", "PSP. Payment Setup Menu", "PaymentSetupMenu");
        public static WinFormsField MenuItemSsp = new WinFormsField("MENU-ITEM-SSP", "SSP. Default Service Providers", "DefaultServiceProviders");
        public static WinFormsField MenuItemSgc = new WinFormsField("MENU-ITEM-SGC", "SGC. Generic Code Table", "GenericCodeTable");
        public static WinFormsField MenuItemSor = new WinFormsField("MENU-ITEM-SOR", "SOR. Originating Systems", "OriginatingSystems");
        public static WinFormsField MenuItemSsf = new WinFormsField("MENU-ITEM-SSF", "SSF. Providers/Service Codes", "Providers/ServiceCodes");
        public static WinFormsField MenuItemSde = new WinFormsField("MENU-ITEM-SDE", "SDE. Department Codes", "DepartmentCodes");
        public static WinFormsField MenuItemSbn = new WinFormsField("MENU-ITEM-SBN", "SBN. Branch Codes", "BranchCodes");
        public static WinFormsField MenuItemWtt = new WinFormsField("MENU-ITEM-WTT", "WTT. Workflow Transaction Types", "WorkflowTransactionTypes");
        public static WinFormsField MenuItemPss = new WinFormsField("MENU-ITEM-PSS", "PSS. Process Steps Setup Menu", "ProcessStepsSetupMenu");
        public static WinFormsField MenuItemEcm = new WinFormsField("MENU-ITEM-ECM", "ECM. External Contact Maintenance Menu", "ExternalContactMaintenanceMenu");
        public static WinFormsField MenuItemFsm = new WinFormsField("MENU-ITEM-FSM", "FSM. FTP Setup Menu", "FTPSetupMenu");
    }
}