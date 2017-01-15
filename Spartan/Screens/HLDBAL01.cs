using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HLDBAL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HLDBAL01", "FormName");
		//Fields


        public static WinFormsField HldbalKey0 = new WinFormsField("HLDBAL-KEY0", "HldbalKey0");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassCodeKey1 = new WinFormsField("CLASS-CODE-KEY1", "ClassCodeKey1");
        public static WinFormsField Holding = new WinFormsField("HOLDING", "Holding");
        public static WinFormsField RunLastChange = new WinFormsField("RUN-LAST-CHANGE", "RunLastChange");
        public static WinFormsField RunFirstShareholder = new WinFormsField("RUN-FIRST-SHAREHOLDER", "RunFirstShareholder");
        public static WinFormsField HoldingFlag = new WinFormsField("HOLDING-FLAG", "HoldingFlag");
        public static WinFormsField RunWentNil = new WinFormsField("RUN-WENT-NIL", "RunWentNil");
        public static WinFormsField BhpLoanRepayElection = new WinFormsField("BHP-LOAN-REPAY-ELECTION", "BhpLoanRepayElection");
        public static WinFormsField BhpModelPartFlag = new WinFormsField("BHP-MODEL-PART-FLAG", "BhpModelPartFlag");
        public static WinFormsField BhpPerformanceFlag = new WinFormsField("BHP-PERFORMANCE-FLAG", "BhpPerformanceFlag");
        public static WinFormsField BhpOverdueAmount = new WinFormsField("BHP-OVERDUE-AMOUNT", "BhpOverdueAmount");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
