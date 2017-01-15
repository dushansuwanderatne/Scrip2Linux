using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01001", "FormName");
		//Fields
        public static WinFormsField MenuItemSch = new WinFormsField("MENU-ITEM-SCH", "SCH.  Plan Setup", "PlanSetup");
        public static WinFormsField MenuItemEvc = new WinFormsField("MENU-ITEM-EVC", "EVC.  ESS Event Control", "ESSEventControl");
        public static WinFormsField MenuItemApr = new WinFormsField("MENU-ITEM-APR", "APR.  Award Setup", "AwardSetup");
        public static WinFormsField MenuItemEvt = new WinFormsField("MENU-ITEM-EVT", "EVT.  ESS Event Setup", "ESSEventSetup");
        public static WinFormsField MenuItemCtl = new WinFormsField("MENU-ITEM-CTL", "CTL.  Control Setup", "ControlSetup");
        public static WinFormsField MenuItemEpi = new WinFormsField("MENU-ITEM-EPI", "EPI.  ESS Provider Information Setup ", "ESSProviderInformationSetup");
        public static WinFormsField MenuItemDed = new WinFormsField("MENU-ITEM-DED", "DED.  Deduction Setup", "DeductionSetup");
        public static WinFormsField MenuItemVsa = new WinFormsField("MENU-ITEM-VSA", "VSA.  VSA Jurisdiction Setup", "VSAJurisdictionSetup");
        public static WinFormsField MenuItemSoc = new WinFormsField("MENU-ITEM-SOC", "SOC.  Blackout Restricted Codes", "BlackoutRestrictedCodes");
        public static WinFormsField MenuItemBos = new WinFormsField("MENU-ITEM-BOS", "BOS.  Blackout Schedule Setup", "BlackoutScheduleSetup");
        public static WinFormsField MenuItemVst = new WinFormsField("MENU-ITEM-VST", "VST.  Vesting Schedule Setup", "VestingScheduleSetup");
        public static WinFormsField MenuItemPhd = new WinFormsField("MENU-ITEM-PHD", "PHD.  Performance Hurdle Setup", "PerformanceHurdleSetup");
        public static WinFormsField MenuItemLvs = new WinFormsField("MENU-ITEM-LVS", "LVS.  Leaver Schedule Setup", "LeaverScheduleSetup");
        public static WinFormsField MenuItemLdc = new WinFormsField("MENU-ITEM-LDC", "LDC.  Leaver Description Code", "LeaverDescriptionCode");
        public static WinFormsField MenuItemDcb = new WinFormsField("MENU-ITEM-DCB", "DCB.  ESS Bank Details Setup", "ESSBankDetailsSetup");
        public static WinFormsField MenuItemVwp = new WinFormsField("MENU-ITEM-VWP", "VWP.  Modify VWAP File", "ModifyVWAPFile");
        public static WinFormsField MenuOption = new WinFormsField("MENU-OPTION", "MenuOption");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
