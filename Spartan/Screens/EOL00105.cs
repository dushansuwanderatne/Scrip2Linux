using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00105

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00105", "FormName");
		//Fields


        public static WinFormsField MenuItemEsapt = new WinFormsField("MENU-ITEM-ESAPT", "ESAPT. Appropriation Transfer", "AppropriationTransfer");
        public static WinFormsField MenuItemEsrvt = new WinFormsField("MENU-ITEM-ESRVT", "ESRVT. Disposal Transfer Reversal", "DisposalTransferReversal");
        public static WinFormsField MenuItemEsdtc = new WinFormsField("MENU-ITEM-ESDTC", "ESDTC. Disposal Tax Calculation", "DisposalTaxCalculation");
        public static WinFormsField MenuItemEsaps = new WinFormsField("MENU-ITEM-ESAPS", "ESAPS. Appropriation Sale", "AppropriationSale");
        public static WinFormsField MenuItemEsrvs = new WinFormsField("MENU-ITEM-ESRVS", "ESRVS. Appropriation Sale Reversal", "AppropriationSaleReversal");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField RegisterType = new WinFormsField("REGISTER-TYPE", "RegisterType");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
