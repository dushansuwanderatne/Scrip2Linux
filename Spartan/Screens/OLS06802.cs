using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS06802

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS06802", "FormName");
		//Fields


        public static WinFormsField TransactionDesc = new WinFormsField("TRANSACTION-DESC", "TransactionDesc");
        public static WinFormsField Name1 = new WinFormsField("NAME-1", "Name1");
        public static WinFormsField Status1 = new WinFormsField("STATUS-1", "Status1");
        public static WinFormsField Name2 = new WinFormsField("NAME-2", "Name2");
        public static WinFormsField Status2 = new WinFormsField("STATUS-2", "Status2");
        public static WinFormsField Name3 = new WinFormsField("NAME-3", "Name3");
        public static WinFormsField Status3 = new WinFormsField("STATUS-3", "Status3");
        public static WinFormsField Name4 = new WinFormsField("NAME-4", "Name4");
        public static WinFormsField Status4 = new WinFormsField("STATUS-4", "Status4");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
