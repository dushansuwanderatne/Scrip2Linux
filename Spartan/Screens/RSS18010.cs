using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS18010
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS18010", "FormName");
        //Fields
        public static WinFormsField MenuItemSH = new WinFormsField("MENU-ITEM-SH", "SH.  Significant Holder Report", "SignificantHolderReport");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST.  Significant Trade Report", "SignificantTradeReport");
        public static WinFormsField MenuItemSM = new WinFormsField("MENU-ITEM-SM", "SM.  Shareholder Movement Report", "ShareholderMovementReport");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
