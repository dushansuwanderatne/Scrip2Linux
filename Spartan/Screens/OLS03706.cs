using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS03706

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS03706", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField TransferNumber = new WinFormsField("TRANSFER-NUMBER", "TransferNumber");
        public static WinFormsField CBrokerCode = new WinFormsField("C-BROKER-CODE", "CBrokerCode");
        public static WinFormsField NBrokerCode = new WinFormsField("N-BROKER-CODE", "NBrokerCode");
        public static WinFormsField CBrokerAddressLine = new WinFormsField("C-BROKER-ADDRESS-LINE", "CBrokerAddressLine");
        public static WinFormsField NBrokerAddressLine = new WinFormsField("N-BROKER-ADDRESS-LINE", "NBrokerAddressLine");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
