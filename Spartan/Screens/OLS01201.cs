using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01201", "FormName");
		//Fields
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField TransNbrI = new WinFormsField("TRANS-NBR-I", "TransNbrI");
        public static WinFormsField TransDateI = new WinFormsField("TRANS-DATE-I", "TransDateI");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField HnaLineCh1to30R = new WinFormsField("HNA-LINE-CH1TO30-R", "HnaLineCh1to30R");
        public static WinFormsField AusPostcode = new WinFormsField("AUS-POSTCODE", "AusPostcode");
        public static WinFormsField HolderOtherTaxCode = new WinFormsField("HOLDER-OTHER-TAX-CODE", "HolderOtherTaxCode");
        public static WinFormsField Dpid = new WinFormsField("DPID", "Dpid");
        public static WinFormsField HolderGroupCode = new WinFormsField("HOLDER-GROUP-CODE", "HolderGroupCode");
        public static WinFormsField VariableField = new WinFormsField("VARIABLE-FIELD", "VariableField");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField FastRegister = new WinFormsField("FAST-REGISTER", "FastRegister");
        public static WinFormsField HolderKeyModifier = new WinFormsField("HOLDER-KEY-MODIFIER", "HolderKeyModifier");
        public static WinFormsField HolderAlternateID = new WinFormsField("HOLDER-ALTERNATE-ID", "HolderAlternateID");
        public static WinFormsField Warnings = new WinFormsField("WARNINGS", "Warnings");
        public static WinFormsField Array1 = new WinFormsField("ARRAY1", "Array1");
        public static WinFormsField HstStopTrade = new WinFormsField("HST-STOP-TRADE", "HstStopTrade");
        public static WinFormsField HvfFlag = new WinFormsField("HVF-FLAG", "HvfFlag");
        public static WinFormsField ResidencyInd = new WinFormsField("RESIDENCY-IND", "ResidencyInd");
        public static WinFormsField StaticDetailsRun = new WinFormsField("STATIC-DETAILS-RUN", "StaticDetailsRun");
        public static WinFormsField MailUnclaimedDate = new WinFormsField("MAIL-UNCLAIMED-DATE", "MailUnclaimedDate");
        public static WinFormsField HstAnnualReport = new WinFormsField("HST-ANNUAL-REPORT", "HstAnnualReport");
        public static WinFormsField ARStatusDescription = new WinFormsField("AR-STATUS-DESCRIPTION", "ARStatusDescription");
        public static WinFormsField ReferenceID = new WinFormsField("REFERENCE-ID", "ReferenceID");
        public static WinFormsField BirthDate = new WinFormsField("BIRTH-DATE", "BirthDate");
        public static WinFormsField ActionB = new WinFormsField("ACTION-B", "ActionB");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
