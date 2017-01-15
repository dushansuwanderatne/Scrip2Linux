using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS02102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS02102", "FormName");
		//Fields


        public static WinFormsField PayTOHeadOffice = new WinFormsField("PAY-TO-HEAD-OFFICE", "PayTOHeadOffice");
        public static WinFormsField HeadOffice = new WinFormsField("HEAD-OFFICE", "HeadOffice");
        public static WinFormsField HofficeNA = new WinFormsField("HOFFICE-NA", "HofficeNA");
        public static WinFormsField CreditorCode = new WinFormsField("CREDITOR-CODE", "CreditorCode");
        public static WinFormsField AlphaBroker = new WinFormsField("ALPHA-BROKER", "AlphaBroker");
    }
}
