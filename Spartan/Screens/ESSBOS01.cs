using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSBOS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSBOS01", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField BlkoutCode = new WinFormsField("BLKOUT-CODE", "BlkoutCode");
        public static WinFormsField BlkoutDescription = new WinFormsField("BLKOUT-DESCRIPTION", "BlkoutDescription");
        public static WinFormsField BlkoutRstrctdCode = new WinFormsField("BLKOUT-RSTRCTD-CODE", "BlkoutRstrctdCode");
        public static WinFormsField BlkoutStartDate = new WinFormsField("BLKOUT-START-DATE", "BlkoutStartDate");
        public static WinFormsField BlkoutEndDate = new WinFormsField("BLKOUT-END-DATE", "BlkoutEndDate");
        public static WinFormsField SaleRestriction = new WinFormsField("SALE-RESTRICTION", "SaleRestriction");
        public static WinFormsField TransferRestriction = new WinFormsField("TRANSFER-RESTRICTION", "TransferRestriction");
        public static WinFormsField AllowPendingCancel = new WinFormsField("ALLOW-PENDING-CANCEL", "AllowPendingCancel");
        public static WinFormsField RestrictLimitOrders = new WinFormsField("RESTRICT-LIMIT-ORDERS", "RestrictLimitOrders");
    }
}
