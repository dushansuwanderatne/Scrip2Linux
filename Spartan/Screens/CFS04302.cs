using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS04302

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS04302", "FormName");
		//Fields


        public static WinFormsField ProcessCode = new WinFormsField("PROCESS-CODE", "ProcessCode");
        public static WinFormsField StepCode = new WinFormsField("STEP-CODE", "StepCode");
        public static WinFormsField StepCodeSeq = new WinFormsField("STEP-CODE-SEQ", "StepCodeSeq");
        public static WinFormsField ShortDesc = new WinFormsField("SHORT-DESC", "ShortDesc");
        public static WinFormsField LongDesc = new WinFormsField("LONG-DESC", "LongDesc");
        public static WinFormsField StepOrigin = new WinFormsField("STEP-ORIGIN", "StepOrigin");
        public static WinFormsField CurrentInd = new WinFormsField("CURRENT-IND", "CurrentInd");
        public static WinFormsField StepTypeInd = new WinFormsField("STEP-TYPE-IND", "StepTypeInd");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField StateCode = new WinFormsField("STATE-CODE", "StateCode");
        public static WinFormsField PayingFrom = new WinFormsField("PAYING-FROM", "PayingFrom");
        public static WinFormsField PayingTO = new WinFormsField("PAYING-TO", "PayingTO");
        public static WinFormsField CpuRecnInd = new WinFormsField("CPU-RECN-IND", "CpuRecnInd");
        public static WinFormsField RelHoldAllowInd = new WinFormsField("REL-HOLD-ALLOW-IND", "RelHoldAllowInd");
        public static WinFormsField OverrideAllowInd = new WinFormsField("OVERRIDE-ALLOW-IND", "OverrideAllowInd");
        public static WinFormsField ReleaseHoldSecGrp = new WinFormsField("RELEASE-HOLD-SEC-GRP", "ReleaseHoldSecGrp");
        public static WinFormsField OverrideSecGrp = new WinFormsField("OVERRIDE-SEC-GRP", "OverrideSecGrp");
        public static WinFormsField ReleaseHoldAction = new WinFormsField("RELEASE-HOLD-ACTION", "ReleaseHoldAction");
        public static WinFormsField ContinuationInd = new WinFormsField("CONTINUATION-IND", "ContinuationInd");
        public static WinFormsField PrevCompleteInd = new WinFormsField("PREV-COMPLETE-IND", "PrevCompleteInd");
        public static WinFormsField AuditUser = new WinFormsField("AUDIT-USER", "AuditUser");
        public static WinFormsField AuditDate = new WinFormsField("AUDIT-DATE", "AuditDate");
        public static WinFormsField AuditTime = new WinFormsField("AUDIT-TIME", "AuditTime");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1 = new WinFormsField("ACTION-1", "Action1");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
