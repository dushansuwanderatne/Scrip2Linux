using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAS01002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAS01002", "FormName");
		//Fields


        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField AustTaxFlag = new WinFormsField("AUST-TAX-FLAG", "AustTaxFlag");
        public static WinFormsField AiirConvRateAus = new WinFormsField("AIIR-CONV-RATE-AUS", "AiirConvRateAus");
        public static WinFormsField FinancialYear = new WinFormsField("FINANCIAL-YEAR", "FinancialYear");
        public static WinFormsField SubCoyCode = new WinFormsField("SUB-COY-CODE", "SubCoyCode");
        public static WinFormsField SubCompanyName = new WinFormsField("SUB-COMPANY-NAME", "SubCompanyName");
        public static WinFormsField AiirStatusDesc = new WinFormsField("AIIR-STATUS-DESC", "AiirStatusDesc");
        public static WinFormsField AiirDispatchDate = new WinFormsField("AIIR-DISPATCH-DATE", "AiirDispatchDate");
        public static WinFormsField InvestmentType = new WinFormsField("INVESTMENT-TYPE", "InvestmentType");
        public static WinFormsField InvestmentDesc = new WinFormsField("INVESTMENT-DESC", "InvestmentDesc");
        public static WinFormsField AtoCgtReportingInd = new WinFormsField("ATO-CGT-REPORTING-IND", "AtoCgtReportingInd");
        public static WinFormsField CgtConvRateAus = new WinFormsField("CGT-CONV-RATE-AUS", "CgtConvRateAus");
        public static WinFormsField CgtStatusDesc = new WinFormsField("CGT-STATUS-DESC", "CgtStatusDesc");
        public static WinFormsField CgtDispatchDate = new WinFormsField("CGT-DISPATCH-DATE", "CgtDispatchDate");
        public static WinFormsField NZTaxFlag = new WinFormsField("NZ-TAX-FLAG", "NZTaxFlag");
        public static WinFormsField ConversionRateNZ = new WinFormsField("CONVERSION-RATE-NZ", "ConversionRateNZ");
        public static WinFormsField GbrTaxFlag = new WinFormsField("GBR-TAX-FLAG", "GbrTaxFlag");
        public static WinFormsField ConversionRateGbr = new WinFormsField("CONVERSION-RATE-GBR", "ConversionRateGbr");
        public static WinFormsField USTaxFlag = new WinFormsField("US-TAX-FLAG", "USTaxFlag");
        public static WinFormsField ConversionRateUS = new WinFormsField("CONVERSION-RATE-US", "ConversionRateUS");
        public static WinFormsField USTaxYear = new WinFormsField("US-TAX-YEAR", "USTaxYear");
        public static WinFormsField CanTaxFlag = new WinFormsField("CAN-TAX-FLAG", "CanTaxFlag");
        public static WinFormsField ConversionRateCan = new WinFormsField("CONVERSION-RATE-CAN", "ConversionRateCan");
        public static WinFormsField CanTaxYear = new WinFormsField("CAN-TAX-YEAR", "CanTaxYear");
        public static WinFormsField IrlTaxFlag = new WinFormsField("IRL-TAX-FLAG", "IrlTaxFlag");
        public static WinFormsField ConversionRateIrl = new WinFormsField("CONVERSION-RATE-IRL", "ConversionRateIrl");
        public static WinFormsField IrlTaxYear = new WinFormsField("IRL-TAX-YEAR", "IrlTaxYear");
        public static WinFormsField ZafTaxFlag = new WinFormsField("ZAF-TAX-FLAG", "ZafTaxFlag");
        public static WinFormsField ConversionRateZaf = new WinFormsField("CONVERSION-RATE-ZAF", "ConversionRateZaf");
        public static WinFormsField ZafTaxYear = new WinFormsField("ZAF-TAX-YEAR", "ZafTaxYear");
        public static WinFormsField StartBatchChqRange = new WinFormsField("START-BATCH-CHQ-RANGE", "StartBatchChqRange");
        public static WinFormsField EndBatchChqRange = new WinFormsField("END-BATCH-CHQ-RANGE", "EndBatchChqRange");
        public static WinFormsField LastBatchChequeNbr = new WinFormsField("LAST-BATCH-CHEQUE-NBR", "LastBatchChequeNbr");
        public static WinFormsField LastBatchRefNbr = new WinFormsField("LAST-BATCH-REF-NBR", "LastBatchRefNbr");
        public static WinFormsField LastBankTapeNbr = new WinFormsField("LAST-BANK-TAPE-NBR", "LastBankTapeNbr");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
