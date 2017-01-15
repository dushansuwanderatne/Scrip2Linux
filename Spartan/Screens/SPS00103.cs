using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPS00103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPS00103", "FormName");
		//Fields


        public static WinFormsField MenuItemSdp = new WinFormsField("MENU-ITEM-SDP", "SDP.  Scale Down Parameters", "ScaleDownParameters");
        public static WinFormsField MenuItemSrr = new WinFormsField("MENU-ITEM-SRR", "SRR.  Schedule Table Report", "ScheduleTableReport");
        public static WinFormsField MenuItemSas = new WinFormsField("MENU-ITEM-SAS", "SAS.  Allocate Shares to Tables", "AllocateSharestoTables");
        public static WinFormsField MenuItemScr = new WinFormsField("MENU-ITEM-SCR", "SCR.  Schedule X for Y Calculation Report", "ScheduleXforYCalculationReport");
        public static WinFormsField MenuItemSrt = new WinFormsField("MENU-ITEM-SRT", "SRT.  Select Table", "SelectTable");
        public static WinFormsField MenuItemSpd = new WinFormsField("MENU-ITEM-SPD", "SPD.  Delete Parameter File", "DeleteParameterFile");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.   Exit Scale Down Menu", "ExitScaleDownMenu");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
