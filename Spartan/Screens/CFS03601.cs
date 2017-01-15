using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS03601

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS03601", "FormName");
		//Fields


        public static WinFormsField MenuItemSle = new WinFormsField("MENU-ITEM-SLE", "SLE. Legal Entity", "LegalEntity");
        public static WinFormsField MenuItemSha = new WinFormsField("MENU-ITEM-SHA", "SHA. Holder Access Rules", "HolderAccessRules");
        public static WinFormsField MenuItemSac = new WinFormsField("MENU-ITEM-SAC", "SAC. Update Holder Access Codes", "UpdateHolderAccessCodes");
        public static WinFormsField MenuItemSsc = new WinFormsField("MENU-ITEM-SSC", "SSC. Source/Broker Code", "Source/BrokerCode");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
    }
}
