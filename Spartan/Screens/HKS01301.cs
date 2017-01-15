using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01301

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01301", "FormName");
		//Fields


        public static WinFormsField MenuItemHld = new WinFormsField("MENU-ITEM-HLD", "HLD.  Holder Variable Flags", "HolderVariableFlags");
        public static WinFormsField MenuItemHvf = new WinFormsField("MENU-ITEM-HVF", "HVF.  Holder Variable Field Description", "HolderVariableFieldDescription");
        public static WinFormsField MenuItemCrt = new WinFormsField("MENU-ITEM-CRT", "CRT.  Certificate Flag Descriptions", "CertificateFlagDescriptions");
        public static WinFormsField MenuItemExc = new WinFormsField("MENU-ITEM-EXC", "EXC.  Holder Exception Flag Values", "HolderExceptionFlagValues");
        public static WinFormsField MenuItemTbg = new WinFormsField("MENU-ITEM-TBG", "TBG.  Transaction Billing Group Descriptions", "TransactionBillingGroupDescriptions");
        public static WinFormsField MenuItemAnr = new WinFormsField("MENU-ITEM-ANR", "ANR.  Annual Report Flag", "AnnualReportFlag");
        public static WinFormsField MenuItemHew = new WinFormsField("MENU-ITEM-HEW", "HEW.  Holder Extra Warning Flags", "HolderExtraWarningFlags");
        public static WinFormsField MenuItemAlc = new WinFormsField("MENU-ITEM-ALC", "ALC.  Alternate Id Codes", "AlternateIdCodes");
        public static WinFormsField MenuItemEss = new WinFormsField("MENU-ITEM-ESS", "ESS.  Employee Status Flag", "EmployeeStatusFlag");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField MenuOption = new WinFormsField("MENU-OPTION", "MenuOption");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
