using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CONHELLO

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CONHELLO", "FormName");
		//Fields


        public static WinFormsField MenuItemCC = new WinFormsField("MENU-ITEM-CC", "CC. Change Conversion Codes", "ChangeConversionCodes");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit Conversion Code Entry", "ExitConversionCodeEntry");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField OldUfd = new WinFormsField("OLD-UFD", "OldUfd");
        public static WinFormsField NewUfd = new WinFormsField("NEW-UFD", "NewUfd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
