using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PMHCOY02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PMHCOY02", "FormName");
		//Fields


        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField OldCode1 = new WinFormsField("OLD-CODE-1", "OldCode1");
        public static WinFormsField OldDesc = new WinFormsField("OLD-DESC", "OldDesc");
        public static WinFormsField NewCode5 = new WinFormsField("NEW-CODE-5", "NewCode5");
        public static WinFormsField ChequeFrom = new WinFormsField("CHEQUE-FROM", "ChequeFrom");
        public static WinFormsField ChequeTO = new WinFormsField("CHEQUE-TO", "ChequeTO");
    }
}
