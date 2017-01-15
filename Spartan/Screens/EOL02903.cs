using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL02903

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL02903", "FormName");
		//Fields
        public static WinFormsField WitholdingTaxRate = new WinFormsField("WITHOLDING-TAX-RATE", "WitholdingTaxRate");
        public static WinFormsField WitholdingTaxCode = new WinFormsField("WITHOLDING-TAX-CODE", "WitholdingTaxCode");
        public static WinFormsField MarketValueType = new WinFormsField("MARKET-VALUE-TYPE", "MarketValueType");
        public static WinFormsField ComplexHolderCode = new WinFormsField("COMPLEX-HOLDER-CODE", "ComplexHolderCode");
    }
}
