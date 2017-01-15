using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFN10

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFN10", "FormName");
		//Fields


        public static WinFormsField MenuItemPrint = new WinFormsField("MENU-ITEM-PRINT", "PRINT. Display/Select Print File to Print", "Display/SelectPrintFiletoPrint");
        public static WinFormsField MenuItemPevt = new WinFormsField("MENU-ITEM-PEVT", "PEVT. Print Event Totals", "PrintEventTotals");
        public static WinFormsField MenuItemLaser = new WinFormsField("MENU-ITEM-LASER", "LASER. Display/Select Print File to Print", "Display/SelectPrintFiletoPrint");
        public static WinFormsField MenuItemLook = new WinFormsField("MENU-ITEM-LOOK", "LOOK. Look At a Print File", "LookAtaPrintFile");
        public static WinFormsField MenuItemDss = new WinFormsField("MENU-ITEM-DSS", "DSS.   Select Print File to Index on the DSS", "SelectPrintFiletoIndexontheDSS");
        public static WinFormsField MenuItemSave = new WinFormsField("MENU-ITEM-SAVE", "SAVE. Save a Print File", "SaveaPrintFile");
        public static WinFormsField MenuItemPqlst = new WinFormsField("MENU-ITEM-PQLST", "PQLST. Display Print QUEUE List", "DisplayPrintQUEUEList");
        public static WinFormsField MenuItemDel = new WinFormsField("MENU-ITEM-DEL", "DEL. Delete a Print File", "DeleteaPrintFile");
        public static WinFormsField MenuItemCancl = new WinFormsField("MENU-ITEM-CANCL", "CANCL. Cancel a Print File From QUEUE", "CancelaPrintFileFromQUEUE");
        public static WinFormsField MenuItemDfpc = new WinFormsField("MENU-ITEM-DFPC", "DFPC. Download File to PC", "DownloadFiletoPC");
        public static WinFormsField MenuItemPrtxt = new WinFormsField("MENU-ITEM-PRTXT", "PRTXT. Run Print EXTRACT", "RunPrintEXTRACT");
        public static WinFormsField MenuItemUpld = new WinFormsField("MENU-ITEM-UPLD", "UPLD. Upload a File From PC", "UploadaFileFromPC");
        public static WinFormsField MenuItemDrop = new WinFormsField("MENU-ITEM-DROP", "DROP. Stop File Printing on Current Printer", "StopFilePrintingonCurrentPrinter");
        public static WinFormsField MenuItemRhpf = new WinFormsField("MENU-ITEM-RHPF", "RHPF. Release HELD print file", "ReleaseHELDprintfile");
        public static WinFormsField MenuItemSC = new WinFormsField("MENU-ITEM-SC", "SC. Select Company", "SelectCompany");
        public static WinFormsField MenuItemCufd = new WinFormsField("MENU-ITEM-CUFD", "CUFD. Change current directory", "Changecurrentdirectory");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
    }
}
