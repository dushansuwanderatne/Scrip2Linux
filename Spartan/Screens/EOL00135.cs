using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00135

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00135", "FormName");
		//Fields
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField EventType = new WinFormsField("EVENT-TYPE", "EventType");
        public static WinFormsField EventCode = new WinFormsField("EVENT-CODE", "EventCode");
        public static WinFormsField EventDescription = new WinFormsField("EVENT-DESCRIPTION", "EventDescription");
        public static WinFormsField EventDate = new WinFormsField("EVENT-DATE", "EventDate");
        public static WinFormsField MenuItemAdd = new WinFormsField("MENU-ITEM-ADD", "ADD. Add Holder Event", "AddHolderEvent");
        public static WinFormsField MenuItemChg = new WinFormsField("MENU-ITEM-CHG", "CHG. Change Holder Event ", "ChangeHolderEvent");
        public static WinFormsField MenuItemDel = new WinFormsField("MENU-ITEM-DEL", "DEL. Delete Holder Event", "DeleteHolderEvent");
        public static WinFormsField MenuItemTax = new WinFormsField("MENU-ITEM-TAX", "TAX. Update Holder Tax/International Assignee Details", "UpdateHolderTax/InternationalAssigneeDetails");
        public static WinFormsField MenuItemDtx = new WinFormsField("MENU-ITEM-DTX", "DTX. Delete Holder Tax/International Assignee Details", "DeleteHolderTax/InternationalAssigneeDetails");
        public static WinFormsField MenuItemInt = new WinFormsField("MENU-ITEM-INT", "INT. Health & Integrity Check (Update Holder Tax/International Assignee Details)", "Health&IntegrityCheck(UpdateHolderTax/InternationalAssigneeDetails)");
        public static WinFormsField MenuItemUpl = new WinFormsField("MENU-ITEM-UPL", "UPL. Bulk Upload Process (Update Holder Tax/International Assignee Details)", "BulkUploadProcess(UpdateHolderTax/InternationalAssigneeDetails)");
        public static WinFormsField MenuItemEla = new WinFormsField("MENU-ITEM-ELA", "ELA. Add Holder Election Details", "AddHolderElectionDetails");
        public static WinFormsField MenuItemElc = new WinFormsField("MENU-ITEM-ELC", "ELC. Change Holder Election Details", "ChangeHolderElectionDetails");
        public static WinFormsField MenuItemEld = new WinFormsField("MENU-ITEM-ELD", "ELD. Delete Holder Election Details", "DeleteHolderElectionDetails");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
