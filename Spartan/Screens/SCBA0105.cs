using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SCBA0105

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SCBA0105", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField MoneyInput = new WinFormsField("MONEY-INPUT", "MoneyInput");
        public static WinFormsField Shares = new WinFormsField("SHARES", "Shares");
        public static WinFormsField Price = new WinFormsField("PRICE", "Price");
        public static WinFormsField MoneyCalc = new WinFormsField("MONEY-CALC", "MoneyCalc");
        public static WinFormsField Accept = new WinFormsField("ACCEPT", "Accept");
    }
}
