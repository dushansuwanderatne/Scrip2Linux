using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS010CA

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS010CA", "FormName");
		//Fields
        public static WinFormsField AccessCode = new WinFormsField("ACCESS-CODE", "AccessCode");
        public static WinFormsField CustodianName = new WinFormsField("CUSTODIAN-NAME", "CustodianName");
    }
}
