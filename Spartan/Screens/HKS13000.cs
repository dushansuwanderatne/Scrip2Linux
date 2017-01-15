using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS13000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS13000", "FormName");
		//Fields


        public static WinFormsField PlanCatSelection = new WinFormsField("PLAN-CAT-SELECTION", "PlanCatSelection");
        public static WinFormsField InputFilename = new WinFormsField("INPUT-FILENAME", "InputFilename");
        public static WinFormsField WithdrawalsInd = new WinFormsField("WITHDRAWALS-IND", "WithdrawalsInd");
        public static WinFormsField NilBalanceInd = new WinFormsField("NIL-BALANCE-IND", "NilBalanceInd");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField RunMode = new WinFormsField("RUN-MODE", "RunMode");
        public static WinFormsField TransTypeCodeCh1 = new WinFormsField("TRANS-TYPE-CODE-CH1", "TransTypeCodeCh1");
        public static WinFormsField TransTypeCodeCh25 = new WinFormsField("TRANS-TYPE-CODE-CH2-5", "TransTypeCodeCh25");
        public static WinFormsField CorpActionActiveInd = new WinFormsField("CORP-ACTION-ACTIVE-IND", "CorpActionActiveInd");
        public static WinFormsField CorpActionType = new WinFormsField("CORP-ACTION-TYPE", "CorpActionType");
        public static WinFormsField BooksCloseDate = new WinFormsField("BOOKS-CLOSE-DATE", "BooksCloseDate");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
