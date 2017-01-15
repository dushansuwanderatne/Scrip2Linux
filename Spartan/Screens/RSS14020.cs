using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS14020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS14020", "FormName");
		//Fields


        public static WinFormsField Offer1Class = new WinFormsField("OFFER1-CLASS", "Offer1Class");
        public static WinFormsField Offer1Value = new WinFormsField("OFFER1-VALUE", "Offer1Value");
        public static WinFormsField Offer2Class = new WinFormsField("OFFER2-CLASS", "Offer2Class");
        public static WinFormsField Offer2Value = new WinFormsField("OFFER2-VALUE", "Offer2Value");
    }
}
