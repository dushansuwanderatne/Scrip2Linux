using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ONLSCH01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ONLSCH01", "FormName");
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
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegCode = new WinFormsField("REG-CODE", "RegCode");
        public static WinFormsField Warning = new WinFormsField("WARNING", "Warning");
        public static WinFormsField CertID = new WinFormsField("CERT-ID", "CertID");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField IssueDate = new WinFormsField("ISSUE-DATE", "IssueDate");
        public static WinFormsField CertInd = new WinFormsField("CERT-IND", "CertInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Method = new WinFormsField("METHOD", "Method");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
    }
}
