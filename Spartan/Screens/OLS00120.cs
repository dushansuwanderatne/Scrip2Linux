using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS00120

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS00120", "FormName");
		//Fields
        public static WinFormsField MenuItemReplc = new WinFormsField("MENU-ITEM-REPLC", "REPLC. Payment Replacement", "PaymentReplacement");
        public static WinFormsField MenuItemRedcr = new WinFormsField("MENU-ITEM-REDCR", "REDCR. Replace Payment with DCredit Manual", "ReplacePaymentwithDCreditManual");
        public static WinFormsField MenuItemRedca = new WinFormsField("MENU-ITEM-REDCA", "REDCA. Replace Payment with DCredit Auto", "ReplacePaymentwithDCreditAuto");
        public static WinFormsField MenuItemRdrev = new WinFormsField("MENU-ITEM-RDREV", "RDREV. Replace Payment with DCredit Reversal", "ReplacePaymentwithDCreditReversal");
        public static WinFormsField MenuItemGedcr = new WinFormsField("MENU-ITEM-GEDCR", "GEDCR. Generate Direct Credit Tape", "GenerateDirectCreditTape");
        public static WinFormsField MenuItemRedcl = new WinFormsField("MENU-ITEM-REDCL", "REDCL. Direct Credit Lodgement Auth", "DirectCreditLodgementAuth");
        public static WinFormsField MenuItemRepsc = new WinFormsField("MENU-ITEM-REPSC", "REPSC. Replace Cheque with same Chq No.", "ReplaceChequewithsameChqNo.");
        public static WinFormsField MenuItemRerev = new WinFormsField("MENU-ITEM-REREV", "REREV. Rep Cheque with same Chq No. reversal", "RepChequewithsameChqNo.reversal");
        public static WinFormsField MenuItemGechq = new WinFormsField("MENU-ITEM-GECHQ", "GECHQ. Generate Cheque Tape", "GenerateChequeTape");
        public static WinFormsField MenuItemRepcp = new WinFormsField("MENU-ITEM-REPCP", "REPCP. Replacement Cheque with Print", "ReplacementChequewithPrint");
        public static WinFormsField MenuItemRcfno = new WinFormsField("MENU-ITEM-RCFNO", "RCFNO. Replacement Tape Alloc Cheque Nos", "ReplacementTapeAllocChequeNos");
        public static WinFormsField MenuItemRchqr = new WinFormsField("MENU-ITEM-RCHQR", "RCHQR. Replacement Cheque Reconciliation", "ReplacementChequeReconciliation");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
