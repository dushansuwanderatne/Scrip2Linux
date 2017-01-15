using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL014WN

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL014WN", "FormName");
		//Fields


        public static WinFormsField TotalMoney = new WinFormsField("TOTAL-MONEY", "TotalMoney");
        public static WinFormsField ReservedMoney = new WinFormsField("RESERVED-MONEY", "ReservedMoney");
        public static WinFormsField TransMoney = new WinFormsField("TRANS-MONEY", "TransMoney");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
