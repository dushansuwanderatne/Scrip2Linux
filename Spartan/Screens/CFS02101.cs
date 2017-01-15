using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS02101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS02101", "FormName");
		//Fields


        public static WinFormsField CurrencyCode = new WinFormsField("CURRENCY-CODE", "CurrencyCode");
        public static WinFormsField CurrencyDescription = new WinFormsField("CURRENCY-DESCRIPTION", "CurrencyDescription");
        public static WinFormsField BdpPlural = new WinFormsField("BDP-PLURAL", "BdpPlural");
        public static WinFormsField BdpSingular = new WinFormsField("BDP-SINGULAR", "BdpSingular");
        public static WinFormsField AdpPlural = new WinFormsField("ADP-PLURAL", "AdpPlural");
        public static WinFormsField AdpSingular = new WinFormsField("ADP-SINGULAR", "AdpSingular");
        public static WinFormsField DecimalPlaces = new WinFormsField("DECIMAL-PLACES", "DecimalPlaces");
        public static WinFormsField ChequeFlag = new WinFormsField("CHEQUE-FLAG", "ChequeFlag");
        public static WinFormsField WireFlag = new WinFormsField("WIRE-FLAG", "WireFlag");
        public static WinFormsField FgnPayThresholdFC = new WinFormsField("FGN-PAY-THRESHOLD-FC", "FgnPayThresholdFC");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
