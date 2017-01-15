using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS03708

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS03708", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField TradeReference = new WinFormsField("TRADE-REFERENCE", "TradeReference");
        public static WinFormsField TransferNumber = new WinFormsField("TRANSFER-NUMBER", "TransferNumber");
        public static WinFormsField CurTranDate = new WinFormsField("CUR-TRAN-DATE", "CurTranDate");
        public static WinFormsField NewTranDate = new WinFormsField("NEW-TRAN-DATE", "NewTranDate");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
