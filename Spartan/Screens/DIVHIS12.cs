using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVHIS12

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVHIS12", "FormName");
		//Fields


        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoTime1 = new WinFormsField("SYSTEM-INFO-TIME-1", "1", "1");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField DivhisKey0 = new WinFormsField("DIVHIS-KEY0", "DivhisKey0");
        public static WinFormsField HolderIDKey2 = new WinFormsField("HOLDER-ID-KEY2", "HolderIDKey2");
        public static WinFormsField PayAccNumber = new WinFormsField("PAY-ACC-NUMBER", "PayAccNumber");
        public static WinFormsField PayRefNumber = new WinFormsField("PAY-REF-NUMBER", "PayRefNumber");
        public static WinFormsField PaymentMethod = new WinFormsField("PAYMENT-METHOD", "PaymentMethod");
        public static WinFormsField TotTttTaxCredit = new WinFormsField("TOT-TTT-TAX-CREDIT", "TotTttTaxCredit");
        public static WinFormsField TttTaxCredit = new WinFormsField("TTT-TAX-CREDIT", "TttTaxCredit");
    }
}
