using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PPS00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PPS00101", "FormName");
		//Fields


        public static WinFormsField MenuItemRun = new WinFormsField("MENU-ITEM-RUN", "RUN. Current Run Details", "CurrentRunDetails");
        public static WinFormsField MenuItemDrp = new WinFormsField("MENU-ITEM-DRP", "DRP. Reinvestment Details", "ReinvestmentDetails");
        public static WinFormsField MenuItemFmt = new WinFormsField("MENU-ITEM-FMT", "FMT. Run Format Details", "RunFormatDetails");
        public static WinFormsField MenuItemTax = new WinFormsField("MENU-ITEM-TAX", "TAX. Tax Tape Output Details", "TaxTapeOutputDetails");
        public static WinFormsField MenuItemCL = new WinFormsField("MENU-ITEM-CL", "CL. Class Details", "ClassDetails");
        public static WinFormsField MenuItemNZ = new WinFormsField("MENU-ITEM-NZ", "NZ. New Zealand Details", "NewZealandDetails");
        public static WinFormsField MenuItemBlk = new WinFormsField("MENU-ITEM-BLK", "BLK. Bulk Payment Details", "BulkPaymentDetails");
        public static WinFormsField MenuItemPcr = new WinFormsField("MENU-ITEM-PCR", "PCR. Print current Run Summary", "PrintcurrentRunSummary");
        public static WinFormsField MenuItemPfd = new WinFormsField("MENU-ITEM-PFD", "PFD. Print Full Details", "PrintFullDetails");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
