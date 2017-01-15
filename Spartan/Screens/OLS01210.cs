using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01210

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01210", "FormName");
		//Fields
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField BrokerNameKey = new WinFormsField("BROKER-NAME-KEY", "BrokerNameKey");
        public static WinFormsField RegisterDesc = new WinFormsField("REGISTER-DESC", "RegisterDesc");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
        public static WinFormsField Line = new WinFormsField("LINE", "Line");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField DomicileName = new WinFormsField("DOMICILE-NAME", "DomicileName");
        public static WinFormsField BirthDate = new WinFormsField("BIRTH-DATE", "BirthDate");
        public static WinFormsField UpdateTfn = new WinFormsField("UPDATE-TFN", "UpdateTfn");
        public static WinFormsField UpdateExt = new WinFormsField("UPDATE-EXT", "UpdateExt");
        public static WinFormsField UpdateEmp = new WinFormsField("UPDATE-EMP", "UpdateEmp");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
