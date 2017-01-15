using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS02051

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS02051", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField LinkType = new WinFormsField("LINK-TYPE", "LinkType");
        public static WinFormsField Reference = new WinFormsField("REFERENCE", "Reference");
        public static WinFormsField InvestorNumber = new WinFormsField("INVESTOR-NUMBER", "InvestorNumber");
        public static WinFormsField InvestorNameKey = new WinFormsField("INVESTOR-NAME-KEY", "InvestorNameKey");
        public static WinFormsField MailingAddrLineR = new WinFormsField("MAILING-ADDR-LINE-R", "MailingAddrLineR");
        public static WinFormsField GlobalAddrLineR = new WinFormsField("GLOBAL-ADDR-LINE-R", "GlobalAddrLineR");
        public static WinFormsField MailingPostcodeR = new WinFormsField("MAILING-POSTCODE-R", "MailingPostcodeR");
        public static WinFormsField GlobalPostcodeR = new WinFormsField("GLOBAL-POSTCODE-R", "GlobalPostcodeR");
        public static WinFormsField MailingDomicileCode = new WinFormsField("MAILING-DOMICILE-CODE", "MailingDomicileCode");
        public static WinFormsField GlobalDomicileCode = new WinFormsField("GLOBAL-DOMICILE-CODE", "GlobalDomicileCode");
        public static WinFormsField PhoneNumber = new WinFormsField("PHONE-NUMBER", "PhoneNumber");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField InitialAction = new WinFormsField("INITIAL-ACTION", "InitialAction");
        public static WinFormsField SearchData = new WinFormsField("SEARCH-DATA", "SearchData");
    }
}
