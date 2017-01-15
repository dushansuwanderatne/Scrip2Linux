using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01516

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01516", "FormName");
		//Fields


        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField StopChqThreshold = new WinFormsField("STOP-CHQ-THRESHOLD", "StopChqThreshold");
        public static WinFormsField PreApprovalChq = new WinFormsField("PRE-APPROVAL-CHQ", "PreApprovalChq");
        public static WinFormsField PreApprovalDC = new WinFormsField("PRE-APPROVAL-DC", "PreApprovalDC");
        public static WinFormsField HldChgAppliesInd = new WinFormsField("HLD-CHG-APPLIES-IND", "HldChgAppliesInd");
        public static WinFormsField HldChgThresholdChq = new WinFormsField("HLD-CHG-THRESHOLD-CHQ", "HldChgThresholdChq");
        public static WinFormsField HldChgThresholdDC = new WinFormsField("HLD-CHG-THRESHOLD-DC", "HldChgThresholdDC");
        public static WinFormsField CoyInfoChargeValue = new WinFormsField("COY-INFO-CHARGE-VALUE", "CoyInfoChargeValue");
        public static WinFormsField CoyInfoChargeTrans = new WinFormsField("COY-INFO-CHARGE-TRANS", "CoyInfoChargeTrans");
        public static WinFormsField CoyInfoChargePymts = new WinFormsField("COY-INFO-CHARGE-PYMTS", "CoyInfoChargePymts");
        public static WinFormsField CoyInfoChargeCgt = new WinFormsField("COY-INFO-CHARGE-CGT", "CoyInfoChargeCgt");
        public static WinFormsField CoyDCPrefAU = new WinFormsField("COY-DC-PREF-AU", "CoyDCPrefAU");
        public static WinFormsField CoyDCPrefUK = new WinFormsField("COY-DC-PREF-UK", "CoyDCPrefUK");
        public static WinFormsField CoyDCPrefNZ = new WinFormsField("COY-DC-PREF-NZ", "CoyDCPrefNZ");
        public static WinFormsField CoyDCPrefUS = new WinFormsField("COY-DC-PREF-US", "CoyDCPrefUS");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField MultiCertExercises = new WinFormsField("ALLOW-MULT-CERT-IND", "MultiCertExercises");
    }
}
