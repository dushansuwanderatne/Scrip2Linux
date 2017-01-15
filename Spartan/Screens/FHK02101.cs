using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FHK02101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FHK02101", "FormName");
		//Fields


        public static WinFormsField IssueNumber = new WinFormsField("ISSUE-NUMBER", "IssueNumber");
        public static WinFormsField IssueDescription = new WinFormsField("ISSUE-DESCRIPTION", "IssueDescription");
        public static WinFormsField NumberOFHolders = new WinFormsField("NUMBER-OF-HOLDERS", "NumberOFHolders");
        public static WinFormsField AustraIssueBalance = new WinFormsField("AUSTRA-ISSUE-BALANCE", "AustraIssueBalance");
        public static WinFormsField FidcrtIssueBalance = new WinFormsField("FIDCRT-ISSUE-BALANCE", "FidcrtIssueBalance");
        public static WinFormsField BalancesDifferInd = new WinFormsField("BALANCES-DIFFER-IND", "BalancesDifferInd");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
