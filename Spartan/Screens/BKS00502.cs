using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BKS00502

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BKS00502", "FormName");
		//Fields


        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField BankAccount = new WinFormsField("BANK-ACCOUNT", "BankAccount");
        public static WinFormsField BankFormat = new WinFormsField("BANK-FORMAT", "BankFormat");
        public static WinFormsField PropertyLine = new WinFormsField("PROPERTY-LINE", "PropertyLine");
        public static WinFormsField MappingRule = new WinFormsField("MAPPING-RULE", "MappingRule");
        public static WinFormsField SystemInfoDate5 = new WinFormsField("SYSTEM-INFO-DATE-5", "9", "9");
    }
}
