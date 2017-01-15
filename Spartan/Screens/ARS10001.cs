using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ARS10001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ARS10001", "FormName");
		//Fields


        public static WinFormsField MenuItemNM = new WinFormsField("MENU-ITEM-NM", "NM.  Name", "Name");
        public static WinFormsField MenuItemAD = new WinFormsField("MENU-ITEM-AD", "AD.  Address", "Address");
        public static WinFormsField MenuItemEM = new WinFormsField("MENU-ITEM-EM", "EM.  E-Mail", "E-Mail");
        public static WinFormsField MenuItemPI = new WinFormsField("MENU-ITEM-PI", "PI.  Payment Instructions", "PaymentInstructions");
        public static WinFormsField MenuItemPH = new WinFormsField("MENU-ITEM-PH", "PH.  Phone Numbers", "PhoneNumbers");
        public static WinFormsField MenuItemNA = new WinFormsField("MENU-ITEM-NA", "NA.  Name Associated", "NameAssociated");
        public static WinFormsField MenuItemNT = new WinFormsField("MENU-ITEM-NT", "NT.  Notings", "Notings");
        public static WinFormsField MenuItemIN = new WinFormsField("MENU-ITEM-IN", "IN.  Incidents", "Incidents");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit Extract Reporting", "ExitExtractReporting");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
