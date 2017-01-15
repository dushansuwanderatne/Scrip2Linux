using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SDS03020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SDS03020", "FormName");
		//Fields


        public static WinFormsField Allot120Totals = new WinFormsField("ALLOT1-20-TOTALS", "Allot120Totals");
        public static WinFormsField ClassGroup = new WinFormsField("CLASS-GROUP", "ClassGroup");
        public static WinFormsField RangeTable = new WinFormsField("RANGE-TABLE", "RangeTable");
        public static WinFormsField AllotClass = new WinFormsField("ALLOT-CLASS", "AllotClass");
        public static WinFormsField RefundClass = new WinFormsField("REFUND-CLASS", "RefundClass");
        public static WinFormsField AllotedGrandTotal = new WinFormsField("ALLOTED-GRAND-TOTAL", "AllotedGrandTotal");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
