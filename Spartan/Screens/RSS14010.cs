using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS14010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS14010", "FormName");
		//Fields


        public static WinFormsField Offer1Class = new WinFormsField("OFFER1-CLASS", "Offer1Class");
        public static WinFormsField Offer1Desc = new WinFormsField("OFFER1-DESC", "Offer1Desc");
        public static WinFormsField Offer1Value = new WinFormsField("OFFER1-VALUE", "Offer1Value");
        public static WinFormsField Offer2Class = new WinFormsField("OFFER2-CLASS", "Offer2Class");
        public static WinFormsField Offer2Desc = new WinFormsField("OFFER2-DESC", "Offer2Desc");
        public static WinFormsField Offer2Value = new WinFormsField("OFFER2-VALUE", "Offer2Value");
    }
}
