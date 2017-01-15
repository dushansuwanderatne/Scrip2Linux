using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS10010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS10010", "FormName");
		//Fields


        public static WinFormsField MenuItemIB = new WinFormsField("MENU-ITEM-IB", "IB. Issue/Balance", "Issue/Balance");
        public static WinFormsField MenuItemCS = new WinFormsField("MENU-ITEM-CS", "CS. Certificates", "Certificates");
        public static WinFormsField MenuItemNA = new WinFormsField("MENU-ITEM-NA", "NA. Name & Address", "Name&Address");
        public static WinFormsField MenuItemSR = new WinFormsField("MENU-ITEM-SR", "SR. Static transactions/Return Mail", "Statictransactions/ReturnMail");
        public static WinFormsField MenuItemHF = new WinFormsField("MENU-ITEM-HF", "HF. Holder Flags", "HolderFlags");
        public static WinFormsField MenuItemHU = new WinFormsField("MENU-ITEM-HU", "HU. Holder User Defined Flags", "HolderUserDefinedFlags");
        public static WinFormsField MenuItemTS = new WinFormsField("MENU-ITEM-TS", "TS. Tax Selection", "TaxSelection");
        public static WinFormsField MenuItemNS = new WinFormsField("MENU-ITEM-NS", "NS. Notings", "Notings");
        public static WinFormsField MenuItemPI = new WinFormsField("MENU-ITEM-PI", "PI. Payment Instruction", "PaymentInstruction");
        public static WinFormsField MenuItemXT = new WinFormsField("MENU-ITEM-XT", "XT. Extract File Details", "ExtractFileDetails");
        public static WinFormsField MenuItemSJ = new WinFormsField("MENU-ITEM-SJ", "SJ. Schedule Job", "ScheduleJob");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
