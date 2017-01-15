using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BNKACC01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BNKACC01", "FormName");
		//Fields


        public static WinFormsField BnkaccKey0 = new WinFormsField("BNKACC-KEY0", "BnkaccKey0");
        public static WinFormsField BankType = new WinFormsField("BANK-TYPE", "BankType");
        public static WinFormsField BranchAccount = new WinFormsField("BRANCH-ACCOUNT", "BranchAccount");
        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField CompanyUfd = new WinFormsField("COMPANY-UFD", "CompanyUfd");
        public static WinFormsField CemtexUserID = new WinFormsField("CEMTEX-USER-ID", "CemtexUserID");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField BulkPayCode = new WinFormsField("BULK-PAY-CODE", "BulkPayCode");
    }
}
