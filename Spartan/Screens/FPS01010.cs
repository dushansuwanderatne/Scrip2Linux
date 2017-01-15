using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FPS01010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FPS01010", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField PaymentCode = new WinFormsField("PAYMENT-CODE", "PaymentCode");
        public static WinFormsField PaymentDescription = new WinFormsField("PAYMENT-DESCRIPTION", "PaymentDescription");
        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
        public static WinFormsField NonStandardApply = new WinFormsField("NON-STANDARD-APPLY", "NonStandardApply");
        public static WinFormsField TaxHolderID = new WinFormsField("TAX-HOLDER-ID", "TaxHolderID");
        public static WinFormsField BCRunNumber = new WinFormsField("BC-RUN-NUMBER", "BCRunNumber");
        public static WinFormsField BooksCloseDate = new WinFormsField("BOOKS-CLOSE-DATE", "BooksCloseDate");
        public static WinFormsField ListDate = new WinFormsField("LIST-DATE", "ListDate");
        public static WinFormsField MaturityDateFrom = new WinFormsField("MATURITY-DATE-FROM", "MaturityDateFrom");
        public static WinFormsField MaturityDateTO = new WinFormsField("MATURITY-DATE-TO", "MaturityDateTO");
        public static WinFormsField XtractFilename = new WinFormsField("XTRACT-FILENAME", "XtractFilename");
        public static WinFormsField RoundingOption = new WinFormsField("ROUNDING-OPTION", "RoundingOption");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
