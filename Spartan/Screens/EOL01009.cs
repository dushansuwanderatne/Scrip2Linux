using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL01009

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL01009", "FormName");
		//Fields


        public static WinFormsField NameAddress = new WinFormsField("NAME-ADDRESS", "NameAddress");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField Usan = new WinFormsField("USAN", "Usan");
        public static WinFormsField TransReversalArray = new WinFormsField("TRANS-REVERSAL-ARRAY", "TransReversalArray");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
