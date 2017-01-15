using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSDIS06

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSDIS06", "FormName");
		//Fields


        public static WinFormsField Ensdis06BankType = new WinFormsField("ENSDIS06-BANK-TYPE", "Ensdis06BankType");
        public static WinFormsField Ensdis06BankCodeX = new WinFormsField("ENSDIS06-BANK-CODE-X", "Ensdis06BankCodeX");
        public static WinFormsField Ensdis06BankAccount = new WinFormsField("ENSDIS06-BANK-ACCOUNT", "Ensdis06BankAccount");
    }
}
