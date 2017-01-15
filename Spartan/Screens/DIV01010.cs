using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV01010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV01010", "FormName");
		//Fields


        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField DividendDescription = new WinFormsField("DIVIDEND-DESCRIPTION", "DividendDescription");
        public static WinFormsField DividendType = new WinFormsField("DIVIDEND-TYPE", "DividendType");
        public static WinFormsField NonStandardApply = new WinFormsField("NON-STANDARD-APPLY", "NonStandardApply");
        public static WinFormsField DualFrankingApply = new WinFormsField("DUAL-FRANKING-APPLY", "DualFrankingApply");
        public static WinFormsField TttTaxInd = new WinFormsField("TTT-TAX-IND", "TttTaxInd");
        public static WinFormsField TttCountryCode = new WinFormsField("TTT-COUNTRY-CODE", "TttCountryCode");
        public static WinFormsField TttTaxExchangeRate = new WinFormsField("TTT-TAX-EXCHANGE-RATE", "TttTaxExchangeRate");
        public static WinFormsField PaymentsPerYear = new WinFormsField("PAYMENTS-PER-YEAR", "PaymentsPerYear");
        public static WinFormsField BCRunNumber = new WinFormsField("BC-RUN-NUMBER", "BCRunNumber");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField ListDate = new WinFormsField("LIST-DATE", "ListDate");
        public static WinFormsField BooksCloseDate = new WinFormsField("BOOKS-CLOSE-DATE", "BooksCloseDate");
        public static WinFormsField PaidTODate = new WinFormsField("PAID-TO-DATE", "PaidTODate");
        public static WinFormsField XtrFilnam = new WinFormsField("XTR-FILNAM", "XtrFilnam");
        public static WinFormsField SplitProgram = new WinFormsField("SPLIT-PROGRAM", "SplitProgram");
        public static WinFormsField SpecCompCpl = new WinFormsField("SPEC-COMP-CPL", "SpecCompCpl");
        public static WinFormsField RoundOption = new WinFormsField("ROUND-OPTION", "RoundOption");
        public static WinFormsField ScripDividend = new WinFormsField("SCRIP-DIVIDEND", "ScripDividend");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
