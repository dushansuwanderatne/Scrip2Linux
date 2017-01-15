using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class XTT2

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("XTT2", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField HolderOtherTaxCode = new WinFormsField("HOLDER-OTHER-TAX-CODE", "HolderOtherTaxCode");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField MailUnclaimedDate = new WinFormsField("MAIL-UNCLAIMED-DATE", "MailUnclaimedDate");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField HolderAlternateID = new WinFormsField("HOLDER-ALTERNATE-ID", "HolderAlternateID");
        public static WinFormsField HolderGroupCode = new WinFormsField("HOLDER-GROUP-CODE", "HolderGroupCode");
        public static WinFormsField VariableField = new WinFormsField("VARIABLE-FIELD", "VariableField");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
        public static WinFormsField HstDeceased = new WinFormsField("HST-DECEASED", "HstDeceased");
        public static WinFormsField HstException = new WinFormsField("HST-EXCEPTION", "HstException");
        public static WinFormsField HvfFlag = new WinFormsField("HVF-FLAG", "HvfFlag");
        public static WinFormsField HstSuppress = new WinFormsField("HST-SUPPRESS", "HstSuppress");
        public static WinFormsField HstStopTrade = new WinFormsField("HST-STOP-TRADE", "HstStopTrade");
        public static WinFormsField HstAnnualReport = new WinFormsField("HST-ANNUAL-REPORT", "HstAnnualReport");
        public static WinFormsField Htn1 = new WinFormsField("HTN-1", "Htn1");
        public static WinFormsField PrintOption = new WinFormsField("PRINT-OPTION", "PrintOption");
        public static WinFormsField Htn2 = new WinFormsField("HTN-2", "Htn2");
        public static WinFormsField Filler1 = new WinFormsField("FILLER1", "Filler1");
        public static WinFormsField Filler2 = new WinFormsField("FILLER2", "Filler2");
        public static WinFormsField Filler3 = new WinFormsField("FILLER3", "Filler3");
    }
}
