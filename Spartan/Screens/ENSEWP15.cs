using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSEWP15

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSEWP15", "FormName");
		//Fields


        public static WinFormsField BillingCount = new WinFormsField("BILLING-COUNT", "BillingCount");
        public static WinFormsField SingleSearches = new WinFormsField("SINGLE-SEARCHES", "SingleSearches");
        public static WinFormsField MultiSearches = new WinFormsField("MULTI-SEARCHES", "MultiSearches");
        public static WinFormsField PageForward = new WinFormsField("PAGE-FORWARD", "PageForward");
        public static WinFormsField PageBackward = new WinFormsField("PAGE-BACKWARD", "PageBackward");
        public static WinFormsField HH = new WinFormsField("HH", "HH");
        public static WinFormsField MM = new WinFormsField("MM", "MM");
    }
}
