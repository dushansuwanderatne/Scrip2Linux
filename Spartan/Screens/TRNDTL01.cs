using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRNDTL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRNDTL01", "FormName");
		//Fields


        public static WinFormsField TrndtlKey0 = new WinFormsField("TRNDTL-KEY0", "TrndtlKey0");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField Sequence = new WinFormsField("SEQUENCE", "Sequence");
        public static WinFormsField WorkflowID = new WinFormsField("WORKFLOW-ID", "WorkflowID");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField Time = new WinFormsField("TIME", "Time");
        public static WinFormsField OrigSystem = new WinFormsField("ORIG-SYSTEM", "OrigSystem");
        public static WinFormsField ServiceProvider = new WinFormsField("SERVICE-PROVIDER", "ServiceProvider");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField ServiceCode = new WinFormsField("SERVICE-CODE", "ServiceCode");
        public static WinFormsField Branch = new WinFormsField("BRANCH", "Branch");
        public static WinFormsField TransactionCount = new WinFormsField("TRANSACTION-COUNT", "TransactionCount");
        public static WinFormsField Department = new WinFormsField("DEPARTMENT", "Department");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField Msgid = new WinFormsField("MSGID", "Msgid");
        public static WinFormsField Reference = new WinFormsField("REFERENCE", "Reference");
        public static WinFormsField Reference2 = new WinFormsField("REFERENCE-2", "Reference2");
        public static WinFormsField TrndtlRecordName = new WinFormsField("TRNDTL-RECORD-NAME", "TrndtlRecordName");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
