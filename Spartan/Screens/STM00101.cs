using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class STM00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("STM00101", "FormName");
		//Fields


        public static WinFormsField MenuItemErm = new WinFormsField("MENU-ITEM-ERM", "ERM. EOM Exclusion/Inclusion Rule Maintenance", "EOMExclusion/InclusionRuleMaintenance");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField MenuItemEar = new WinFormsField("MENU-ITEM-EAR", "EAR. EOM Exclusion Audit Report", "EOMExclusionAuditReport");
        public static WinFormsField MenuItemEsr = new WinFormsField("MENU-ITEM-ESR", "ESR. EOM Status Report", "EOMStatusReport");
        public static WinFormsField MenuItemEcr = new WinFormsField("MENU-ITEM-ECR", "ECR. EOM Compliance Report", "EOMComplianceReport");
        public static WinFormsField MenuItemEsq = new WinFormsField("MENU-ITEM-ESQ", "ESQ. EOM Statement Enquiry", "EOMStatementEnquiry");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
