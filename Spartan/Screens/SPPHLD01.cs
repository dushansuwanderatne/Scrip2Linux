using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPPHLD01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPPHLD01", "FormName");
		//Fields


        public static WinFormsField SpphldKey0 = new WinFormsField("SPPHLD-KEY0", "SpphldKey0");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField SppJoiningReference = new WinFormsField("SPP-JOINING-REFERENCE", "SppJoiningReference");
        public static WinFormsField SppJoiningDate = new WinFormsField("SPP-JOINING-DATE", "SppJoiningDate");
        public static WinFormsField SppAbtFlag = new WinFormsField("SPP-ABT-FLAG", "SppAbtFlag");
        public static WinFormsField SppInterestFlag = new WinFormsField("SPP-INTEREST-FLAG", "SppInterestFlag");
        public static WinFormsField SppTerminationReference = new WinFormsField("SPP-TERMINATION-REFERENCE", "SppTerminationReference");
        public static WinFormsField SppTerminationDate = new WinFormsField("SPP-TERMINATION-DATE", "SppTerminationDate");
        public static WinFormsField SppCashCurrent = new WinFormsField("SPP-CASH-CURRENT", "SppCashCurrent");
        public static WinFormsField SppCashYear = new WinFormsField("SPP-CASH-YEAR", "SppCashYear");
        public static WinFormsField SppCtrTranNbr = new WinFormsField("SPP-CTR-TRAN-NBR", "SppCtrTranNbr");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
