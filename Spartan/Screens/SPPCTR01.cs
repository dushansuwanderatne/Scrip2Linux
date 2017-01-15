using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPPCTR01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPPCTR01", "FormName");
		//Fields


        public static WinFormsField SppctrKey0 = new WinFormsField("SPPCTR-KEY0", "SppctrKey0");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField SppCshTranNbr = new WinFormsField("SPP-CSH-TRAN-NBR", "SppCshTranNbr");
        public static WinFormsField SppctrKey1 = new WinFormsField("SPPCTR-KEY1", "SppctrKey1");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField SppReferenceNbr = new WinFormsField("SPP-REFERENCE-NBR", "SppReferenceNbr");
        public static WinFormsField SppctrKey2 = new WinFormsField("SPPCTR-KEY2", "SppctrKey2");
        public static WinFormsField Key2RunNumber = new WinFormsField("KEY2-RUN-NUMBER", "Key2RunNumber");
        public static WinFormsField Key2DepositType = new WinFormsField("KEY2-DEPOSIT-TYPE", "Key2DepositType");
        public static WinFormsField Key2SppReferenceNbr = new WinFormsField("KEY2-SPP-REFERENCE-NBR", "Key2SppReferenceNbr");
        public static WinFormsField SppCashTranType = new WinFormsField("SPP-CASH-TRAN-TYPE", "SppCashTranType");
        public static WinFormsField SppTranDate = new WinFormsField("SPP-TRAN-DATE", "SppTranDate");
        public static WinFormsField SppCashTranAmount = new WinFormsField("SPP-CASH-TRAN-AMOUNT", "SppCashTranAmount");
        public static WinFormsField SppCashDeposit = new WinFormsField("SPP-CASH-DEPOSIT", "SppCashDeposit");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
