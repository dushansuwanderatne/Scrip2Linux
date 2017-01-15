using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPS00102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPS00102", "FormName");
		//Fields
        public static WinFormsField MenuItemDpp = new WinFormsField("MENU-ITEM-DPP", "DPP.  Dividend Payment Parameters", "DividendPaymentParameters");
        public static WinFormsField MenuItemPjm = new WinFormsField("MENU-ITEM-PJM", "PJM.  Payment Job Release Monitor", "PaymentJobReleaseMonitor");
        public static WinFormsField MenuItemPcs = new WinFormsField("MENU-ITEM-PCS", "PCS.  Payment Component Setup (Menu)", "PaymentComponentSetup(Menu)");
        public static WinFormsField MenuItemDfa = new WinFormsField("MENU-ITEM-DFA", "DFA.  Define/Enquire on Payment Account(s)", "Define/EnquireonPaymentAccount(s)");
        public static WinFormsField MenuItemPds = new WinFormsField("MENU-ITEM-PDS", "PDS.  Pre Dividend Summary", "PreDividendSummary");
        public static WinFormsField MenuItemDna = new WinFormsField("MENU-ITEM-DNA", "DNA.  Dividend Name & Address Changes", "DividendName&AddressChanges");
        public static WinFormsField MenuItemBfp = new WinFormsField("MENU-ITEM-BFP", "BFP.  Bank File Pre-Authorise", "BankFilePre-Authorise");
        public static WinFormsField MenuItemCpa = new WinFormsField("MENU-ITEM-CPA", "CPA.  Cheque Presentation Build Authority", "ChequePresentationBuildAuthority");
        public static WinFormsField MenuItemBfa = new WinFormsField("MENU-ITEM-BFA", "BFA.  Bank File Lodgement Authority", "BankFileLodgementAuthority");
        public static WinFormsField MenuItemSig = new WinFormsField("MENU-ITEM-SIG", "SIG.  Payment Signoff (Custodian Lodgement)", "PaymentSignoff(CustodianLodgement)");
        public static WinFormsField MenuItemIat = new WinFormsField("MENU-ITEM-IAT", "IAT.  International ACH Transaction Details", "InternationalACHTransactionDetails");
        public static WinFormsField MenuItemAil = new WinFormsField("MENU-ITEM-AIL", "AIL.  Accurate Initial Load (Menu)", "AccurateInitialLoad(Menu)");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
