using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSLVS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSLVS01", "FormName");
		//Fields


        public static WinFormsField Mel0PlanType = new WinFormsField("MEL0-PLAN-TYPE", "Mel0PlanType");
        public static WinFormsField LeaverSchedule = new WinFormsField("LEAVER-SCHEDULE", "LeaverSchedule");
        public static WinFormsField LeaverScheduleDesc = new WinFormsField("LEAVER-SCHEDULE-DESC", "LeaverScheduleDesc");
        public static WinFormsField LeaverCode = new WinFormsField("LEAVER-CODE", "LeaverCode");
        public static WinFormsField EmployeeStatus = new WinFormsField("EMPLOYEE-STATUS", "EmployeeStatus");
        public static WinFormsField LeaverEffectInd = new WinFormsField("LEAVER-EFFECT-IND", "LeaverEffectInd");
        public static WinFormsField MaintainRestrictInd = new WinFormsField("MAINTAIN-RESTRICT-IND", "MaintainRestrictInd");
        public static WinFormsField PhantomLeaverType = new WinFormsField("PHANTOM-LEAVER-TYPE", "PhantomLeaverType");
        public static WinFormsField UnvNOChgInd = new WinFormsField("UNV-NO-CHG-IND", "UnvNOChgInd");
        public static WinFormsField VstNOChgInd = new WinFormsField("VST-NO-CHG-IND", "VstNOChgInd");
        public static WinFormsField UnvCancelImmInd = new WinFormsField("UNV-CANCEL-IMM-IND", "UnvCancelImmInd");
        public static WinFormsField VstCancelImmInd = new WinFormsField("VST-CANCEL-IMM-IND", "VstCancelImmInd");
        public static WinFormsField UnvAccelerateVstInd = new WinFormsField("UNV-ACCELERATE-VST-IND", "UnvAccelerateVstInd");
        public static WinFormsField VstIgnoreBlackoutInd = new WinFormsField("VST-IGNORE-BLACKOUT-IND", "VstIgnoreBlackoutInd");
        public static WinFormsField UnvAccelerateMonths = new WinFormsField("UNV-ACCELERATE-MONTHS", "UnvAccelerateMonths");
        public static WinFormsField TaxationInd = new WinFormsField("TAXATION-IND", "TaxationInd");
        public static WinFormsField UnvAccelerateDays = new WinFormsField("UNV-ACCELERATE-DAYS", "UnvAccelerateDays");
        public static WinFormsField UnvAccelFrmDateInd = new WinFormsField("UNV-ACCEL-FRM-DATE-IND", "UnvAccelFrmDateInd");
        public static WinFormsField OvrUnvExpiryInd = new WinFormsField("OVR-UNV-EXPIRY-IND", "OvrUnvExpiryInd");
        public static WinFormsField OvrVstExpiryInd = new WinFormsField("OVR-VST-EXPIRY-IND", "OvrVstExpiryInd");
        public static WinFormsField OvrUnvExpiryMonths = new WinFormsField("OVR-UNV-EXPIRY-MONTHS", "OvrUnvExpiryMonths");
        public static WinFormsField OvrVstExpiryMonths = new WinFormsField("OVR-VST-EXPIRY-MONTHS", "OvrVstExpiryMonths");
        public static WinFormsField OvrUnvExpiryDays = new WinFormsField("OVR-UNV-EXPIRY-DAYS", "OvrUnvExpiryDays");
        public static WinFormsField OvrVstExpiryDays = new WinFormsField("OVR-VST-EXPIRY-DAYS", "OvrVstExpiryDays");
        public static WinFormsField OvrUnvFromDateInd = new WinFormsField("OVR-UNV-FROM-DATE-IND", "OvrUnvFromDateInd");
        public static WinFormsField OvrVstFromDateInd = new WinFormsField("OVR-VST-FROM-DATE-IND", "OvrVstFromDateInd");
        public static WinFormsField CommentsLine1 = new WinFormsField("COMMENTS-LINE-1", "CommentsLine1");
        public static WinFormsField CommentsLine2 = new WinFormsField("COMMENTS-LINE-2", "CommentsLine2");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
