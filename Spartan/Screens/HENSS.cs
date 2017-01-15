using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HENSS

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HENSS", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1.  Locating a holder via name", "Locatingaholdervianame");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2.  Locating a holder via number", "Locatingaholdervianumber");
        public static WinFormsField MenuItem3 = new WinFormsField("MENU-ITEM-3", "3.  Locating a holder via HIN (FAST)", "LocatingaholderviaHIN(FAST)");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
