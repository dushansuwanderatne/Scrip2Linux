using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDORD00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDORD00", "FormName");
		//Fields


        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoTime1 = new WinFormsField("SYSTEM-INFO-TIME-1", "1", "1");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField TradingCode = new WinFormsField("TRADING-CODE", "TradingCode");
        public static WinFormsField TradingNumber = new WinFormsField("TRADING-NUMBER", "TradingNumber");
        public static WinFormsField TradingStatus = new WinFormsField("TRADING-STATUS", "TradingStatus");
        public static WinFormsField TradingType = new WinFormsField("TRADING-TYPE", "TradingType");
        public static WinFormsField TradingCodeKey1 = new WinFormsField("TRADING-CODE-KEY1", "TradingCodeKey1");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
