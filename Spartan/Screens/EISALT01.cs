using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EISALT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EISALT01", "FormName");
		//Fields


        public static WinFormsField EisaltKey0 = new WinFormsField("EISALT-KEY0", "EisaltKey0");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField AllotRunNbr = new WinFormsField("ALLOT-RUN-NBR", "AllotRunNbr");
        public static WinFormsField InvProcess = new WinFormsField("INV-PROCESS", "InvProcess");
        public static WinFormsField AllotRefNbr = new WinFormsField("ALLOT-REF-NBR", "AllotRefNbr");
        public static WinFormsField AllotPeriod = new WinFormsField("ALLOT-PERIOD", "AllotPeriod");
        public static WinFormsField EmpCurrentUnitValue = new WinFormsField("EMP-CURRENT-UNIT-VALUE", "EmpCurrentUnitValue");
        public static WinFormsField CoyCurrentUnitValue = new WinFormsField("COY-CURRENT-UNIT-VALUE", "CoyCurrentUnitValue");
        public static WinFormsField AllotPoolCert = new WinFormsField("ALLOT-POOL-CERT", "AllotPoolCert");
        public static WinFormsField EmpBFBal = new WinFormsField("EMP-BF-BAL", "EmpBFBal");
        public static WinFormsField AllotEmpCert = new WinFormsField("ALLOT-EMP-CERT", "AllotEmpCert");
        public static WinFormsField EmpContrib = new WinFormsField("EMP-CONTRIB", "EmpContrib");
        public static WinFormsField AllotUnvestCert = new WinFormsField("ALLOT-UNVEST-CERT", "AllotUnvestCert");
        public static WinFormsField EmpCFBal = new WinFormsField("EMP-CF-BAL", "EmpCFBal");
        public static WinFormsField AllotVestCert = new WinFormsField("ALLOT-VEST-CERT", "AllotVestCert");
        public static WinFormsField EmpContribTODate = new WinFormsField("EMP-CONTRIB-TO-DATE", "EmpContribTODate");
        public static WinFormsField CCTranCountFrom = new WinFormsField("CC-TRAN-COUNT-FROM", "CCTranCountFrom");
        public static WinFormsField CCTranCountTO = new WinFormsField("CC-TRAN-COUNT-TO", "CCTranCountTO");
        public static WinFormsField CoyBFBal = new WinFormsField("COY-BF-BAL", "CoyBFBal");
        public static WinFormsField CoyContrib = new WinFormsField("COY-CONTRIB", "CoyContrib");
        public static WinFormsField CoyCFBal = new WinFormsField("COY-CF-BAL", "CoyCFBal");
        public static WinFormsField AdjPriorAllot = new WinFormsField("ADJ-PRIOR-ALLOT", "AdjPriorAllot");
        public static WinFormsField CoyContribTODate = new WinFormsField("COY-CONTRIB-TO-DATE", "CoyContribTODate");
        public static WinFormsField AdjustmentAllot = new WinFormsField("ADJUSTMENT-ALLOT", "AdjustmentAllot");
        public static WinFormsField TerminationFlag = new WinFormsField("TERMINATION-FLAG", "TerminationFlag");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
