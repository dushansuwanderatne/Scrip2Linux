using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BSS00102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BSS00102", "FormName");
		//Fields


        public static WinFormsField MenuItemHI = new WinFormsField("MENU-ITEM-HI", "HI. Header Information", "HeaderInformation");
        public static WinFormsField MenuItemSP = new WinFormsField("MENU-ITEM-SP", "SP. Special Processing", "SpecialProcessing");
        public static WinFormsField MenuItemHM = new WinFormsField("MENU-ITEM-HM", "HM. Holder Maintenance", "HolderMaintenance");
        public static WinFormsField MenuItemMC = new WinFormsField("MENU-ITEM-MC", "MC. Mailing Companies", "MailingCompanies");
        public static WinFormsField MenuItemEH = new WinFormsField("MENU-ITEM-EH", "EH. Extra Holder Maintenance", "ExtraHolderMaintenance");
        public static WinFormsField MenuItemTP = new WinFormsField("MENU-ITEM-TP", "TP. Transaction Processing", "TransactionProcessing");
        public static WinFormsField MenuItemSU = new WinFormsField("MENU-ITEM-SU", "SU. Sundries", "Sundries");
        public static WinFormsField MenuItemBD = new WinFormsField("MENU-ITEM-BD", "BD. Backup Data (Magnet)", "BackupData(Magnet)");
        public static WinFormsField MenuItemPC = new WinFormsField("MENU-ITEM-PC", "PC. Paper Charges", "PaperCharges");
        public static WinFormsField MenuItemMS = new WinFormsField("MENU-ITEM-MS", "MS. Messaging Charges", "MessagingCharges");
        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoDate6 = new WinFormsField("SYSTEM-INFO-DATE-6", "10", "10");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 4", "4");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField ClientDesc = new WinFormsField("CLIENT-DESC", "ClientDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
