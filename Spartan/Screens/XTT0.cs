using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class XTT0

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("XTT0", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField BatchNbr = new WinFormsField("BATCH-NBR", "BatchNbr");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField StartingTransNumber = new WinFormsField("STARTING-TRANS-NUMBER", "StartingTransNumber");
        public static WinFormsField TotalBuyUnits = new WinFormsField("TOTAL-BUY-UNITS", "TotalBuyUnits");
        public static WinFormsField TotalSellUnits = new WinFormsField("TOTAL-SELL-UNITS", "TotalSellUnits");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField OrderNumber = new WinFormsField("ORDER-NUMBER", "OrderNumber");
        public static WinFormsField OpsInitials = new WinFormsField("OPS-INITIALS", "OpsInitials");
        public static WinFormsField Filler1 = new WinFormsField("FILLER1", "Filler1");
        public static WinFormsField Filler2 = new WinFormsField("FILLER2", "Filler2");
    }
}
