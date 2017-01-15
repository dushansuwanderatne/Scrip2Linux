using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HENSLID

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HENSLID", "FormName");
		//Fields


        public static WinFormsField MenuItemMore = new WinFormsField("MENU-ITEM-More", "More.", "");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
