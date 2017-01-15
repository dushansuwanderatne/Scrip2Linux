using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISUTOT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISUTOT01", "FormName");
		//Fields


        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField IssueNumber = new WinFormsField("ISSUE-NUMBER", "IssueNumber");
        public static WinFormsField TotalPrincipal = new WinFormsField("TOTAL-PRINCIPAL", "TotalPrincipal");
        public static WinFormsField TotalUnmarked = new WinFormsField("TOTAL-UNMARKED", "TotalUnmarked");
        public static WinFormsField TotalMarked = new WinFormsField("TOTAL-MARKED", "TotalMarked");
        public static WinFormsField TotalAccrued = new WinFormsField("TOTAL-ACCRUED", "TotalAccrued");
        public static WinFormsField TotalCompounded = new WinFormsField("TOTAL-COMPOUNDED", "TotalCompounded");
        public static WinFormsField TotalPaid = new WinFormsField("TOTAL-PAID", "TotalPaid");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
