using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SESTOT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SESTOT01", "FormName");
		//Fields


        public static WinFormsField MenuItemD = new WinFormsField("MENU-ITEM-D", "D. Display Session Totals", "DisplaySessionTotals");
        public static WinFormsField MenuItemP = new WinFormsField("MENU-ITEM-P", "P. Print ALL Session Totals", "PrintALLSessionTotals");
        public static WinFormsField MenuItemR = new WinFormsField("MENU-ITEM-R", "R. Run Status Enquiry", "RunStatusEnquiry");
        public static WinFormsField MenuItemS = new WinFormsField("MENU-ITEM-S", "S. Select Session Number", "SelectSessionNumber");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
        public static WinFormsField SessionNumber = new WinFormsField("SESSION-NUMBER", "SessionNumber");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
