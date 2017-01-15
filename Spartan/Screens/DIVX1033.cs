using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVX1033

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVX1033", "FormName");
		//Fields
        public static WinFormsField DividendSource = new WinFormsField("DIVIDEND-SOURCE", "DividendSource");
        public static WinFormsField SourceDescription = new WinFormsField("SOURCE-DESCRIPTION", "SourceDescription");
        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField ClassCat = new WinFormsField("CLASS-CAT", "ClassCat");
        public static WinFormsField ClassCat2 = new WinFormsField("CLASS-CAT-2", "ClassCat2");
        public static WinFormsField SubPayCode = new WinFormsField("SUB-PAY-CODE", "SubPayCode");
        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
        public static WinFormsField TypeDescription = new WinFormsField("TYPE-DESCRIPTION", "TypeDescription");
        public static WinFormsField PaymentRateDesc1 = new WinFormsField("PAYMENT-RATE-DESC-1", "PaymentRateDesc1");
        public static WinFormsField PaymentRate1 = new WinFormsField("PAYMENT-RATE-1", "PaymentRate1");
        public static WinFormsField AdditionalRate1 = new WinFormsField("ADDITIONAL-RATE-1", "AdditionalRate1");
        public static WinFormsField ReportableRate1 = new WinFormsField("REPORTABLE-RATE-1", "ReportableRate1");
        public static WinFormsField CompBrkdwnMethod = new WinFormsField("COMP BRKDWN METHOD", "CompBrkdwnMethod");
        public static WinFormsField PaymentRateDesc2 = new WinFormsField("PAYMENT-RATE-DESC-2", "PaymentRateDesc2");
        public static WinFormsField PaymentRate2 = new WinFormsField("PAYMENT-RATE-2", "PaymentRate2");
        public static WinFormsField AdditionalRate2 = new WinFormsField("ADDITIONAL-RATE-2", "AdditionalRate2");
        public static WinFormsField ReportableRate2 = new WinFormsField("REPORTABLE-RATE-2", "ReportableRate2");
        public static WinFormsField CompBrkdwnMethod2 = new WinFormsField("COMP-BRKDWN-METHOD-2", "CompBrkdwnMethod2");
        public static WinFormsField PaymentRateDesc3 = new WinFormsField("PAYMENT-RATE-DESC-3", "PaymentRateDesc3");
        public static WinFormsField PaymentRate3 = new WinFormsField("PAYMENT-RATE-3", "PaymentRate3");
        public static WinFormsField AdditionalRate3 = new WinFormsField("ADDITIONAL-RATE-3", "AdditionalRate3");
        public static WinFormsField ReportableRate3 = new WinFormsField("REPORTABLE-RATE-3", "ReportableRate3");
        public static WinFormsField CompBrkdwnMethod3 = new WinFormsField("COMP-BRKDWN-METHOD-3", "CompBrkdwnMethod3");
        public static WinFormsField PaymentRateDesc4 = new WinFormsField("PAYMENT-RATE-DESC-4", "PaymentRateDesc4");
        public static WinFormsField PaymentRate4 = new WinFormsField("PAYMENT-RATE-4", "PaymentRate4");
        public static WinFormsField AdditionalRate4 = new WinFormsField("ADDITIONAL-RATE-4", "AdditionalRate4");
        public static WinFormsField ReportableRate4 = new WinFormsField("REPORTABLE-RATE-4", "ReportableRate4");
        public static WinFormsField CompBrkdwnMethod4 = new WinFormsField("COMP-BRKDWN-METHOD-4", "CompBrkdwnMethod4");
        public static WinFormsField PaymentRateDesc5 = new WinFormsField("PAYMENT-RATE-DESC-5", "PaymentRateDesc5");
        public static WinFormsField PaymentRate5 = new WinFormsField("PAYMENT-RATE-5", "PaymentRate5");
        public static WinFormsField AdditionalRate5 = new WinFormsField("ADDITIONAL-RATE-5", "AdditionalRate5");
        public static WinFormsField ReportableRate5 = new WinFormsField("REPORTABLE-RATE-5", "ReportableRate5");
        public static WinFormsField CompBrkdwnMethod5 = new WinFormsField("COMP-BRKDWN-METHOD-5", "CompBrkdwnMethod5");
        public static WinFormsField PaymentRateDesc6 = new WinFormsField("PAYMENT-RATE-DESC-6", "PaymentRateDesc6");
        public static WinFormsField PaymentRate6 = new WinFormsField("PAYMENT-RATE-6", "PaymentRate6");
        public static WinFormsField AdditionalRate6 = new WinFormsField("ADDITIONAL-RATE-6", "AdditionalRate6");
        public static WinFormsField ReportableRate6 = new WinFormsField("REPORTABLE-RATE-6", "ReportableRate6");
        public static WinFormsField CompBrkdwnMethod6 = new WinFormsField("COMP-BRKDWN-METHOD-6", "CompBrkdwnMethod6");
        public static WinFormsField PaymentRateDesc7 = new WinFormsField("PAYMENT-RATE-DESC-7", "PaymentRateDesc7");
        public static WinFormsField PaymentRate7 = new WinFormsField("PAYMENT-RATE-7", "PaymentRate7");
        public static WinFormsField AdditionalRate7 = new WinFormsField("ADDITIONAL-RATE-7", "AdditionalRate7");
        public static WinFormsField ReportableRate7 = new WinFormsField("REPORTABLE-RATE-7", "ReportableRate7");
        public static WinFormsField CompBrkdwnMethod7 = new WinFormsField("COMP-BRKDWN-METHOD-7", "CompBrkdwnMethod7");
        public static WinFormsField PaymentRateDesc8 = new WinFormsField("PAYMENT-RATE-DESC-8", "PaymentRateDesc8");
        public static WinFormsField PaymentRate8 = new WinFormsField("PAYMENT-RATE-8", "PaymentRate8");
        public static WinFormsField AdditionalRate8 = new WinFormsField("ADDITIONAL-RATE-8", "AdditionalRate8");
        public static WinFormsField ReportableRate8 = new WinFormsField("REPORTABLE-RATE-8", "ReportableRate8");
        public static WinFormsField CompBrkdwnMethod8 = new WinFormsField("COMP-BRKDWN-METHOD-8", "CompBrkdwnMethod8");
        public static WinFormsField PaymentRateDesc9 = new WinFormsField("PAYMENT-RATE-DESC-9", "PaymentRateDesc9");
        public static WinFormsField PaymentRate9 = new WinFormsField("PAYMENT-RATE-9", "PaymentRate9");
        public static WinFormsField AdditionalRate9 = new WinFormsField("ADDITIONAL-RATE-9", "AdditionalRate9");
        public static WinFormsField ReportableRate9 = new WinFormsField("REPORTABLE-RATE-9", "ReportableRate9");
        public static WinFormsField CompBrkdwnMethod9 = new WinFormsField("COMP-BRKDWN-METHOD-9", "CompBrkdwnMethod9");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
