using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG07000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG07000", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField CoyCode = new WinFormsField("COY-CODE", "CoyCode");
        public static WinFormsField CoyName = new WinFormsField("COY-NAME", "CoyName");
        public static WinFormsField OutstandingPend = new WinFormsField("OUTSTANDING-PEND", "OutstandingPend");
        public static WinFormsField BuyerUnmatchedCnt = new WinFormsField("BUYER-UNMATCHED-CNT", "BuyerUnmatchedCnt");
        public static WinFormsField BuySellUnmatchCnt = new WinFormsField("BUY-SELL-UNMATCH-CNT", "BuySellUnmatchCnt");
        public static WinFormsField FasterUnmatchedCnt = new WinFormsField("FASTER-UNMATCHED-CNT", "FasterUnmatchedCnt");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
