using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FHK01402

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FHK01402", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField CompanyAddressLine = new WinFormsField("COMPANY-ADDRESS-LINE", "CompanyAddressLine");
        public static WinFormsField CompanyContactName = new WinFormsField("COMPANY-CONTACT-NAME", "CompanyContactName");
        public static WinFormsField TelephoneNumber = new WinFormsField("TELEPHONE-NUMBER", "TelephoneNumber");
        public static WinFormsField FaxNumber = new WinFormsField("FAX-NUMBER", "FaxNumber");
        public static WinFormsField LastIssueNumber = new WinFormsField("LAST-ISSUE-NUMBER", "LastIssueNumber");
        public static WinFormsField LastMarkingNumber = new WinFormsField("LAST-MARKING-NUMBER", "LastMarkingNumber");
        public static WinFormsField BuybackHin = new WinFormsField("BUYBACK-HIN", "BuybackHin");
        public static WinFormsField DivestmentHin = new WinFormsField("DIVESTMENT-HIN", "DivestmentHin");
        public static WinFormsField AustraclearHolderID = new WinFormsField("AUSTRACLEAR-HOLDER-ID", "AustraclearHolderID");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
