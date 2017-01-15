using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG01004

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG01004", "FormName");
		//Fields


        public static WinFormsField MenuItemS = new WinFormsField("MENU-ITEM-S", "S.   Summary of current events", "Summaryofcurrentevents");
        public static WinFormsField MenuItemP = new WinFormsField("MENU-ITEM-P", "P.   Post event", "Postevent");
        public static WinFormsField MenuItemL = new WinFormsField("MENU-ITEM-L", "L.   List of all events", "Listofallevents");
        public static WinFormsField MenuItemC = new WinFormsField("MENU-ITEM-C", "C.   Change event contents", "Changeeventcontents");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField UserName = new WinFormsField("USER-NAME", "UserName");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
