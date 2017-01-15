using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS04505

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS04505", "FormName");
		//Fields


        public static WinFormsField MenuItemDP = new WinFormsField("MENU-ITEM-DP", "DP.  Dividend", "Dividend");
        public static WinFormsField MenuItemBO = new WinFormsField("MENU-ITEM-BO", "BO.  Bonus", "Bonus");
        public static WinFormsField MenuItemRI = new WinFormsField("MENU-ITEM-RI", "RI.  Rights", "Rights");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField CorpActionType = new WinFormsField("CORP-ACTION-TYPE", "CorpActionType");
        public static WinFormsField PayableDate = new WinFormsField("PAYABLE-DATE", "PayableDate");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
