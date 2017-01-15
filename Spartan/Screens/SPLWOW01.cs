using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLWOW01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLWOW01", "FormName");
		//Fields


        public static WinFormsField MenuItemItr = new WinFormsField("MENU-ITEM-ITR", "ITR. Integrity/Totals Termination Report", "Integrity/TotalsTerminationReport");
        public static WinFormsField MenuItemTP = new WinFormsField("MENU-ITEM-TP", "TP. Schedule Termination Processing", "ScheduleTerminationProcessing");
        public static WinFormsField MenuItemRed = new WinFormsField("MENU-ITEM-RED", "RED. Refresh Employee Details (on company WOW)", "RefreshEmployeeDetails(oncompanyWOW)");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit Special Processing", "ExitSpecialProcessing");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}
