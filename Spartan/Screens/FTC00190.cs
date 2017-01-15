using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FTC00190

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FTC00190", "FormName");
		//Fields


        public static WinFormsField MenuItemL = new WinFormsField("MENU-ITEM-L", "L.  Ladder", "Ladder");
        public static WinFormsField MenuItemF = new WinFormsField("MENU-ITEM-F", "F.  Form Guide", "FormGuide");
        public static WinFormsField MenuItemH = new WinFormsField("MENU-ITEM-H", "H.  Head to Head", "HeadtoHead");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}
