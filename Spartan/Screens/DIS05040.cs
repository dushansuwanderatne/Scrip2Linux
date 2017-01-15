using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIS05040

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIS05040", "FormName");
		//Fields


        public static WinFormsField CostSharesKnownInd = new WinFormsField("COST-SHARES-KNOWN-IND", "CostSharesKnownInd");
        public static WinFormsField KnowBefPayDateInd = new WinFormsField("KNOW-BEF-PAY-DATE-IND", "KnowBefPayDateInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
