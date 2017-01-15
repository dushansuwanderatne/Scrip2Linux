using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS00102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS00102", "FormName");
		//Fields


        public static WinFormsField MenuItemCls = new WinFormsField("MENU-ITEM-CLS", "CLS. Class Control Parameters", "ClassControlParameters");
        public static WinFormsField MenuItemTtc = new WinFormsField("MENU-ITEM-TTC", "TTC. Transaction Type Codes", "TransactionTypeCodes");
        public static WinFormsField MenuItemClg = new WinFormsField("MENU-ITEM-CLG", "CLG. Class Groupings", "ClassGroupings");
        public static WinFormsField MenuItemHtc = new WinFormsField("MENU-ITEM-HTC", "HTC. Holder Type Codes", "HolderTypeCodes");
        public static WinFormsField MenuItemCfl = new WinFormsField("MENU-ITEM-CFL", "CFL. Company Flag Descriptions", "CompanyFlagDescriptions");
        public static WinFormsField MenuItemReg = new WinFormsField("MENU-ITEM-REG", "REG. Register Codes", "RegisterCodes");
        public static WinFormsField MenuItemCop = new WinFormsField("MENU-ITEM-COP", "COP. Company Options", "CompanyOptions");
        public static WinFormsField MenuItemNot = new WinFormsField("MENU-ITEM-NOT", "NOT. Company Notice Update", "CompanyNoticeUpdate");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
