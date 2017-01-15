using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CHS00102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CHS00102", "FormName");
		//Fields


        public static WinFormsField MenuItem412 = new WinFormsField("MENU-ITEM-412", "412. CHESS to Certificated Conversion", "CHESStoCertificatedConversion");
        public static WinFormsField MenuItem414 = new WinFormsField("MENU-ITEM-414", "414. CHESS to Certificated Transfer", "CHESStoCertificatedTransfer");
        public static WinFormsField MenuItem416 = new WinFormsField("MENU-ITEM-416", "416. CHESS to Issuer Sponsored Conversion", "CHESStoIssuerSponsoredConversion");
        public static WinFormsField MenuItem418 = new WinFormsField("MENU-ITEM-418", "418. CHESS to Issuer Sponsored Transfer", "CHESStoIssuerSponsoredTransfer");
        public static WinFormsField MenuItem422 = new WinFormsField("MENU-ITEM-422", "422. Applied registry Transaction", "AppliedregistryTransaction");
        public static WinFormsField MenuItem425 = new WinFormsField("MENU-ITEM-425", "425. Holding Adjustment", "HoldingAdjustment");
        public static WinFormsField MenuItem426 = new WinFormsField("MENU-ITEM-426", "426. Applied Registry Authorisation Response", "AppliedRegistryAuthorisationResponse");
        public static WinFormsField MenuItem428 = new WinFormsField("MENU-ITEM-428", "428. Accepted Cum Termination", "AcceptedCumTermination");
        public static WinFormsField MenuItem430 = new WinFormsField("MENU-ITEM-430", "430. Applied Code Change", "AppliedCodeChange");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 1", "1");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
