using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFN35

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFN35", "FormName");
		//Fields


        public static WinFormsField MenuItemCrj = new WinFormsField("MENU-ITEM-CRJ", "CRJ.  Create a Recurring Job File", "CreateaRecurringJobFile");
        public static WinFormsField MenuItemDel = new WinFormsField("MENU-ITEM-DEL", "DEL.  Delete a Recurring Job File", "DeleteaRecurringJobFile");
        public static WinFormsField MenuItemDal = new WinFormsField("MENU-ITEM-DAL", "DAL.  Delete ALL Recurring Job Files", "DeleteALLRecurringJobFiles");
        public static WinFormsField MenuItemVew = new WinFormsField("MENU-ITEM-VEW", "VEW.  View a Recurring Job File", "ViewaRecurringJobFile");
        public static WinFormsField MenuItemSC = new WinFormsField("MENU-ITEM-SC", "SC.  Select Company", "SelectCompany");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
    }
}
