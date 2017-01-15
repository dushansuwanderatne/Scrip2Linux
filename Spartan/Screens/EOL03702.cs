using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL03702

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL03702", "FormName");
		//Fields


        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField DeclarationRecdInd = new WinFormsField("DECLARATION-RECD-IND", "DeclarationRecdInd");
        public static WinFormsField FinYear = new WinFormsField("FIN-YEAR", "FinYear");
    }
}
