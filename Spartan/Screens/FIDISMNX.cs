using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FIDISMNX

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FIDISMNX", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField IssueNumber = new WinFormsField("ISSUE-NUMBER", "IssueNumber");
        public static WinFormsField TradeMinimum = new WinFormsField("TRADE-MINIMUM", "TradeMinimum");
        public static WinFormsField TradeMultiple = new WinFormsField("TRADE-MULTIPLE", "TradeMultiple");
        public static WinFormsField Accept = new WinFormsField("ACCEPT", "Accept");
    }
}
