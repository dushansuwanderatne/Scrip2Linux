using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01027

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01027", "FormName");
		//Fields


        public static WinFormsField ForeignMarketPrice = new WinFormsField("FOREIGN-MARKET-PRICE", "ForeignMarketPrice");
        public static WinFormsField FepCorrectInd = new WinFormsField("FEP-CORRECT-IND", "FepCorrectInd");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
