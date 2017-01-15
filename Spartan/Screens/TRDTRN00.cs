using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDTRN00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDTRN00", "FormName");
		//Fields


        public static WinFormsField TradingID = new WinFormsField("TRADING-ID", "TradingID");
        public static WinFormsField DlgTransNumber = new WinFormsField("DLG-TRANS-NUMBER", "DlgTransNumber");
        public static WinFormsField VersionNumber = new WinFormsField("VERSION-NUMBER", "VersionNumber");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoTime1 = new WinFormsField("SYSTEM-INFO-TIME-1", "1", "1");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
