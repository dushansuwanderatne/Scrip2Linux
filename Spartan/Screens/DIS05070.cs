using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIS05070

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIS05070", "FormName");
		//Fields


        public static WinFormsField DividendSource = new WinFormsField("DIVIDEND-SOURCE", "DividendSource");
        public static WinFormsField Selcat = new WinFormsField("SELCAT", "Selcat");
        public static WinFormsField CostShares1 = new WinFormsField("COST-SHARES-1", "CostShares1");
        public static WinFormsField CostShares2 = new WinFormsField("COST-SHARES-2", "CostShares2");
        public static WinFormsField CostShares3 = new WinFormsField("COST-SHARES-3", "CostShares3");
        public static WinFormsField CostShares4 = new WinFormsField("COST-SHARES-4", "CostShares4");
        public static WinFormsField CostShares5 = new WinFormsField("COST-SHARES-5", "CostShares5");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
