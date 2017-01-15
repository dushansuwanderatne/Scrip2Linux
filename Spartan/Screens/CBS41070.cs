using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS41070

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS41070", "FormName");
		//Fields


        public static WinFormsField TransferCerts = new WinFormsField("TRANSFER-CERTS", "TransferCerts");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
