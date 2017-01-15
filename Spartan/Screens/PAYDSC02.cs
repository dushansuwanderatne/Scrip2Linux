using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAYDSC02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAYDSC02", "FormName");
		//Fields


        public static WinFormsField PaydscKey0 = new WinFormsField("PAYDSC-KEY0", "PaydscKey0");
        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField USTaxFlag = new WinFormsField("US-TAX-FLAG", "USTaxFlag");
        public static WinFormsField IrlTaxFlag = new WinFormsField("IRL-TAX-FLAG", "IrlTaxFlag");
        public static WinFormsField ConversionRateUS = new WinFormsField("CONVERSION-RATE-US", "ConversionRateUS");
        public static WinFormsField ConversionRateIrl = new WinFormsField("CONVERSION-RATE-IRL", "ConversionRateIrl");
        public static WinFormsField USTaxYear = new WinFormsField("US-TAX-YEAR", "USTaxYear");
        public static WinFormsField IrlTaxYear = new WinFormsField("IRL-TAX-YEAR", "IrlTaxYear");
        public static WinFormsField CanTaxFlag = new WinFormsField("CAN-TAX-FLAG", "CanTaxFlag");
        public static WinFormsField ZafTaxFlag = new WinFormsField("ZAF-TAX-FLAG", "ZafTaxFlag");
        public static WinFormsField ConversionRateCan = new WinFormsField("CONVERSION-RATE-CAN", "ConversionRateCan");
        public static WinFormsField ConversionRateZaf = new WinFormsField("CONVERSION-RATE-ZAF", "ConversionRateZaf");
        public static WinFormsField CanTaxYear = new WinFormsField("CAN-TAX-YEAR", "CanTaxYear");
        public static WinFormsField ZafTaxYear = new WinFormsField("ZAF-TAX-YEAR", "ZafTaxYear");
        public static WinFormsField DcrReplaceType = new WinFormsField("DCR-REPLACE-TYPE", "DcrReplaceType");
        public static WinFormsField DissenterAccountInd = new WinFormsField("DISSENTER-ACCOUNT-IND", "DissenterAccountInd");
        public static WinFormsField UMINProgressInd = new WinFormsField("UM-IN-PROGRESS-IND", "UMINProgressInd");
        public static WinFormsField ReplacementsAllowedInd = new WinFormsField("REPLACEMENTS-ALLOWED-IND", "ReplacementsAllowedInd");
    }
}
