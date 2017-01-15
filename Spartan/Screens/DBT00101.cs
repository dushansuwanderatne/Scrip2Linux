using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DBT00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DBT00101", "FormName");
		//Fields


        public static WinFormsField MenuItemEN = new WinFormsField("MENU-ITEM-EN", "EN.  Enquiries", "Enquiries");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit system", "Exitsystem");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
