using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01017

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01017", "FormName");
		//Fields
        public static WinFormsField ExtraBankCode = new WinFormsField("EXTRA-BANK-CODE", "ExtraBankCode");
        public static WinFormsField ExtraAccountNO = new WinFormsField("EXTRA-ACCOUNT-NO", "ExtraAccountNO");
        public static WinFormsField ExtraRunNumber = new WinFormsField("EXTRA-RUN-NUMBER", "ExtraRunNumber");
        public static WinFormsField ExtraPayTransNO = new WinFormsField("EXTRA-PAY-TRANS-NO", "ExtraPayTransNO");
        public static WinFormsField ExtraAccountName = new WinFormsField("EXTRA-ACCOUNT-NAME", "ExtraAccountName");
    }
}
