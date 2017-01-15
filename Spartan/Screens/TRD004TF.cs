using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRD004TF

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRD004TF", "FormName");
		//Fields


        public static WinFormsField ConfirmFunds = new WinFormsField("CONFIRM-FUNDS", "ConfirmFunds");
    }
}
