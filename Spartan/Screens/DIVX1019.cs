using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVX1019

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVX1019", "FormName");
		//Fields


        public static WinFormsField ReduceRefClass = new WinFormsField("REDUCE-REF-CLASS", "ReduceRefClass");
        public static WinFormsField RefundClass = new WinFormsField("REFUND-CLASS", "RefundClass");
    }
}
