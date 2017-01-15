using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HENSMAIN

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HENSMAIN", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1.  Overview/Explanation", "Overview/Explanation");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2.  Locating options", "Locatingoptions");
        public static WinFormsField MenuItem3 = new WinFormsField("MENU-ITEM-3", "3.  Display options for a holder", "Displayoptionsforaholder");
        public static WinFormsField MenuItem4 = new WinFormsField("MENU-ITEM-4", "4.  Printing options", "Printingoptions");
        public static WinFormsField MenuItem5 = new WinFormsField("MENU-ITEM-5", "5.  Extract options", "Extractoptions");
        public static WinFormsField MenuItem6 = new WinFormsField("MENU-ITEM-6", "6.  Company options", "Companyoptions");
    }
}
