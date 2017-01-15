using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS00107

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS00107", "FormName");
		//Fields


        public static WinFormsField MenuItemFbchg = new WinFormsField("MENU-ITEM-FBCHG", "FBCHG. (F)aster (B)roker/HIN (C)hange - (Global Broker Code Change)", "(F)aster(B)roker/HIN(C)hange-(GlobalBrokerCodeChange)");
        public static WinFormsField MenuItemIrchg = new WinFormsField("MENU-ITEM-IRCHG", "IRCHG. (I)ssuer (R)egister Code (C)hange", "(I)ssuer(R)egisterCode(C)hange");
        public static WinFormsField MenuItemBcchg = new WinFormsField("MENU-ITEM-BCCHG", "BCCHG. (B)roker (C)ode (C)hange - (Transaction Broker Code Change)", "(B)roker(C)ode(C)hange-(TransactionBrokerCodeChange)");
        public static WinFormsField MenuItemRtchg = new WinFormsField("MENU-ITEM-RTCHG", "RTCHG. (R)eference (T)otr/Tetr (C)hange", "(R)eference(T)otr/Tetr(C)hange");
        public static WinFormsField MenuItemDtchg = new WinFormsField("MENU-ITEM-DTCHG", "DTCHG. (D)ate (C)hange", "(D)ate(C)hange");
        public static WinFormsField MenuItemDivhs = new WinFormsField("MENU-ITEM-DIVHS", "DIVHS. Adjustment Transaction on DIVHIS", "AdjustmentTransactiononDIVHIS");
        public static WinFormsField MenuItemCumhs = new WinFormsField("MENU-ITEM-CUMHS", "CUMHS. Adjustment Transaction on CUMHIS", "AdjustmentTransactiononCUMHIS");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
