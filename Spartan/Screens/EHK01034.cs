using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01034

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01034", "FormName");
		//Fields
        public static WinFormsField PlanType = new WinFormsField("PLAN-TYPE", "PlanType");
        public static WinFormsField LeaverSchedule = new WinFormsField("LEAVER-SCHEDULE", "LeaverSchedule");
        public static WinFormsField LeaverScheduleDesc = new WinFormsField("LEAVER-SCHEDULE-DESC", "LeaverScheduleDesc");
        public static WinFormsField LeaverCode = new WinFormsField("LEAVER-CODE", "LeaverCode");
        public static WinFormsField LeaverCodeDesc = new WinFormsField("LEAVER-CODE-DESC", "LeaverCodeDesc");
        public static WinFormsField EmployeeStatus = new WinFormsField("EMPLOYEE-STATUS", "EmployeeStatus");
        public static WinFormsField EmpStatusDesc = new WinFormsField("EMP-STATUS-DESC", "EmpStatusDesc");
        public static WinFormsField LeaverEffectInd = new WinFormsField("LEAVER-EFFECT-IND", "LeaverEffectInd");
        public static WinFormsField MaintainRestrictInd = new WinFormsField("MAINTAIN-RESTRICT-IND", "MaintainRestrictInd");
        public static WinFormsField PhantomLeaverType = new WinFormsField("PHANTOM-LEAVER-TYPE", "PhantomLeaverType");
        public static WinFormsField RelsONEmpEndInd = new WinFormsField("RELS-ON-EMP-END-IND", "RelsONEmpEndInd");
        public static WinFormsField ForfImmInd = new WinFormsField("FORF-IMM-IND", "ForfImmInd");
        public static WinFormsField AccelerateAvailInd = new WinFormsField("ACCELERATE-AVAIL-IND", "AccelerateAvailInd");
        public static WinFormsField AccelerateMonths = new WinFormsField("ACCELERATE-MONTHS", "AccelerateMonths");
        public static WinFormsField AccelerateDays = new WinFormsField("ACCELERATE-DAYS", "AccelerateDays");
        public static WinFormsField AccelFrmDateInd = new WinFormsField("ACCEL-FRM-DATE-IND", "AccelFrmDateInd");
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
