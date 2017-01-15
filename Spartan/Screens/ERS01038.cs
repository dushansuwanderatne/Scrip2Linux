using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01038

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01038", "FormName");
		//Fields
        public static WinFormsField LeaverSchedDesc = new WinFormsField("LEAVER-SCHED-DESC", "LeaverSchedDesc");
        public static WinFormsField LeaverCode = new WinFormsField("LEAVER-CODE", "LeaverCode");
        public static WinFormsField LeaverCodeDesc = new WinFormsField("LEAVER-CODE-DESC", "LeaverCodeDesc");
        public static WinFormsField EmployeeStatus = new WinFormsField("EMPLOYEE-STATUS", "EmployeeStatus");
        public static WinFormsField EmployeeStatusDesc = new WinFormsField("EMPLOYEE-STATUS-DESC", "EmployeeStatusDesc");
        public static WinFormsField LeaverEffectInd = new WinFormsField("LEAVER-EFFECT-IND", "LeaverEffectInd");
        public static WinFormsField MaintainRestrctInd = new WinFormsField("MAINTAIN-RESTRCT-IND", "MaintainRestrctInd");
        public static WinFormsField PhantomLvrTypeInd = new WinFormsField("PHANTOM-LVR-TYPE-IND", "PhantomLvrTypeInd");
        public static WinFormsField OverrideExpiry = new WinFormsField("OVERRIDE-EXPIRY", "OverrideExpiry");
        public static WinFormsField OverridePeriod = new WinFormsField("OVERRIDE-PERIOD", "OverridePeriod");
        public static WinFormsField OverrideFromDate = new WinFormsField("OVERRIDE-FROM-DATE", "OverrideFromDate");
        public static WinFormsField UnvNOChgInd = new WinFormsField("UNV-NO-CHG-IND", "UnvNOChgInd");
        public static WinFormsField UnvCancelImm = new WinFormsField("UNV-CANCEL-IMM", "UnvCancelImm");
        public static WinFormsField UnvAccelVst = new WinFormsField("UNV-ACCEL-VST", "UnvAccelVst");
        public static WinFormsField UnvAccelPeriod = new WinFormsField("UNV-ACCEL-PERIOD", "UnvAccelPeriod");
        public static WinFormsField UnvAccelFrmDate = new WinFormsField("UNV-ACCEL-FRM-DATE", "UnvAccelFrmDate");
        public static WinFormsField VstNOChgInd = new WinFormsField("VST-NO-CHG-IND", "VstNOChgInd");
        public static WinFormsField VstCancelImm = new WinFormsField("VST-CANCEL-IMM", "VstCancelImm");
        public static WinFormsField VstIgnoreBlackout = new WinFormsField("VST-IGNORE-BLACKOUT", "VstIgnoreBlackout");
        public static WinFormsField Comments = new WinFormsField("COMMENTS", "Comments");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
