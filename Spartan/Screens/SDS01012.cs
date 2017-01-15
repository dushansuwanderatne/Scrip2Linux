using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SDS01012

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SDS01012", "FormName");
		//Fields


        public static WinFormsField AllotError = new WinFormsField("ALLOT-ERROR", "AllotError");
        public static WinFormsField AllotClass = new WinFormsField("ALLOT-CLASS", "AllotClass");
        public static WinFormsField RefundError = new WinFormsField("REFUND-ERROR", "RefundError");
        public static WinFormsField RefundClass = new WinFormsField("REFUND-CLASS", "RefundClass");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
