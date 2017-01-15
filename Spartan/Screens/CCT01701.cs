using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CCT01701

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CCT01701", "FormName");
		//Fields


        public static WinFormsField TakeoverCode = new WinFormsField("TAKEOVER-CODE", "TakeoverCode");
        public static WinFormsField FullTransactionID = new WinFormsField("FULL-TRANSACTION-ID", "FullTransactionID");
        public static WinFormsField TargetTransID = new WinFormsField("TARGET-TRANS-ID", "TargetTransID");
    }
}
