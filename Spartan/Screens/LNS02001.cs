using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS02001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS02001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField LinkType = new WinFormsField("LINK-TYPE", "LinkType");
        public static WinFormsField Reference = new WinFormsField("REFERENCE", "Reference");
        public static WinFormsField InvestorNumber = new WinFormsField("INVESTOR-NUMBER", "InvestorNumber");
        public static WinFormsField InvestorNameKey = new WinFormsField("INVESTOR-NAME-KEY", "InvestorNameKey");
        public static WinFormsField MailingAddressLine = new WinFormsField("MAILING-ADDRESS-LINE", "MailingAddressLine");
        public static WinFormsField GlobalAddressLine = new WinFormsField("GLOBAL-ADDRESS-LINE", "GlobalAddressLine");
        public static WinFormsField MailingPostcode = new WinFormsField("MAILING-POSTCODE", "MailingPostcode");
        public static WinFormsField GlobalPostcode = new WinFormsField("GLOBAL-POSTCODE", "GlobalPostcode");
        public static WinFormsField MailingDomicileCode = new WinFormsField("MAILING-DOMICILE-CODE", "MailingDomicileCode");
        public static WinFormsField GlobalDomicileCode = new WinFormsField("GLOBAL-DOMICILE-CODE", "GlobalDomicileCode");
        public static WinFormsField PhoneNumber = new WinFormsField("PHONE-NUMBER", "PhoneNumber");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField InitialAction = new WinFormsField("INITIAL-ACTION", "InitialAction");
        public static WinFormsField SearchData = new WinFormsField("SEARCH-DATA", "SearchData");
    }
}
