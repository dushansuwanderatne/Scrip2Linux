using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CCT01534

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CCT01534", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField OriginTranID = new WinFormsField("ORIGIN-TRAN-ID", "OriginTranID");
        public static WinFormsField ProcessingTimestamp = new WinFormsField("PROCESSING-TIMESTAMP", "ProcessingTimestamp");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField ReceivingHin = new WinFormsField("RECEIVING-HIN", "ReceivingHin");
        public static WinFormsField TaxFileNumber1 = new WinFormsField("TAX-FILE-NUMBER-1", "TaxFileNumber1");
        public static WinFormsField TaxFileNumber2 = new WinFormsField("TAX-FILE-NUMBER-2", "TaxFileNumber2");
        public static WinFormsField TaxFileNumber3 = new WinFormsField("TAX-FILE-NUMBER-3", "TaxFileNumber3");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
    }
}
