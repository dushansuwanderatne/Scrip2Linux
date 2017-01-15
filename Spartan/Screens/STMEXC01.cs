using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class STMEXC01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("STMEXC01", "FormName");
		//Fields


        public static WinFormsField StmexcKey0 = new WinFormsField("STMEXC-KEY0", "StmexcKey0");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField EntryMsgid = new WinFormsField("ENTRY-MSGID", "EntryMsgid");
        public static WinFormsField ExclusionType = new WinFormsField("EXCLUSION-TYPE", "ExclusionType");
        public static WinFormsField EntryDate = new WinFormsField("ENTRY-DATE", "EntryDate");
        public static WinFormsField ExclusionTran = new WinFormsField("EXCLUSION-TRAN", "ExclusionTran");
        public static WinFormsField EntryTime = new WinFormsField("ENTRY-TIME", "EntryTime");
        public static WinFormsField RunPeriod = new WinFormsField("RUN-PERIOD", "RunPeriod");
        public static WinFormsField EntryRunNbr = new WinFormsField("ENTRY-RUN-NBR", "EntryRunNbr");
        public static WinFormsField EntrySurname = new WinFormsField("ENTRY-SURNAME", "EntrySurname");
        public static WinFormsField EntryInitial = new WinFormsField("ENTRY-INITIAL", "EntryInitial");
        public static WinFormsField EntryOrigin = new WinFormsField("ENTRY-ORIGIN", "EntryOrigin");
        public static WinFormsField EomSelectionCode = new WinFormsField("EOM-SELECTION-CODE", "EomSelectionCode");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField ExpDelMsgid = new WinFormsField("EXP-DEL-MSGID", "ExpDelMsgid");
        public static WinFormsField ReferenceDate = new WinFormsField("REFERENCE-DATE", "ReferenceDate");
        public static WinFormsField ExpDelDate = new WinFormsField("EXP-DEL-DATE", "ExpDelDate");
        public static WinFormsField TransCount = new WinFormsField("TRANS-COUNT", "TransCount");
        public static WinFormsField ExpDelTime = new WinFormsField("EXP-DEL-TIME", "ExpDelTime");
        public static WinFormsField TransCountOrigin = new WinFormsField("TRANS-COUNT-ORIGIN", "TransCountOrigin");
        public static WinFormsField ExpDelRunNbr = new WinFormsField("EXP-DEL-RUN-NBR", "ExpDelRunNbr");
        public static WinFormsField Reason = new WinFormsField("REASON", "Reason");
        public static WinFormsField ExpDelSurname = new WinFormsField("EXP-DEL-SURNAME", "ExpDelSurname");
        public static WinFormsField ExpDelInitial = new WinFormsField("EXP-DEL-INITIAL", "ExpDelInitial");
        public static WinFormsField LCMsgid = new WinFormsField("LC-MSGID", "LCMsgid");
        public static WinFormsField LCDate = new WinFormsField("LC-DATE", "LCDate");
        public static WinFormsField LCTime = new WinFormsField("LC-TIME", "LCTime");
        public static WinFormsField LCRunNbr = new WinFormsField("LC-RUN-NBR", "LCRunNbr");
        public static WinFormsField LCSurname = new WinFormsField("LC-SURNAME", "LCSurname");
        public static WinFormsField LCInitial = new WinFormsField("LC-INITIAL", "LCInitial");
        public static WinFormsField AuditOrigin = new WinFormsField("AUDIT-ORIGIN", "AuditOrigin");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
