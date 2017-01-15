using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVX1046

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVX1046", "FormName");
		//Fields


        public static WinFormsField GroupNumber = new WinFormsField("GROUP-NUMBER", "GroupNumber");
        public static WinFormsField MCCurrency = new WinFormsField("MC-CURRENCY", "MCCurrency");
        public static WinFormsField MCConversionRate = new WinFormsField("MC-CONVERSION-RATE", "MCConversionRate");
        public static WinFormsField MCConversionDesc = new WinFormsField("MC-CONVERSION-DESC", "MCConversionDesc");
        public static WinFormsField DirectCreditApply = new WinFormsField("DIRECT-CREDIT-APPLY", "DirectCreditApply");
        public static WinFormsField ChequesApply = new WinFormsField("CHEQUES-APPLY", "ChequesApply");
        public static WinFormsField MCDomCode = new WinFormsField("MC-DOM-CODE", "MCDomCode");
        public static WinFormsField MCChequeFormat = new WinFormsField("MC-CHEQUE-FORMAT", "MCChequeFormat");
        public static WinFormsField MCStartRefNumber = new WinFormsField("MC-START-REF-NUMBER", "MCStartRefNumber");
        public static WinFormsField MCChqNumPreprinted = new WinFormsField("MC-CHQ-NUM-PREPRINTED", "MCChqNumPreprinted");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
