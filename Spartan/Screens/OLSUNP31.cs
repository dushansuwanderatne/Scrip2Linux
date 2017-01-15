using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSUNP31

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSUNP31", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField SellerNamekey = new WinFormsField("SELLER-NAMEKEY", "SellerNamekey");
        public static WinFormsField BuyerNamekey = new WinFormsField("BUYER-NAMEKEY", "BuyerNamekey");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
