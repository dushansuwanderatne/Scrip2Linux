using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RMS01002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RMS01002", "FormName");
		//Fields


        public static WinFormsField ReceiptRoutingID = new WinFormsField("RECEIPT-ROUTING-ID", "ReceiptRoutingID");
        public static WinFormsField CompanyUfd = new WinFormsField("COMPANY-UFD", "CompanyUfd");
        public static WinFormsField RemitterBank = new WinFormsField("REMITTER-BANK", "RemitterBank");
        public static WinFormsField SubsystemCode = new WinFormsField("SUBSYSTEM-CODE", "SubsystemCode");
        public static WinFormsField SubsystemRef = new WinFormsField("SUBSYSTEM-REF", "SubsystemRef");
        public static WinFormsField DefaultRouteInd = new WinFormsField("DEFAULT-ROUTE-IND", "DefaultRouteInd");
        public static WinFormsField MoreAction = new WinFormsField("MORE-ACTION", "MoreAction");
        public static WinFormsField PageNum = new WinFormsField("PAGE-NUM", "PageNum");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField DefChangeDenote = new WinFormsField("DEF-CHANGE-DENOTE", "DefChangeDenote");
        public static WinFormsField ExpiredMmyy = new WinFormsField("EXPIRED-MMYY", "ExpiredMmyy");
    }
}
