using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS00001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS00001", "FormName");
		//Fields


        public static WinFormsField MenuItemScd = new WinFormsField("MENU-ITEM-SCD", "SCD. Client Description", "ClientDescription");
        public static WinFormsField MenuItemScc = new WinFormsField("MENU-ITEM-SCC", "SCC. Client/Company", "Client/Company");
        public static WinFormsField MenuItemSus = new WinFormsField("MENU-ITEM-SUS", "SUS. User Security", "UserSecurity");
        public static WinFormsField MenuItemSsg = new WinFormsField("MENU-ITEM-SSG", "SSG. Security Group Description", "SecurityGroupDescription");
        public static WinFormsField MenuItemSsa = new WinFormsField("MENU-ITEM-SSA", "SSA. Security ASX code file", "SecurityASXcodefile");
        public static WinFormsField MenuItemSec = new WinFormsField("MENU-ITEM-SEC", "SEC. Event Control", "EventControl");
        public static WinFormsField MenuItemSmc = new WinFormsField("MENU-ITEM-SMC", "SMC. Mailing House Control", "MailingHouseControl");
        public static WinFormsField MenuItemSct = new WinFormsField("MENU-ITEM-SCT", "SCT. CHESS Control", "CHESSControl");
        public static WinFormsField MenuItemScr = new WinFormsField("MENU-ITEM-SCR", "SCR. CREST Control", "CRESTControl");
        public static WinFormsField MenuItemSgr = new WinFormsField("MENU-ITEM-SGR", "SGR. CREST Requests", "CRESTRequests");
        public static WinFormsField MenuItemScs = new WinFormsField("MENU-ITEM-SCS", "SCS. SCRIPCOMMS Interface Control File", "SCRIPCOMMSInterfaceControlFile");
        public static WinFormsField MenuItemSpc = new WinFormsField("MENU-ITEM-SPC", "SPC. Company Trading Volumes", "CompanyTradingVolumes");
        public static WinFormsField MenuItemCcu = new WinFormsField("MENU-ITEM-CCU", "CCU. CHAMP Control File Update", "CHAMPControlFileUpdate");
        public static WinFormsField MenuItemIud = new WinFormsField("MENU-ITEM-IUD", "IUD. IVRUser Description", "IVRUserDescription");
        public static WinFormsField MenuItemIuc = new WinFormsField("MENU-ITEM-IUC", "IUC. IVRUser Company", "IVRUserCompany");
        public static WinFormsField MenuItemAmg = new WinFormsField("MENU-ITEM-AMG", "AMG. Migration Codes Maintenance (AMG interface)", "MigrationCodesMaintenance(AMGinterface)");
        public static WinFormsField MenuItemCsh = new WinFormsField("MENU-ITEM-CSH", "CSH. Cash Reconciliation Codes", "CashReconciliationCodes");
        public static WinFormsField MenuItemBam = new WinFormsField("MENU-ITEM-BAM", "BAM. Bank Account Maintenance", "BankAccountMaintenance");
        public static WinFormsField MenuItemExc = new WinFormsField("MENU-ITEM-EXC", "EXC. Exchange Codes", "ExchangeCodes");
        public static WinFormsField MenuItemWld = new WinFormsField("MENU-ITEM-WLD", "WLD. Citibank Company Worldlink File", "CitibankCompanyWorldlinkFile");
        public static WinFormsField MenuItemSbt = new WinFormsField("MENU-ITEM-SBT", "SBT. Bank Types", "BankTypes");
        public static WinFormsField MenuItemJob = new WinFormsField("MENU-ITEM-JOB", "JOB. Global Job Scheduler Utility", "GlobalJobSchedulerUtility");
    }
}
