using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS03801

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS03801", "FormName");
		//Fields


        public static WinFormsField DomicileCode = new WinFormsField("DOMICILE-CODE", "DomicileCode");
        public static WinFormsField DomicileName = new WinFormsField("DOMICILE-NAME", "DomicileName");
        public static WinFormsField DomicileDivRate = new WinFormsField("DOMICILE-DIV-RATE", "DomicileDivRate");
        public static WinFormsField DomicileIntRate = new WinFormsField("DOMICILE-INT-RATE", "DomicileIntRate");
        public static WinFormsField DomicileAlpha2 = new WinFormsField("DOMICILE-ALPHA-2", "DomicileAlpha2");
        public static WinFormsField DomicileNum3 = new WinFormsField("DOMICILE-NUM-3", "DomicileNum3");
        public static WinFormsField CurrencyPrefix = new WinFormsField("CURRENCY-PREFIX", "CurrencyPrefix");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
