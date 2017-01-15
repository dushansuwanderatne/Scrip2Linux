using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MAL00102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MAL00102", "FormName");
		//Fields


        public static WinFormsField MenuItemMcu = new WinFormsField("MENU-ITEM-MCU", "MCU. Mailing Control File Update", "MailingControlFileUpdate");
        public static WinFormsField MenuItemCfu = new WinFormsField("MENU-ITEM-CFU", "CFU. Company File Update", "CompanyFileUpdate");
        public static WinFormsField MenuItemNgc = new WinFormsField("MENU-ITEM-NGC", "NGC. Nominate System Group Codes", "NominateSystemGroupCodes");
        public static WinFormsField MenuItemGcu = new WinFormsField("MENU-ITEM-GCU", "GCU. Group Code Update", "GroupCodeUpdate");
        public static WinFormsField MenuItemDmp = new WinFormsField("MENU-ITEM-DMP", "DMP. Setup a Dump", "SetupaDump");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit from System", "ExitfromSystem");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
