using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FLT01060

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FLT01060", "FormName");
		//Fields


        public static WinFormsField GroupClassNumber = new WinFormsField("GROUP-CLASS-NUMBER", "GroupClassNumber");
        public static WinFormsField ExceptionRangeFrom = new WinFormsField("EXCEPTION-RANGE-FROM", "ExceptionRangeFrom");
        public static WinFormsField ExceptionRangeTO = new WinFormsField("EXCEPTION-RANGE-TO", "ExceptionRangeTO");
    }
}
