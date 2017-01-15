using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS18000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS18000", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ProcessType = new WinFormsField("PROCESS-TYPE", "ProcessType");
        public static WinFormsField PlanCatSelection = new WinFormsField("PLAN-CAT-SELECTION", "PlanCatSelection");
        public static WinFormsField AutoWithdrawalsYN = new WinFormsField("AUTO-WITHDRAWALS-YN", "AutoWithdrawalsYN");
        public static WinFormsField DeceasedYN = new WinFormsField("DECEASED-YN", "DeceasedYN");
        public static WinFormsField NilBalanceYN = new WinFormsField("NIL-BALANCE-YN", "NilBalanceYN");
        public static WinFormsField CorpActionPayment = new WinFormsField("CORP-ACTION-PAYMENT", "CorpActionPayment");
        public static WinFormsField CorpActionType = new WinFormsField("CORP-ACTION-TYPE", "CorpActionType");
        public static WinFormsField BooksCloseDate = new WinFormsField("BOOKS-CLOSE-DATE", "BooksCloseDate");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
