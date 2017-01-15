using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVX1010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVX1010", "FormName");
		//Fields
        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField DividendDescription = new WinFormsField("DIVIDEND-DESCRIPTION", "DividendDescription");
        public static WinFormsField PaymentsPerYear = new WinFormsField("PAYMENTS-PER-YEAR", "PaymentsPerYear");
        public static WinFormsField BCRunNumber = new WinFormsField("BC-RUN-NUMBER", "BCRunNumber");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField ListDate = new WinFormsField("LIST-DATE", "ListDate");
        public static WinFormsField BooksCloseDate = new WinFormsField("BOOKS-CLOSE-DATE", "BooksCloseDate");
        public static WinFormsField PaidTODate = new WinFormsField("PAID-TO-DATE", "PaidTODate");
        public static WinFormsField XtrFilnam = new WinFormsField("XTR-FILNAM", "XtrFilnam");
        public static WinFormsField RoundOption = new WinFormsField("ROUND-OPTION", "RoundOption");
        public static WinFormsField RndMultiple = new WinFormsField("RND-MULTIPLE", "RndMultiple");
        public static WinFormsField MandAllotment = new WinFormsField("MAND-ALLOTMENT", "MandAllotment");
        public static WinFormsField PlanDomRuleInd = new WinFormsField("PLAN-DOM-RULE-IND", "PlanDomRuleInd");
        public static WinFormsField PlanTaxCodeRule = new WinFormsField("PLAN-TAX-CODE-RULE", "PlanTaxCodeRule");
        public static WinFormsField SelBYAnnivInd = new WinFormsField("SEL-BY-ANNIV-IND", "SelBYAnnivInd");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
