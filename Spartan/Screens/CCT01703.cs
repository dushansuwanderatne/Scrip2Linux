using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CCT01703

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CCT01703", "FormName");
		//Fields


        public static WinFormsField FullTransactionID = new WinFormsField("FULL-TRANSACTION-ID", "FullTransactionID");
        public static WinFormsField TargetTransID = new WinFormsField("TARGET-TRANS-ID", "TargetTransID");
    }
}
