using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS10010
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS10010", "FormName");
        //Fields
        public static WinFormsField MenuItemCR = new WinFormsField("MENU-ITEM-CR", "CR. Class/Register/Balance", "Class/Register/Balance");
        public static WinFormsField MenuItemCS = new WinFormsField("MENU-ITEM-CS", "CS. Certificates", "Certificates");
        public static WinFormsField MenuItemRT = new WinFormsField("MENU-ITEM-RT", "RT. Registered transactions", "Registeredtransactions");
        public static WinFormsField MenuItemXT = new WinFormsField("MENU-ITEM-XT", "XT. Extract File Details", "ExtractFileDetails");
        public static WinFormsField MenuItemAT = new WinFormsField("MENU-ITEM-AT", "AT. Account types / Phone Numbers", "Accounttypes/PhoneNumbers");
        public static WinFormsField MenuItemNA = new WinFormsField("MENU-ITEM-NA", "NA. Name & Address", "Name&Address");
        public static WinFormsField MenuItemSR = new WinFormsField("MENU-ITEM-SR", "SR. Static transactions/Return Mail", "Statictransactions/ReturnMail");
        public static WinFormsField MenuItemHF = new WinFormsField("MENU-ITEM-HF", "HF. Holder Flags / Alternative IDs", "HolderFlags/AlternativeIDs");
        public static WinFormsField MenuItemHU = new WinFormsField("MENU-ITEM-HU", "HU. User Defined Holder Flags", "UserDefinedHolderFlags");
        public static WinFormsField MenuItemNS = new WinFormsField("MENU-ITEM-NS", "NS. Notings", "Notings");
        public static WinFormsField MenuItemPI = new WinFormsField("MENU-ITEM-PI", "PI. Payment Instruction", "PaymentInstruction");
        public static WinFormsField MenuItemPS = new WinFormsField("MENU-ITEM-PS", "PS. Dividend Reinvestment Plans", "DividendReinvestmentPlans");
        public static WinFormsField MenuItemTS = new WinFormsField("MENU-ITEM-TS", "TS. Tax Selection", "TaxSelection");
        public static WinFormsField MenuItemEC = new WinFormsField("MENU-ITEM-EC", "EC. Electronic Communication", "ElectronicCommunication");
        public static WinFormsField MenuItemES = new WinFormsField("MENU-ITEM-ES", "ES. Employee Static Details", "EmployeeStaticDetails");
        public static WinFormsField MenuItemSJ = new WinFormsField("MENU-ITEM-SJ", "SJ. Schedule Job", "ScheduleJob");
        public static WinFormsField MenuItemOH = new WinFormsField("MENU-ITEM-OH", "OH. Other Holder Attributes", "OtherHolderAttributes");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}