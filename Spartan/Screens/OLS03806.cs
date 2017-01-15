using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS03806

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS03806", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField RecordDate = new WinFormsField("RECORD-DATE", "RecordDate");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField CorporateAction = new WinFormsField("CORPORATE-ACTION", "CorporateAction");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField CumBalance = new WinFormsField("CUM-BALANCE", "CumBalance");
        public static WinFormsField FromHolderID = new WinFormsField("FROM-HOLDER-ID", "FromHolderID");
        public static WinFormsField TOHolderID = new WinFormsField("TO-HOLDER-ID", "TOHolderID");
        public static WinFormsField FromAddressLine = new WinFormsField("FROM-ADDRESS-LINE", "FromAddressLine");
        public static WinFormsField TOAddressLine = new WinFormsField("TO-ADDRESS-LINE", "TOAddressLine");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
