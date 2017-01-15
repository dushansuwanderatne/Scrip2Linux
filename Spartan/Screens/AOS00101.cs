using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class AOS00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("AOS00101", "FormName");
		//Fields


        public static WinFormsField MenuItemFD = new WinFormsField("MENU-ITEM-FD", "FD.  Full Details", "FullDetails");
        public static WinFormsField MenuItemNA = new WinFormsField("MENU-ITEM-NA", "NA.  Name and Address", "NameandAddress");
        public static WinFormsField MenuItemNM = new WinFormsField("MENU-ITEM-NM", "NM.  Name", "Name");
        public static WinFormsField MenuItemAD = new WinFormsField("MENU-ITEM-AD", "AD.  Address", "Address");
        public static WinFormsField MenuItemEM = new WinFormsField("MENU-ITEM-EM", "EM.  E-Mail", "E-Mail");
        public static WinFormsField MenuItemPI = new WinFormsField("MENU-ITEM-PI", "PI.  Payment Instruction", "PaymentInstruction");
        public static WinFormsField MenuItemPH = new WinFormsField("MENU-ITEM-PH", "PH.  Phone Number", "PhoneNumber");
        public static WinFormsField MenuItemCD = new WinFormsField("MENU-ITEM-CD", "CD.  Change Delete Record", "ChangeDeleteRecord");
        public static WinFormsField MenuItemAS = new WinFormsField("MENU-ITEM-AS", "AS.  Associate Records", "AssociateRecords");
        public static WinFormsField MenuItemDS = new WinFormsField("MENU-ITEM-DS", "DS.  Disassociate Records", "DisassociateRecords");
        public static WinFormsField MenuItemNT = new WinFormsField("MENU-ITEM-NT", "NT.  Noting", "Noting");
        public static WinFormsField MenuItemIN = new WinFormsField("MENU-ITEM-IN", "IN.  Incident", "Incident");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit ONLINE System", "ExitONLINESystem");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
    }
}
