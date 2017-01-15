using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00106

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00106", "FormName");
		//Fields


        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterDescription = new WinFormsField("REGISTER-DESCRIPTION", "RegisterDescription");
        public static WinFormsField RegisterType = new WinFormsField("REGISTER-TYPE", "RegisterType");
        public static WinFormsField MenuItemEssal = new WinFormsField("MENU-ITEM-ESSAL", "ESSAL. Sale Release", "SaleRelease");
        public static WinFormsField MenuItemEsrvo = new WinFormsField("MENU-ITEM-ESRVO", "ESRVO. Reverse Sale Release", "ReverseSaleRelease");
        public static WinFormsField MenuItemEscrs = new WinFormsField("MENU-ITEM-ESCRS", "ESCRS. Transfer to Main Register", "TransfertoMainRegister");
        public static WinFormsField MenuItemEsrvr = new WinFormsField("MENU-ITEM-ESRVR", "ESRVR. Reverse Transfer to Main Register", "ReverseTransfertoMainRegister");
        public static WinFormsField MenuItemEscns = new WinFormsField("MENU-ITEM-ESCNS", "ESCNS. Convert to Company Nominee", "ConverttoCompanyNominee");
        public static WinFormsField MenuItemEsthp = new WinFormsField("MENU-ITEM-ESTHP", "ESTHP. Transfer to Third Party", "TransfertoThirdParty");
        public static WinFormsField MenuItemEsrvu = new WinFormsField("MENU-ITEM-ESRVU", "ESRVU. Reverse Transfer to Third Party", "ReverseTransfertoThirdParty");
        public static WinFormsField MenuItemEsisa = new WinFormsField("MENU-ITEM-ESISA", "ESISA. Transfer to ISA", "TransfertoISA");
        public static WinFormsField MenuItemEsrvv = new WinFormsField("MENU-ITEM-ESRVV", "ESRVV. Reverse Transfer to ISA", "ReverseTransfertoISA");
        public static WinFormsField MenuItemEspol = new WinFormsField("MENU-ITEM-ESPOL", "ESPOL. Leave in Pool Account", "LeaveinPoolAccount");
        public static WinFormsField MenuItemEswth = new WinFormsField("MENU-ITEM-ESWTH", "ESWTH. Withdraw Savings only", "WithdrawSavingsonly");
        public static WinFormsField MenuItemRrh = new WinFormsField("MENU-ITEM-RRH", "RRH.   Release Remaining Holdings", "ReleaseRemainingHoldings");
        public static WinFormsField MenuItemRph = new WinFormsField("MENU-ITEM-RPH", "RPH.   Release Partnership/Bonus Savings", "ReleasePartnership/BonusSavings");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
