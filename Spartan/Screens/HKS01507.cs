using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01507

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01507", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ScripOpt = new WinFormsField("SCRIP-OPT", "ScripOpt");
        public static WinFormsField EnquiryOpt = new WinFormsField("ENQUIRY-OPT", "EnquiryOpt");
        public static WinFormsField FastOpt = new WinFormsField("FAST-OPT", "FastOpt");
        public static WinFormsField TfnOpt = new WinFormsField("TFN-OPT", "TfnOpt");
        public static WinFormsField PlanOpt = new WinFormsField("PLAN-OPT", "PlanOpt");
        public static WinFormsField PaymentOpt = new WinFormsField("PAYMENT-OPT", "PaymentOpt");
        public static WinFormsField AddressOpt = new WinFormsField("ADDRESS-OPT", "AddressOpt");
        public static WinFormsField LstSrnOpt = new WinFormsField("LST-SRN-OPT", "LstSrnOpt");
        public static WinFormsField IncorporatedComment = new WinFormsField("INCORPORATED-COMMENT", "IncorporatedComment");
        public static WinFormsField OSSequenceOption = new WinFormsField("OS-SEQUENCE-OPTION", "OSSequenceOption");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
