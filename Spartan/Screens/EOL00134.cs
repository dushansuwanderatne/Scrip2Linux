using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00134

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00134", "FormName");
		//Fields
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField EventType = new WinFormsField("EVENT-TYPE", "EventType");
        public static WinFormsField EventCode = new WinFormsField("EVENT-CODE", "EventCode");
        public static WinFormsField EventDescription = new WinFormsField("EVENT-DESCRIPTION", "EventDescription");
        public static WinFormsField EventDate = new WinFormsField("EVENT-DATE", "EventDate");
        public static WinFormsField MenuItemSet = new WinFormsField("MENU-ITEM-SET", "SET. Bulk Holder Event Setup", "BulkHolderEventSetup");
        public static WinFormsField MenuItemUpd = new WinFormsField("MENU-ITEM-UPD", "UPD. Manual Holder Update (Menu)", "ManualHolderUpdate(Menu)");
        public static WinFormsField MenuItemRel = new WinFormsField("MENU-ITEM-REL", "REL. Release Holder Elections", "ReleaseHolderElections");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
