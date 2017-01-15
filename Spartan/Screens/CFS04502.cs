using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS04502

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS04502", "FormName");
		//Fields


        public static WinFormsField FileGroupCode = new WinFormsField("FILE-GROUP-CODE", "FileGroupCode");
        public static WinFormsField ShortDesc = new WinFormsField("SHORT-DESC", "ShortDesc");
        public static WinFormsField LongDesc = new WinFormsField("LONG-DESC", "LongDesc");
        public static WinFormsField DssIndexedInd = new WinFormsField("DSS-INDEXED-IND", "DssIndexedInd");
        public static WinFormsField AuthorisationReqInd = new WinFormsField("AUTHORISATION-REQ-IND", "AuthorisationReqInd");
        public static WinFormsField PendingEmailReqInd = new WinFormsField("PENDING-EMAIL-REQ-IND", "PendingEmailReqInd");
        public static WinFormsField PendingEmailAddress = new WinFormsField("PENDING-EMAIL-ADDRESS", "PendingEmailAddress");
        public static WinFormsField Subsystem = new WinFormsField("SUBSYSTEM", "Subsystem");
        public static WinFormsField FileGroupSecurity = new WinFormsField("FILE-GROUP-SECURITY", "FileGroupSecurity");
        public static WinFormsField CurrentInd = new WinFormsField("CURRENT-IND", "CurrentInd");
        public static WinFormsField GroupContactEmail = new WinFormsField("GROUP-CONTACT-EMAIL", "GroupContactEmail");
        public static WinFormsField BatchQueue = new WinFormsField("BATCH-QUEUE", "BatchQueue");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
