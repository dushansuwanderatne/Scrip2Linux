using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV01014

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV01014", "FormName");
		//Fields


        public static WinFormsField ReduceRefClass = new WinFormsField("REDUCE-REF-CLASS", "ReduceRefClass");
        public static WinFormsField RefundClass = new WinFormsField("REFUND-CLASS", "RefundClass");
    }
}
