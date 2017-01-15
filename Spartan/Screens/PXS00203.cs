using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;


namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00203

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00203", "FormName");
		//Fields
        public static WinFormsField MeetingNumber = new WinFormsField("MEETING NUMBER", "MeetingNumber");
        public static WinFormsField ProxyDescription = new WinFormsField("PROXY DESCRIPTION", "ProxyDescription");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING DATE", "MeetingDate");
        public static WinFormsField IntermediaryOnlineProcessing = new WinFormsField("INTERMEDIARY ONLINE PROCESSING", "IntermediaryOnlineProcessing");
        public static WinFormsField ImoOverVoteProcessingCutOff = new WinFormsField("IMO OVER-VOTE PROCESSING CUT OFF", "ImoOverVoteProcessingCutOff");
        public static WinFormsField ImoCosmosCompanyMeetingID = new WinFormsField("IMO COSMOS COMPANY MEETING ID", "ImoCosmosCompanyMeetingID");
        public static WinFormsField ActivateAutoScheduledJobs = new WinFormsField("ACTIVATE AUTO SCHEDULED JOBS", "ActivateAutoScheduledJobs");
        public static WinFormsField ActivationFromDateRange = new WinFormsField("ACTIVATION FROM DATE RANGE", "ActivationFromDateRange");
        public static WinFormsField ActivationTODateRange = new WinFormsField("ACTIVATION TO DATE RANGE", "ActivationTODateRange");
        public static WinFormsField AutoTopReport = new WinFormsField("AUTO TOP REPORT", "AutoTopReport");
        public static WinFormsField CutoffPoint = new WinFormsField("CUTOFF POINT", "CutoffPoint");
        public static WinFormsField EntitlementClasses = new WinFormsField("ENTITLEMENT CLASSES", "EntitlementClasses");
        public static WinFormsField EntitlementClassGroups = new WinFormsField("ENTITLEMENT CLASS GROUPS", "EntitlementClassGroups");
        public static WinFormsField EntitlementOtherClass = new WinFormsField("ENTITLEMENT OTHER CLASS", "EntitlementOtherClass");
        public static WinFormsField AutoPalsavReport = new WinFormsField("AUTO PAL/SAV REPORT", "AutoPal/savReport");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
