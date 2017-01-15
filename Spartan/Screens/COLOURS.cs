using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class COLOURS

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("COLOURS", "FormName");
		//Fields


        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit", "Exit");
    }
}
