using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CPRCTL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CPRCTL01", "FormName");
		//Fields


        public static WinFormsField CprctlKey0 = new WinFormsField("CPRCTL-KEY0", "CprctlKey0");
        public static WinFormsField PrintBatchID = new WinFormsField("PRINT-BATCH-ID", "PrintBatchID");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField BatchType = new WinFormsField("BATCH-TYPE", "BatchType");
        public static WinFormsField BatchIDX = new WinFormsField("BATCH-ID-X", "BatchIDX");
        public static WinFormsField BatchUrgentInd = new WinFormsField("BATCH-URGENT-IND", "BatchUrgentInd");
        public static WinFormsField BatchSource = new WinFormsField("BATCH-SOURCE", "BatchSource");
        public static WinFormsField BatchCreationDate = new WinFormsField("BATCH-CREATION-DATE", "BatchCreationDate");
        public static WinFormsField AuditDate = new WinFormsField("AUDIT-DATE", "AuditDate");
        public static WinFormsField AuditTime = new WinFormsField("AUDIT-TIME", "AuditTime");
        public static WinFormsField AuditUserIdentifier = new WinFormsField("AUDIT-USER-IDENTIFIER", "AuditUserIdentifier");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
