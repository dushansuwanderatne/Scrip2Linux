using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS14015

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS14015", "FormName");
		//Fields


        public static WinFormsField OfferClass = new WinFormsField("OFFER-CLASS", "OfferClass");
        public static WinFormsField Value = new WinFormsField("VALUE", "Value");
    }
}
