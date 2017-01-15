using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS01500

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS01500", "FormName");
		//Fields
        public static WinFormsField MenuItemSet = new WinFormsField("MENU-ITEM-SET", "SET. Shareholder Entry", "ShareholderEntry");
        public static WinFormsField MenuItemNet = new WinFormsField("MENU-ITEM-NET", "NET. Nominated Persons Entry", "NominatedPersonsEntry");
        public static WinFormsField MenuItemVet = new WinFormsField("MENU-ITEM-VET", "VET. Visitor Entry", "VisitorEntry");
        public static WinFormsField MenuItemDel = new WinFormsField("MENU-ITEM-DEL", "DEL. Delete Shareholder/Nominated Person Entry", "DeleteShareholder/NominatedPersonEntry");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
