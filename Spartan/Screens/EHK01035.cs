using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01035

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01035", "FormName");
		//Fields
        public static WinFormsField PlanType = new WinFormsField("PLAN-TYPE", "PlanType");
        public static WinFormsField LeaverSchedule = new WinFormsField("LEAVER-SCHEDULE", "LeaverSchedule");
        public static WinFormsField LeaverScheduleDesc = new WinFormsField("LEAVER-SCHEDULE-DESC", "LeaverScheduleDesc");
        public static WinFormsField LeaverCode = new WinFormsField("LEAVER-CODE", "LeaverCode");
        public static WinFormsField LeaverCodeDesc = new WinFormsField("LEAVER-CODE-DESC", "LeaverCodeDesc");
        public static WinFormsField EmployeeStatus = new WinFormsField("EMPLOYEE-STATUS", "EmployeeStatus");
        public static WinFormsField EmpStatusDesc = new WinFormsField("EMP-STATUS-DESC", "EmpStatusDesc");
        public static WinFormsField OverrideExpiryInd = new WinFormsField("OVERRIDE-EXPIRY-IND", "OverrideExpiryInd");
        public static WinFormsField OverrideMonths = new WinFormsField("OVERRIDE-MONTHS", "OverrideMonths");
        public static WinFormsField OverrideDays = new WinFormsField("OVERRIDE-DAYS", "OverrideDays");
        public static WinFormsField OverrideFromDateInd = new WinFormsField("OVERRIDE-FROM-DATE-IND", "OverrideFromDateInd");
        public static WinFormsField UnvNOChgInd = new WinFormsField("UNV-NO-CHG-IND", "UnvNOChgInd");
        public static WinFormsField UnvCancelImmInd = new WinFormsField("UNV-CANCEL-IMM-IND", "UnvCancelImmInd");
        public static WinFormsField UnvAccelerateVstInd = new WinFormsField("UNV-ACCELERATE-VST-IND", "UnvAccelerateVstInd");
        public static WinFormsField UnvAccelerateMonths = new WinFormsField("UNV-ACCELERATE-MONTHS", "UnvAccelerateMonths");
        public static WinFormsField UnvAccelerateDays = new WinFormsField("UNV-ACCELERATE-DAYS", "UnvAccelerateDays");
        public static WinFormsField UnvAccelFrmDateInd = new WinFormsField("UNV-ACCEL-FRM-DATE-IND", "UnvAccelFrmDateInd");
        public static WinFormsField VstNOChgInd = new WinFormsField("VST-NO-CHG-IND", "VstNOChgInd");
        public static WinFormsField VstCancelImmInd = new WinFormsField("VST-CANCEL-IMM-IND", "VstCancelImmInd");
        public static WinFormsField VstIgnoreBlackout = new WinFormsField("VST-IGNORE-BLACKOUT", "VstIgnoreBlackout");
        public static WinFormsField CommentsLine1 = new WinFormsField("COMMENTS-LINE-1", "CommentsLine1");
        public static WinFormsField CommentsLine2 = new WinFormsField("COMMENTS-LINE-2", "CommentsLine2");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField LocateArgumentPln = new WinFormsField("LOCATE-ARGUMENT-PLN", "LocateArgumentPln");
        public static WinFormsField LocateArgumentSch = new WinFormsField("LOCATE-ARGUMENT-SCH", "LocateArgumentSch");
        public static WinFormsField LocateArgumentLvr = new WinFormsField("LOCATE-ARGUMENT-LVR", "LocateArgumentLvr");
        public static WinFormsField LocateArgumentEmp = new WinFormsField("LOCATE-ARGUMENT-EMP", "LocateArgumentEmp");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
