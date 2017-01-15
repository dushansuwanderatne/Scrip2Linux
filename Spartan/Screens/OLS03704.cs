using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS03704

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS03704", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField TransferNumber = new WinFormsField("TRANSFER-NUMBER", "TransferNumber");
        public static WinFormsField CTradeReference = new WinFormsField("C-TRADE-REFERENCE", "CTradeReference");
        public static WinFormsField NTradeReference = new WinFormsField("N-TRADE-REFERENCE", "NTradeReference");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
