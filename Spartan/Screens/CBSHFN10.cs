using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBSHFN10

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBSHFN10", "FormName");
		//Fields


        public static WinFormsField MenuItemDfpc = new WinFormsField("MENU-ITEM-DFPC", "DFPC.     Download file to PC", "DownloadfiletoPC");
        public static WinFormsField MenuItemPrint = new WinFormsField("MENU-ITEM-PRINT", "PRINT.    Select a file to print", "Selectafiletoprint");
        public static WinFormsField MenuItemLook = new WinFormsField("MENU-ITEM-LOOK", "LOOK.     Look at a Print File", "LookataPrintFile");
        public static WinFormsField MenuItemLaser = new WinFormsField("MENU-ITEM-LASER", "LASER.    Select a file to print", "Selectafiletoprint");
        public static WinFormsField MenuItemDel = new WinFormsField("MENU-ITEM-DEL", "DEL.      Delete a Print file", "DeleteaPrintfile");
        public static WinFormsField MenuItemUpld = new WinFormsField("MENU-ITEM-UPLD", "UPLD.     Upload a file to Host", "UploadafiletoHost");
        public static WinFormsField MenuItemLkupl = new WinFormsField("MENU-ITEM-LKUPL", "LKUPL.    Look at an Uploaded file", "LookatanUploadedfile");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit this menu", "Exitthismenu");
        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
