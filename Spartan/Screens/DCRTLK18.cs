using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DCRTLK18

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DCRTLK18", "FormName");
		//Fields


        public static WinFormsField BuySplitNumber = new WinFormsField("BUY-SPLIT-NUMBER", "BuySplitNumber");
        public static WinFormsField BuySplitUnits = new WinFormsField("BUY-SPLIT-UNITS", "BuySplitUnits");
        public static WinFormsField CumCorporateAction = new WinFormsField("CUM-CORPORATE-ACTION", "CumCorporateAction");
        public static WinFormsField CumTotalUnits = new WinFormsField("CUM-TOTAL-UNITS", "CumTotalUnits");
        public static WinFormsField ReissueTranType = new WinFormsField("REISSUE-TRAN-TYPE", "ReissueTranType");
        public static WinFormsField TakeoverCode = new WinFormsField("TAKEOVER-CODE", "TakeoverCode");
        public static WinFormsField BuyCertIndicator = new WinFormsField("BUY-CERT-INDICATOR", "BuyCertIndicator");
    }
}
