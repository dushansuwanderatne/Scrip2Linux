using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS04009

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS04009", "FormName");
		//Fields


        public static WinFormsField TransactionLine = new WinFormsField("TRANSACTION-LINE", "TransactionLine");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField PageNumber = new WinFormsField("PAGE-NUMBER", "PageNumber");
    }
}
