using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ONLSCH03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ONLSCH03", "FormName");
		//Fields


        public static WinFormsField NameKey = new WinFormsField("NAME-KEY", "NameKey");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField Type = new WinFormsField("TYPE", "Type");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Domicile = new WinFormsField("DOMICILE", "Domicile");
        public static WinFormsField OtherTaxCode = new WinFormsField("OTHER-TAX-CODE", "OtherTaxCode");
        public static WinFormsField Group = new WinFormsField("GROUP", "Group");
        public static WinFormsField Broker = new WinFormsField("BROKER", "Broker");
        public static WinFormsField FastRegister = new WinFormsField("FAST-REGISTER", "FastRegister");
        public static WinFormsField Modifier = new WinFormsField("MODIFIER", "Modifier");
        public static WinFormsField AltID = new WinFormsField("ALT-ID", "AltID");
        public static WinFormsField VariableField = new WinFormsField("VARIABLE-FIELD", "VariableField");
        public static WinFormsField Warning = new WinFormsField("WARNING", "Warning");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField RefNumber = new WinFormsField("REF-NUMBER", "RefNumber");
        public static WinFormsField PaymentMethod = new WinFormsField("PAYMENT-METHOD", "PaymentMethod");
        public static WinFormsField NettAmount = new WinFormsField("NETT-AMOUNT", "NettAmount");
        public static WinFormsField PaymentStatus = new WinFormsField("PAYMENT-STATUS", "PaymentStatus");
        public static WinFormsField PresentedDate = new WinFormsField("PRESENTED-DATE", "PresentedDate");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Method = new WinFormsField("METHOD", "Method");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
    }
}
