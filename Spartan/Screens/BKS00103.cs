using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BKS00103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BKS00103", "FormName");
		//Fields


        public static WinFormsField MenuItemVI = new WinFormsField("MENU-ITEM-VI", "VI.  View Input Files", "ViewInputFiles");
        public static WinFormsField MenuItemVO = new WinFormsField("MENU-ITEM-VO", "VO.  View Output Files", "ViewOutputFiles");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit", "Exit");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
