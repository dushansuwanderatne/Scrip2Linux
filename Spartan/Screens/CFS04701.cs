using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS04701

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS04701", "FormName");
		//Fields


        public static WinFormsField MenuItemFds = new WinFormsField("MENU-ITEM-FDS", "FDS. FTP Destination Setup", "FTPDestinationSetup");
        public static WinFormsField MenuItemFgs = new WinFormsField("MENU-ITEM-FGS", "FGS. File Group Setup", "FileGroupSetup");
        public static WinFormsField MenuItemFts = new WinFormsField("MENU-ITEM-FTS", "FTS. File Type Setup", "FileTypeSetup");
        public static WinFormsField MenuItemFgt = new WinFormsField("MENU-ITEM-FGT", "FGT. File Group / File Type Mapping", "FileGroup/FileTypeMapping");
        public static WinFormsField MenuItemFgd = new WinFormsField("MENU-ITEM-FGD", "FGD. File Group / FTP Destination Mapping", "FileGroup/FTPDestinationMapping");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
