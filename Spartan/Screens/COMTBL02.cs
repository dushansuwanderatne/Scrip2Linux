using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class COMTBL02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("COMTBL02", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ChargeCode = new WinFormsField("CHARGE-CODE", "ChargeCode");
        public static WinFormsField TestCommission = new WinFormsField("TEST-COMMISSION", "TestCommission");
        public static WinFormsField SalesTaxCode = new WinFormsField("SALES-TAX-CODE", "SalesTaxCode");
        public static WinFormsField TestSalesTax = new WinFormsField("TEST-SALES-TAX", "TestSalesTax");
    }
}
