using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00113

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00113", "FormName");
		//Fields
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField MenuItemAwd = new WinFormsField("MENU-ITEM-AWD", "AWD. Awards", "Awards");
        public static WinFormsField MenuItemInm = new WinFormsField("MENU-ITEM-INM", "INM. Multiple Awards - Health & Integrity Check", "MultipleAwards-Health&IntegrityCheck");
        public static WinFormsField MenuItemUpm = new WinFormsField("MENU-ITEM-UPM", "UPM. Multiple Awards - Bulk Upload Process", "MultipleAwards-BulkUploadProcess");
        public static WinFormsField MenuItemSat = new WinFormsField("MENU-ITEM-SAT", "SAT. Sales and Transfers", "SalesandTransfers");
        public static WinFormsField MenuItemFat = new WinFormsField("MENU-ITEM-FAT", "FAT. Forfeitures and Terminations", "ForfeituresandTerminations");
        public static WinFormsField MenuItemPay = new WinFormsField("MENU-ITEM-PAY", "PAY. Payments", "Payments");
        public static WinFormsField MenuItemRel = new WinFormsField("MENU-ITEM-REL", "REL. Releases", "Releases");
        public static WinFormsField MenuItemRes = new WinFormsField("MENU-ITEM-RES", "RES. Residual Releases", "ResidualReleases");
        public static WinFormsField MenuItemRpm = new WinFormsField("MENU-ITEM-RPM", "RPM. Release Phantom Matching", "ReleasePhantomMatching");
        public static WinFormsField MenuItemRev = new WinFormsField("MENU-ITEM-REV", "REV. Bulk Transaction Reversal", "BulkTransactionReversal");
        public static WinFormsField MenuItemEvt = new WinFormsField("MENU-ITEM-EVT", "EVT. Event Processing", "EventProcessing");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
