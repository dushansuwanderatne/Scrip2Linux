using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSDIV03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSDIV03", "FormName");
		//Fields
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField IncomeSource = new WinFormsField("INCOME-SOURCE", "IncomeSource");
        public static WinFormsField SubPayCode = new WinFormsField("SUB-PAY-CODE", "SubPayCode");
        public static WinFormsField SubPayType = new WinFormsField("SUB-PAY-TYPE", "SubPayType");
        public static WinFormsField SubPayDesc = new WinFormsField("SUB-PAY-DESC", "SubPayDesc");
        public static WinFormsField SubPayAccCode = new WinFormsField("SUB-PAY-ACC-CODE", "SubPayAccCode");
        public static WinFormsField ComponentDesc = new WinFormsField("COMPONENT-DESC", "ComponentDesc");
        public static WinFormsField ComponentAmt = new WinFormsField("COMPONENT-AMT", "ComponentAmt");
        public static WinFormsField TaxRate = new WinFormsField("TAX-RATE", "TaxRate");
        public static WinFormsField TaxAmount = new WinFormsField("TAX-AMOUNT", "TaxAmount");
        public static WinFormsField TaxCountry = new WinFormsField("TAX-COUNTRY", "TaxCountry");
        public static WinFormsField OtherTaxRate = new WinFormsField("OTHER-TAX-RATE", "OtherTaxRate");
        public static WinFormsField OtherTaxAmount = new WinFormsField("OTHER-TAX-AMOUNT", "OtherTaxAmount");
        public static WinFormsField OtherTaxCountry = new WinFormsField("OTHER-TAX-COUNTRY", "OtherTaxCountry");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField TaxResFlag = new WinFormsField("TAX-RES-FLAG", "TaxResFlag");
        public static WinFormsField OtherTaxResFlag = new WinFormsField("OTHER-TAX-RES-FLAG", "OtherTaxResFlag");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
