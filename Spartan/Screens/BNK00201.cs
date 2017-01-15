using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BNK00201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BNK00201", "FormName");
		//Fields


        public static WinFormsField MenuItemMpb = new WinFormsField("MENU-ITEM-MPB", "MPB.  Modify Print Batch", "ModifyPrintBatch");
        public static WinFormsField MenuItemFpb = new WinFormsField("MENU-ITEM-FPB", "FPB.  Finalise Print Batch", "FinalisePrintBatch");
        public static WinFormsField MenuItemRpb = new WinFormsField("MENU-ITEM-RPB", "RPB.  Reconcile Print Batch", "ReconcilePrintBatch");
        public static WinFormsField MenuItemApb = new WinFormsField("MENU-ITEM-APB", "APB.  Audit Print Batch", "AuditPrintBatch");
        public static WinFormsField MenuItemDpb = new WinFormsField("MENU-ITEM-DPB", "DPB.  Dispatch Print Batch", "DispatchPrintBatch");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit Cheque Printing System", "ExitChequePrintingSystem");
        public static WinFormsField SystemInfoFree2 = new WinFormsField("SYSTEM-INFO-FREE-2", "16", "16");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
