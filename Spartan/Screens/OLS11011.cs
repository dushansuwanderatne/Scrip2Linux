using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS11011

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS11011", "FormName");
		//Fields


        public static WinFormsField FileName = new WinFormsField("FILE-NAME", "FileName");
        public static WinFormsField ChequeCount = new WinFormsField("CHEQUE-COUNT", "ChequeCount");
        public static WinFormsField ChequeAmount = new WinFormsField("CHEQUE-AMOUNT", "ChequeAmount");
        public static WinFormsField Confirmation = new WinFormsField("CONFIRMATION", "Confirmation");
    }
}
