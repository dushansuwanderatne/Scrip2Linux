using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PNDSTP01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PNDSTP01", "FormName");
		//Fields


        public static WinFormsField PndstpKey0 = new WinFormsField("PNDSTP-KEY0", "PndstpKey0");
        public static WinFormsField PendingReference = new WinFormsField("PENDING-REFERENCE", "PendingReference");
        public static WinFormsField StepCodeSeq = new WinFormsField("STEP-CODE-SEQ", "StepCodeSeq");
        public static WinFormsField StepCode = new WinFormsField("STEP-CODE", "StepCode");
        public static WinFormsField PndstpStatus = new WinFormsField("PNDSTP-STATUS", "PndstpStatus");
        public static WinFormsField ReleaseHoldStatus = new WinFormsField("RELEASE-HOLD-STATUS", "ReleaseHoldStatus");
        public static WinFormsField ContinueInd = new WinFormsField("CONTINUE-IND", "ContinueInd");
        public static WinFormsField PreviousCompleteInd = new WinFormsField("PREVIOUS-COMPLETE-IND", "PreviousCompleteInd");
        public static WinFormsField NoteAttachedInd = new WinFormsField("NOTE-ATTACHED-IND", "NoteAttachedInd");
        public static WinFormsField StateCode = new WinFormsField("STATE-CODE", "StateCode");
        public static WinFormsField CompletionCnt = new WinFormsField("COMPLETION-CNT", "CompletionCnt");
        public static WinFormsField StepCreatedDate = new WinFormsField("STEP-CREATED-DATE", "StepCreatedDate");
        public static WinFormsField StepInitiatedDate = new WinFormsField("STEP-INITIATED-DATE", "StepInitiatedDate");
        public static WinFormsField StepInitiatedTime = new WinFormsField("STEP-INITIATED-TIME", "StepInitiatedTime");
        public static WinFormsField AuditUserIdentifier = new WinFormsField("AUDIT-USER-IDENTIFIER", "AuditUserIdentifier");
        public static WinFormsField AuditDate = new WinFormsField("AUDIT-DATE", "AuditDate");
        public static WinFormsField AuditTime = new WinFormsField("AUDIT-TIME", "AuditTime");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
