using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDMNU02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDMNU02", "FormName");
		//Fields
        public static WinFormsField CurrentFlag = new WinFormsField("CURRENT-FLAG", "CurrentFlag");
        public static WinFormsField TradingCode = new WinFormsField("TRADING-CODE", "TradingCode");
        public static WinFormsField TradeDesc = new WinFormsField("TRADE-DESC", "TradeDesc");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField BulkType = new WinFormsField("BULK-TYPE", "BulkType");
        public static WinFormsField BulkProcessing = new WinFormsField("BULK-PROCESSING", "BulkProcessing");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField DPOrderType = new WinFormsField("DP-ORDER-TYPE", "DPOrderType");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
