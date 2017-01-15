using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CHS02000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CHS02000", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1. Demand Single Entry CHESS to CHESS Transfer Request", "DemandSingleEntryCHESStoCHESSTransferRequest");
        public static WinFormsField MenuItem7 = new WinFormsField("MENU-ITEM-7", "7. Demand CHESS to Issuer Sponsored Transfer Request", "DemandCHESStoIssuerSponsoredTransferRequest");
        public static WinFormsField MenuItem9 = new WinFormsField("MENU-ITEM-9", "9. Demand CHESS to Certificated Transfer Request", "DemandCHESStoCertificatedTransferRequest");
        public static WinFormsField MenuItem21 = new WinFormsField("MENU-ITEM-21", "21. Certificated to CHESS Transfer Request", "CertificatedtoCHESSTransferRequest");
        public static WinFormsField MenuItem15 = new WinFormsField("MENU-ITEM-15", "15. Issuer Sponsored to CHESS Transfer Request", "IssuerSponsoredtoCHESSTransferRequest");
        public static WinFormsField MenuItem111 = new WinFormsField("MENU-ITEM-111", "111. Settlement CHESS to Certificated Transfer Request", "SettlementCHESStoCertificatedTransferRequest");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 1", "1");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
