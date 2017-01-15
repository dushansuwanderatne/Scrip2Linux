using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class STAB0410

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("STAB0410", "FormName");
		//Fields


        public static WinFormsField StartCqnNum = new WinFormsField("START-CQN-NUM", "StartCqnNum");
        public static WinFormsField EndCqnNum = new WinFormsField("END-CQN-NUM", "EndCqnNum");
        public static WinFormsField LastChqFrom = new WinFormsField("LAST-CHQ-FROM", "LastChqFrom");
        public static WinFormsField LastChqTO = new WinFormsField("LAST-CHQ-TO", "LastChqTO");
        public static WinFormsField ChequeIssued = new WinFormsField("CHEQUE-ISSUED", "ChequeIssued");
        public static WinFormsField StartHid = new WinFormsField("START-HID", "StartHid");
        public static WinFormsField EndHid = new WinFormsField("END-HID", "EndHid");
        public static WinFormsField FirstHid = new WinFormsField("FIRST-HID", "FirstHid");
        public static WinFormsField LastHid = new WinFormsField("LAST-HID", "LastHid");
    }
}
