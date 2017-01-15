using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RMS01003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RMS01003", "FormName");
		//Fields


        public static WinFormsField Input = new WinFormsField("INPUT", "Input");
        public static WinFormsField ReceiptRoutingID = new WinFormsField("RECEIPT-ROUTING-ID", "ReceiptRoutingID");
    }
}
