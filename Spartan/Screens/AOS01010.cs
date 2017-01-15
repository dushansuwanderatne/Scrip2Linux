using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class AOS01010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("AOS01010", "FormName");
		//Fields


        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField MenuItemNA = new WinFormsField("MENU-ITEM-NA", "NA.  Name", "Name");
        public static WinFormsField MenuItemAD = new WinFormsField("MENU-ITEM-AD", "AD.  Address", "Address");
        public static WinFormsField MenuItemEM = new WinFormsField("MENU-ITEM-EM", "EM.  E-Mail", "E-Mail");
        public static WinFormsField MenuItemPH = new WinFormsField("MENU-ITEM-PH", "PH.  Phone", "Phone");
        public static WinFormsField MenuItemPI = new WinFormsField("MENU-ITEM-PI", "PI.  Payment Instructions", "PaymentInstructions");
        public static WinFormsField AssociatedNameID = new WinFormsField("ASSOCIATED-NAME-ID", "AssociatedNameID");
        public static WinFormsField AssociatedName = new WinFormsField("ASSOCIATED-NAME", "AssociatedName");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
    }
}
