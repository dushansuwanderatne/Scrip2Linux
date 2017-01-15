using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS03304

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS03304", "FormName");
		//Fields


        public static WinFormsField MenuItemBnk = new WinFormsField("MENU-ITEM-BNK", "BNK. Bank Accounts", "BankAccounts");
        public static WinFormsField MenuItemSba = new WinFormsField("MENU-ITEM-SBA", "SBA. Shared Bank Accounts", "SharedBankAccounts");
        public static WinFormsField MenuItemNsb = new WinFormsField("MENU-ITEM-NSB", "NSB. Nominate Shared Bank Accounts", "NominateSharedBankAccounts");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
