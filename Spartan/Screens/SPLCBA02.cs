using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLCBA02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLCBA02", "FormName");
		//Fields


        public static WinFormsField MenuItemCbaad = new WinFormsField("MENU-ITEM-CBAAD", "CBAAD.  Add Bank Deposit", "AddBankDeposit");
        public static WinFormsField MenuItemCbaaa = new WinFormsField("MENU-ITEM-CBAAA", "CBAAA.  Add Application Details", "AddApplicationDetails");
        public static WinFormsField MenuItemCbadd = new WinFormsField("MENU-ITEM-CBADD", "CBADD.  Delete Application Details", "DeleteApplicationDetails");
        public static WinFormsField MenuItemCbacd = new WinFormsField("MENU-ITEM-CBACD", "CBACD.  Change Application Details", "ChangeApplicationDetails");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField TransOption = new WinFormsField("TRANS-OPTION", "TransOption");
    }
}
