using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FHK01403

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FHK01403", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ChangeNoticeOption = new WinFormsField("CHANGE-NOTICE-OPTION", "ChangeNoticeOption");
        public static WinFormsField DividendAcknowledge = new WinFormsField("DIVIDEND-ACKNOWLEDGE", "DividendAcknowledge");
        public static WinFormsField ScripOpt = new WinFormsField("SCRIP-OPT", "ScripOpt");
        public static WinFormsField EnquiryOpt = new WinFormsField("ENQUIRY-OPT", "EnquiryOpt");
        public static WinFormsField TfnOpt = new WinFormsField("TFN-OPT", "TfnOpt");
        public static WinFormsField AddressOpt = new WinFormsField("ADDRESS-OPT", "AddressOpt");
        public static WinFormsField PaymentOpt = new WinFormsField("PAYMENT-OPT", "PaymentOpt");
        public static WinFormsField IncorporatedComment = new WinFormsField("INCORPORATED-COMMENT", "IncorporatedComment");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
