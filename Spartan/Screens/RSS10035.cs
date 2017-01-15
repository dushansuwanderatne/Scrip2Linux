using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS10035
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS10035", "FormName");
        //Fields
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField HolderOtherTaxCode = new WinFormsField("HOLDER-OTHER-TAX-CODE", "HolderOtherTaxCode");
        public static WinFormsField HolderGroupCode = new WinFormsField("HOLDER-GROUP-CODE", "HolderGroupCode");
        public static WinFormsField HolderStatusFlags = new WinFormsField("HOLDER-STATUS-FLAGS", "HolderStatusFlags");
        public static WinFormsField HstDeceased = new WinFormsField("HST-DECEASED", "HstDeceased");
        public static WinFormsField HstException = new WinFormsField("HST-EXCEPTION", "HstException");
        public static WinFormsField HstStopTrade = new WinFormsField("HST-STOP-TRADE", "HstStopTrade");
        public static WinFormsField HstAnnualReport = new WinFormsField("HST-ANNUAL-REPORT", "HstAnnualReport");
        public static WinFormsField HstDividendReport = new WinFormsField("HST-DIVIDEND-REPORT", "HstDividendReport");
        public static WinFormsField HolderVariableFlags = new WinFormsField("HOLDER-VARIABLE-FLAGS", "HolderVariableFlags");
        public static WinFormsField VariableField = new WinFormsField("VARIABLE-FIELD", "VariableField");
        public static WinFormsField TfnDesc = new WinFormsField("TFN-DESC", "TfnDesc");
        public static WinFormsField HolderDates = new WinFormsField("HOLDER-DATES", "HolderDates");
        public static WinFormsField MailUnclaimedDate = new WinFormsField("MAIL-UNCLAIMED-DATE", "MailUnclaimedDate");
        public static WinFormsField HolderONDate = new WinFormsField("HOLDER-ON-DATE", "HolderONDate");
        public static WinFormsField HolderOffDate = new WinFormsField("HOLDER-OFF-DATE", "HolderOffDate");
        public static WinFormsField HolderAddedDate = new WinFormsField("HOLDER-ADDED-DATE", "HolderAddedDate");
        public static WinFormsField HolderBirthDate = new WinFormsField("HOLDER-BIRTH-DATE", "HolderBirthDate");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField USTaxDetails = new WinFormsField("US-TAX-DETAILS", "USTaxDetails");
        public static WinFormsField IrlTaxDetails = new WinFormsField("IRL-TAX-DETAILS", "IrlTaxDetails");
        public static WinFormsField ZafTaxDetails = new WinFormsField("ZAF-TAX-DETAILS", "ZafTaxDetails");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}