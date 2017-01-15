using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLFLT02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLFLT02", "FormName");
		//Fields


        public static WinFormsField MenuItemFltab = new WinFormsField("MENU-ITEM-FLTAB", "FLTAB. Add Application and Bank Deposit", "AddApplicationandBankDeposit");
        public static WinFormsField MenuItemFltaa = new WinFormsField("MENU-ITEM-FLTAA", "FLTAA. Add Application", "AddApplication");
        public static WinFormsField MenuItemFltad = new WinFormsField("MENU-ITEM-FLTAD", "FLTAD. Add Bank Deposit", "AddBankDeposit");
        public static WinFormsField MenuItemFltdd = new WinFormsField("MENU-ITEM-FLTDD", "FLTDD. Delete application Details", "DeleteapplicationDetails");
        public static WinFormsField MenuItemFltaj = new WinFormsField("MENU-ITEM-FLTAJ", "FLTAJ. Application Adjustment", "ApplicationAdjustment");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField TransOption = new WinFormsField("TRANS-OPTION", "TransOption");
    }
}
