using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SUBCOY01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SUBCOY01", "FormName");
		//Fields


        public static WinFormsField SubcoyKey0 = new WinFormsField("SUBCOY-KEY0", "SubcoyKey0");
        public static WinFormsField SubCompanyCode = new WinFormsField("SUB-COMPANY-CODE", "SubCompanyCode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField SubCompanyName = new WinFormsField("SUB-COMPANY-NAME", "SubCompanyName");
        public static WinFormsField SubCompanyAbn = new WinFormsField("SUB-COMPANY-ABN", "SubCompanyAbn");
    }
}
