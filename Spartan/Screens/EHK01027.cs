using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01027

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01027", "FormName");
		//Fields


        public static WinFormsField SaleTradeInd = new WinFormsField("SALE-TRADE-IND", "SaleTradeInd");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
