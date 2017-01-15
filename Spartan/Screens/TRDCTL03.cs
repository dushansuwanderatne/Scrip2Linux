using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDCTL03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDCTL03", "FormName");
		//Fields


        public static WinFormsField TradingCode = new WinFormsField("TRADING-CODE", "TradingCode");
        public static WinFormsField RemainingBalInd = new WinFormsField("REMAINING-BAL-IND", "RemainingBalInd");
        public static WinFormsField RemainingBalHolderID = new WinFormsField("REMAINING-BAL-HOLDER-ID", "RemainingBalHolderID");
        public static WinFormsField RemainingBalClassCode = new WinFormsField("REMAINING-BAL-CLASS-CODE", "RemainingBalClassCode");
        public static WinFormsField RemainingBalRegCode = new WinFormsField("REMAINING-BAL-REG-CODE", "RemainingBalRegCode");
        public static WinFormsField RemainingBalCertID = new WinFormsField("REMAINING-BAL-CERT-ID", "RemainingBalCertID");
        public static WinFormsField RemainingBalTranType = new WinFormsField("REMAINING-BAL-TRAN-TYPE", "RemainingBalTranType");
        public static WinFormsField VariableCommentLines = new WinFormsField("VARIABLE-COMMENT-LINES", "VariableCommentLines");
        public static WinFormsField EmailStageInd = new WinFormsField("EMAIL-STAGE-IND", "EmailStageInd");
        public static WinFormsField EmailCompanySpecific = new WinFormsField("EMAIL-COMPANY-SPECIFIC", "EmailCompanySpecific");
        public static WinFormsField EmailTemplateSuffix = new WinFormsField("EMAIL-TEMPLATE-SUFFIX", "EmailTemplateSuffix");
        public static WinFormsField NOEmailAddressAction = new WinFormsField("NO-EMAIL-ADDRESS-ACTION", "NOEmailAddressAction");
        public static WinFormsField BankAddressLine = new WinFormsField("BANK-ADDRESS-LINE", "BankAddressLine");
        public static WinFormsField WireMiscellaneous = new WinFormsField("WIRE-MISCELLANEOUS", "WireMiscellaneous");
        public static WinFormsField CountryCode = new WinFormsField("COUNTRY-CODE", "CountryCode");
        public static WinFormsField SwiftCode = new WinFormsField("SWIFT-CODE", "SwiftCode");
        public static WinFormsField SplitProceedsInd = new WinFormsField("SPLIT-PROCEEDS-IND", "SplitProceedsInd");
        public static WinFormsField AllowedDomiciles = new WinFormsField("ALLOWED-DOMICILES", "AllowedDomiciles");
        public static WinFormsField ForeignSelectInd = new WinFormsField("FOREIGN-SELECT-IND", "ForeignSelectInd");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoTime1 = new WinFormsField("SYSTEM-INFO-TIME-1", "1", "1");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
