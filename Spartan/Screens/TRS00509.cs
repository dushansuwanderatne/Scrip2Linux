using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRS00509

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRS00509", "FormName");
		//Fields


        public static WinFormsField TradingID = new WinFormsField("TRADING-ID", "TradingID");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField AddMsgid = new WinFormsField("ADD-MSGID", "AddMsgid");
        public static WinFormsField AddDate = new WinFormsField("ADD-DATE", "AddDate");
        public static WinFormsField AddTime = new WinFormsField("ADD-TIME", "AddTime");
        public static WinFormsField PaymentDesc = new WinFormsField("PAYMENT-DESC", "PaymentDesc");
        public static WinFormsField Currency = new WinFormsField("CURRENCY", "Currency");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
