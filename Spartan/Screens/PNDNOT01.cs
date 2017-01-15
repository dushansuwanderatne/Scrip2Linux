using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PNDNOT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PNDNOT01", "FormName");
		//Fields


        public static WinFormsField PndnotKey0 = new WinFormsField("PNDNOT-KEY0", "PndnotKey0");
        public static WinFormsField PendingReference = new WinFormsField("PENDING-REFERENCE", "PendingReference");
        public static WinFormsField StepCodeSeq = new WinFormsField("STEP-CODE-SEQ", "StepCodeSeq");
        public static WinFormsField StepCode = new WinFormsField("STEP-CODE", "StepCode");
        public static WinFormsField NoteCnt = new WinFormsField("NOTE-CNT", "NoteCnt");
        public static WinFormsField NoteOrigin = new WinFormsField("NOTE-ORIGIN", "NoteOrigin");
        public static WinFormsField NoteType = new WinFormsField("NOTE-TYPE", "NoteType");
        public static WinFormsField NoteTxt = new WinFormsField("NOTE-TXT", "NoteTxt");
        public static WinFormsField AuditUserIdentifier = new WinFormsField("AUDIT-USER-IDENTIFIER", "AuditUserIdentifier");
        public static WinFormsField AuditDate = new WinFormsField("AUDIT-DATE", "AuditDate");
        public static WinFormsField AuditTime = new WinFormsField("AUDIT-TIME", "AuditTime");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
