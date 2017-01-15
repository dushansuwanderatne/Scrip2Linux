using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00123

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00123", "FormName");
		//Fields
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField MenuItemAwd = new WinFormsField("MENU-ITEM-AWD", "AWD. Awards", "Awards");
        public static WinFormsField MenuItemInm = new WinFormsField("MENU-ITEM-INM", "INM. Multiple Awards - Health & Integrity Check", "MultipleAwards-Health&IntegrityCheck");
        public static WinFormsField MenuItemUpm = new WinFormsField("MENU-ITEM-UPM", "UPM. Multiple Awards - Bulk Upload Process", "MultipleAwards-BulkUploadProcess");
        public static WinFormsField MenuItemSat = new WinFormsField("MENU-ITEM-SAT", "SAT. Sales, Transfers and Forfeitures", "Sales,TransfersandForfeitures");
        public static WinFormsField MenuItemPay = new WinFormsField("MENU-ITEM-PAY", "PAY. Payments", "Payments");
        public static WinFormsField MenuItemRel = new WinFormsField("MENU-ITEM-REL", "REL. Releases", "Releases");
        public static WinFormsField MenuItemRev = new WinFormsField("MENU-ITEM-REV", "REV. Bulk Transaction Reversal", "BulkTransactionReversal");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}