using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSBLK02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSBLK02", "FormName");
		//Fields
        public static WinFormsField MenuItemBtl = new WinFormsField("MENU-ITEM-BTL", "BTL. Bulk Transaction List", "BulkTransactionList");
        public static WinFormsField MenuItemBtq = new WinFormsField("MENU-ITEM-BTQ", "BTQ. Bulk Transaction Enquiry", "BulkTransactionEnquiry");
        public static WinFormsField MenuItemBte = new WinFormsField("MENU-ITEM-BTE", "BTE. Bulk Transaction Entry", "BulkTransactionEntry");
        public static WinFormsField MenuItemBtu = new WinFormsField("MENU-ITEM-BTU", "BTU. Bulk Transaction Update", "BulkTransactionUpdate");
        public static WinFormsField MenuItemBta = new WinFormsField("MENU-ITEM-BTA", "BTA. Bulk Transaction Audit", "BulkTransactionAudit");
        public static WinFormsField MenuItemBtr = new WinFormsField("MENU-ITEM-BTR", "BTR. Bulk Transaction Range Report", "BulkTransactionRangeReport");
        public static WinFormsField MenuItemBpe = new WinFormsField("MENU-ITEM-BPE", "BPE. Bulk Process Enquiry", "BulkProcessEnquiry");
        public static WinFormsField MenuItemCbp = new WinFormsField("MENU-ITEM-CBP", "CBP. Create a New Bulk Process", "CreateaNewBulkProcess");
        public static WinFormsField MenuItemCbs = new WinFormsField("MENU-ITEM-CBS", "CBS. Change Bulk Status", "ChangeBulkStatus");
        public static WinFormsField MenuItemBpu = new WinFormsField("MENU-ITEM-BPU", "BPU. Bulk Process Update", "BulkProcessUpdate");
        public static WinFormsField MenuItemSbp = new WinFormsField("MENU-ITEM-SBP", "SBP. Settle/Register Bulk Process", "Settle/RegisterBulkProcess");
        public static WinFormsField MenuItemGcb = new WinFormsField("MENU-ITEM-GCB", "GCB. Generate Cheques, Contract Notes, Direct Banking tape", "GenerateCheques,ContractNotes,DirectBankingtape");
        public static WinFormsField MenuItemDcl = new WinFormsField("MENU-ITEM-DCL", "DCL. Direct Credit Lodgement Authority", "DirectCreditLodgementAuthority");
        public static WinFormsField MenuItemCad = new WinFormsField("MENU-ITEM-CAD", "CAD. Generate Certificates / Advices", "GenerateCertificates/Advices");
        public static WinFormsField MenuItemGsn = new WinFormsField("MENU-ITEM-GSN", "GSN. Generate Sale Notification Advice", "GenerateSaleNotificationAdvice");
        public static WinFormsField MenuItemFbs = new WinFormsField("MENU-ITEM-FBS", "FBS. Force Bulk Settlement - override automatic settlement", "ForceBulkSettlement-overrideautomaticsettlement");
        public static WinFormsField BulkCode = new WinFormsField("BULK-CODE", "BulkCode");
        public static WinFormsField BulkDesc = new WinFormsField("BULK-DESC", "BulkDesc");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
