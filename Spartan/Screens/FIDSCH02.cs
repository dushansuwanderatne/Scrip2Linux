using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FIDSCH02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FIDSCH02", "FormName");
		//Fields


        public static WinFormsField NameKey = new WinFormsField("NAME-KEY", "NameKey");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField Type = new WinFormsField("TYPE", "Type");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Domicile = new WinFormsField("DOMICILE", "Domicile");
        public static WinFormsField OtherTaxCode = new WinFormsField("OTHER-TAX-CODE", "OtherTaxCode");
        public static WinFormsField TaxFileNumberDesc = new WinFormsField("TAX-FILE-NUMBER-DESC", "TaxFileNumberDesc");
        public static WinFormsField Group = new WinFormsField("GROUP", "Group");
        public static WinFormsField Broker = new WinFormsField("BROKER", "Broker");
        public static WinFormsField FastRegister = new WinFormsField("FAST-REGISTER", "FastRegister");
        public static WinFormsField Modifier = new WinFormsField("MODIFIER", "Modifier");
        public static WinFormsField AltID = new WinFormsField("ALT-ID", "AltID");
        public static WinFormsField VariableField = new WinFormsField("VARIABLE-FIELD", "VariableField");
        public static WinFormsField VarFlags = new WinFormsField("VAR-FLAGS", "VarFlags");
        public static WinFormsField Warning = new WinFormsField("WARNING", "Warning");
        public static WinFormsField Deceased = new WinFormsField("DECEASED", "Deceased");
        public static WinFormsField StopTrade = new WinFormsField("STOP-TRADE", "StopTrade");
        public static WinFormsField Exception = new WinFormsField("EXCEPTION", "Exception");
        public static WinFormsField AReport = new WinFormsField("A-REPORT", "AReport");
        public static WinFormsField Suppress = new WinFormsField("SUPPRESS", "Suppress");
        public static WinFormsField Dividend = new WinFormsField("DIVIDEND", "Dividend");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Method = new WinFormsField("METHOD", "Method");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
    }
}
