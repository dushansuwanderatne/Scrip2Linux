using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FSP00102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FSP00102", "FormName");
		//Fields


        public static WinFormsField MenuItemPps = new WinFormsField("MENU-ITEM-PPS", "PPS.  Payment Parameter Setup", "PaymentParameterSetup");
        public static WinFormsField MenuItemDfa = new WinFormsField("MENU-ITEM-DFA", "DFA.  Define/Enquire on Payment Account(s)", "Define/EnquireonPaymentAccount(s)");
        public static WinFormsField MenuItemPsc = new WinFormsField("MENU-ITEM-PSC", "PSC.  Payment Schedule", "PaymentSchedule");
        public static WinFormsField MenuItemPcr = new WinFormsField("MENU-ITEM-PCR", "PCR.  Pre Payment Commitment Report", "PrePaymentCommitmentReport");
        public static WinFormsField MenuItemPac = new WinFormsField("MENU-ITEM-PAC", "PAC.  Payment Accrual Report", "PaymentAccrualReport");
        public static WinFormsField MenuItemDca = new WinFormsField("MENU-ITEM-DCA", "DCA.  Direct Credit Lodgement Authority", "DirectCreditLodgementAuthority");
        public static WinFormsField MenuItemCpa = new WinFormsField("MENU-ITEM-CPA", "CPA.  Cheque Presentation Build Authority", "ChequePresentationBuildAuthority");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
