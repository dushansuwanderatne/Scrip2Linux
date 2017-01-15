using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV01094

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV01094", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
        public static WinFormsField CostSharesTotal = new WinFormsField("COST-SHARES-TOTAL", "CostSharesTotal");
        public static WinFormsField CostSharesUnit = new WinFormsField("COST-SHARES-UNIT", "CostSharesUnit");
        public static WinFormsField CostSharesShare = new WinFormsField("COST-SHARES-SHARE", "CostSharesShare");
    }
}
