using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS11010
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS11010", "FormName");
        //Fields
        public static WinFormsField PaymentRangeInd = new WinFormsField("PAYMENT-RANGE-IND", "PaymentRangeInd");
        public static WinFormsField PaymentStatus = new WinFormsField("PAYMENT-STATUS", "PaymentStatus");
        public static WinFormsField PaymentTransTypes = new WinFormsField("PAYMENT-TRANS-TYPES", "PaymentTransTypes");
        public static WinFormsField PaymentMethod = new WinFormsField("PAYMENT-METHOD", "PaymentMethod");
        public static WinFormsField PayRefNumberFrom = new WinFormsField("PAY-REF-NUMBER-FROM", "PayRefNumberFrom");
        public static WinFormsField PayRefNumberTO = new WinFormsField("PAY-REF-NUMBER-TO", "PayRefNumberTO");
        public static WinFormsField PresentedDateFrom = new WinFormsField("PRESENTED-DATE-FROM", "PresentedDateFrom");
        public static WinFormsField PresentedDateTO = new WinFormsField("PRESENTED-DATE-TO", "PresentedDateTO");
        public static WinFormsField TaxSelection = new WinFormsField("TAX-SELECTION", "TaxSelection");
        public static WinFormsField ReturnedMail = new WinFormsField("RETURNED-MAIL", "ReturnedMail");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}