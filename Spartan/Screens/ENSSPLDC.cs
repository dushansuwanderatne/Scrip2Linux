using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSSPLDC

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSSPLDC", "FormName");
		//Fields


        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField DividendType = new WinFormsField("DIVIDEND-TYPE", "DividendType");
        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField DividendSource = new WinFormsField("DIVIDEND-SOURCE", "DividendSource");
        public static WinFormsField ChequeNumber = new WinFormsField("CHEQUE-NUMBER", "ChequeNumber");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField Cat = new WinFormsField("CAT", "Cat");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField Column1 = new WinFormsField("COLUMN1", "Column1");
        public static WinFormsField Brokerage = new WinFormsField("BROKERAGE", "Brokerage");
        public static WinFormsField StampDuty = new WinFormsField("STAMP-DUTY", "StampDuty");
        public static WinFormsField AdminCost = new WinFormsField("ADMIN-COST", "AdminCost");
        public static WinFormsField Gross = new WinFormsField("GROSS", "Gross");
        public static WinFormsField PayDetails = new WinFormsField("PAY-DETAILS", "PayDetails");
        public static WinFormsField Nett = new WinFormsField("NETT", "Nett");
        public static WinFormsField Tax = new WinFormsField("TAX", "Tax");
        public static WinFormsField TaxType = new WinFormsField("TAX-TYPE", "TaxType");
        public static WinFormsField MultCurr = new WinFormsField("MULT-CURR", "MultCurr");
        public static WinFormsField CurrencyDesc = new WinFormsField("CURRENCY-DESC", "CurrencyDesc");
        public static WinFormsField MCConvRate = new WinFormsField("MC-CONV-RATE", "MCConvRate");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
