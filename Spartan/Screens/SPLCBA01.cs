using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLCBA01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLCBA01", "FormName");
		//Fields


        public static WinFormsField MenuItemBU = new WinFormsField("MENU-ITEM-BU", "BU. Batch Register Updating", "BatchRegisterUpdating");
        public static WinFormsField MenuItemSB = new WinFormsField("MENU-ITEM-SB", "SB. Special Batch Register Updating", "SpecialBatchRegisterUpdating");
        public static WinFormsField MenuItemBC = new WinFormsField("MENU-ITEM-BC", "BC. Box Contents Report", "BoxContentsReport");
        public static WinFormsField MenuItemCU = new WinFormsField("MENU-ITEM-CU", "CU. CBA Branch Update/Enquiry", "CBABranchUpdate/Enquiry");
        public static WinFormsField MenuItemAA = new WinFormsField("MENU-ITEM-AA", "AA. Application Adjustment", "ApplicationAdjustment");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST. Schedule Tape Processing", "ScheduleTapeProcessing");
        public static WinFormsField MenuItemCR = new WinFormsField("MENU-ITEM-CR", "CR. Cumulative Reporting", "CumulativeReporting");
        public static WinFormsField MenuItemBR = new WinFormsField("MENU-ITEM-BR", "BR. Batch Register Reporting", "BatchRegisterReporting");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. EXIT from special options", "EXITfromspecialoptions");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}
