using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS02502

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS02502", "FormName");
		//Fields


        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField AddressLines = new WinFormsField("ADDRESS-LINES", "AddressLines");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField CurrentBalance = new WinFormsField("CURRENT-BALANCE", "CurrentBalance");
        public static WinFormsField AvailableBalance = new WinFormsField("AVAILABLE-BALANCE", "AvailableBalance");
        public static WinFormsField ReservationFin = new WinFormsField("RESERVATION-FIN", "ReservationFin");
        public static WinFormsField ConfirmUnits = new WinFormsField("CONFIRM-UNITS", "ConfirmUnits");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Warnings = new WinFormsField("WARNINGS", "Warnings");
        public static WinFormsField ConfirmDeceased = new WinFormsField("CONFIRM-DECEASED", "ConfirmDeceased");
        public static WinFormsField ConfirmReturnMail = new WinFormsField("CONFIRM-RETURN-MAIL", "ConfirmReturnMail");
        public static WinFormsField ReservationFinX9 = new WinFormsField("RESERVATION-FIN-X9", "ReservationFinX9");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
