using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class STMHIS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("STMHIS01", "FormName");
		//Fields


        public static WinFormsField StmhisKey0 = new WinFormsField("STMHIS-KEY0", "StmhisKey0");
        public static WinFormsField RerunSequence = new WinFormsField("RERUN-SEQUENCE", "RerunSequence");
        public static WinFormsField RunCcyy = new WinFormsField("RUN-CCYY", "RunCcyy");
        public static WinFormsField RunMM = new WinFormsField("RUN-MM", "RunMM");
        public static WinFormsField StartEomRun = new WinFormsField("START-EOM-RUN", "StartEomRun");
        public static WinFormsField NbrIsspHolders = new WinFormsField("NBR-ISSP-HOLDERS", "NbrIsspHolders");
        public static WinFormsField NbrIsspStms = new WinFormsField("NBR-ISSP-STMS", "NbrIsspStms");
        public static WinFormsField NbrIsspStmsMailed = new WinFormsField("NBR-ISSP-STMS-MAILED", "NbrIsspStmsMailed");
        public static WinFormsField NbrIsspStmsEmailed = new WinFormsField("NBR-ISSP-STMS-EMAILED", "NbrIsspStmsEmailed");
        public static WinFormsField DateOFThisRun = new WinFormsField("DATE-OF-THIS-RUN", "DateOFThisRun");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField EndEomRun = new WinFormsField("END-EOM-RUN", "EndEomRun");
        public static WinFormsField EomProgram = new WinFormsField("EOM-PROGRAM", "EomProgram");
        public static WinFormsField PrtNilMvmntsInd = new WinFormsField("PRT-NIL-MVMNTS-IND", "PrtNilMvmntsInd");
        public static WinFormsField PrtNewHldrInd = new WinFormsField("PRT-NEW-HLDR-IND", "PrtNewHldrInd");
        public static WinFormsField StmSequence = new WinFormsField("STM-SEQUENCE", "StmSequence");
        public static WinFormsField TransTypeIndicator = new WinFormsField("TRANS-TYPE-INDICATOR", "TransTypeIndicator");
        public static WinFormsField EomRangeCalcUpr = new WinFormsField("EOM-RANGE-CALC-UPR", "EomRangeCalcUpr");
        public static WinFormsField EomRangeCalcLwr = new WinFormsField("EOM-RANGE-CALC-LWR", "EomRangeCalcLwr");
        public static WinFormsField EomRangeStatus = new WinFormsField("EOM-RANGE-STATUS", "EomRangeStatus");
        public static WinFormsField LimitOriginInd = new WinFormsField("LIMIT-ORIGIN-IND", "LimitOriginInd");
        public static WinFormsField EomUpperLimit = new WinFormsField("EOM-UPPER-LIMIT", "EomUpperLimit");
        public static WinFormsField EomLowerLimit = new WinFormsField("EOM-LOWER-LIMIT", "EomLowerLimit");
        public static WinFormsField EomRERunInd = new WinFormsField("EOM-RE-RUN-IND", "EomRERunInd");
        public static WinFormsField EomAutomatedRunInd = new WinFormsField("EOM-AUTOMATED-RUN-IND", "EomAutomatedRunInd");
        public static WinFormsField TranTypes = new WinFormsField("TRAN-TYPES", "TranTypes");
        public static WinFormsField ClassCodes = new WinFormsField("CLASS-CODES", "ClassCodes");
        public static WinFormsField ClsGroup = new WinFormsField("CLS-GROUP", "ClsGroup");
        public static WinFormsField StatementRun1 = new WinFormsField("STATEMENT-RUN-1", "StatementRun1");
        public static WinFormsField StatementRun2 = new WinFormsField("STATEMENT-RUN-2", "StatementRun2");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
