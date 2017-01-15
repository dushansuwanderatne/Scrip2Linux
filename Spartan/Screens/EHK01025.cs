using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01025

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01025", "FormName");
		//Fields
        public static WinFormsField BlkoutCode = new WinFormsField("BLKOUT-CODE", "BlkoutCode");
        public static WinFormsField BlkoutDescription = new WinFormsField("BLKOUT-DESCRIPTION", "BlkoutDescription");
        public static WinFormsField BlkoutRstrctdCode = new WinFormsField("BLKOUT-RSTRCTD-CODE", "BlkoutRstrctdCode");
        public static WinFormsField BlkoutRstrctdDesc = new WinFormsField("BLKOUT-RSTRCTD-DESC", "BlkoutRstrctdDesc");
        public static WinFormsField BlkoutStartDate = new WinFormsField("BLKOUT-START-DATE", "BlkoutStartDate");
        public static WinFormsField BlkoutEndDate = new WinFormsField("BLKOUT-END-DATE", "BlkoutEndDate");
        public static WinFormsField SaleRestriction = new WinFormsField("SALE-RESTRICTION", "SaleRestriction");
        public static WinFormsField TransferRestriction = new WinFormsField("TRANSFER-RESTRICTION", "TransferRestriction");
        public static WinFormsField AllowPendingCancel = new WinFormsField("ALLOW-PENDING-CANCEL", "AllowPendingCancel");
        public static WinFormsField RestrictLimitOrders = new WinFormsField("RESTRICT-LIMIT-ORDERS", "RestrictLimitOrders");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
