using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TAL00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TAL00101", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 6", "6");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 3", "3");
        public static WinFormsField ProblemNumber = new WinFormsField("PROBLEM-NUMBER", "ProblemNumber");
        public static WinFormsField CshareStaff = new WinFormsField("CSHARE-STAFF", "CshareStaff");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField ClientName = new WinFormsField("CLIENT-NAME", "ClientName");
        public static WinFormsField ClientPhone = new WinFormsField("CLIENT-PHONE", "ClientPhone");
        public static WinFormsField ClientPriority = new WinFormsField("CLIENT-PRIORITY", "ClientPriority");
        public static WinFormsField BriefDesc = new WinFormsField("BRIEF-DESC", "BriefDesc");
        public static WinFormsField FullDesc = new WinFormsField("FULL-DESC", "FullDesc");
        public static WinFormsField ProblemOccurred = new WinFormsField("PROBLEM-OCCURRED", "ProblemOccurred");
        //public static WinFormsField FormName = new WinFormsField("FORM-NAME", "FormName");
        public static WinFormsField RevisionNumber = new WinFormsField("REVISION-NUMBER", "RevisionNumber");
        public static WinFormsField SlotNumber = new WinFormsField("SLOT-NUMBER", "SlotNumber");
        public static WinFormsField ProblemRecurs = new WinFormsField("PROBLEM-RECURS", "ProblemRecurs");
        public static WinFormsField ProblemFrequency = new WinFormsField("PROBLEM-FREQUENCY", "ProblemFrequency");
        public static WinFormsField UsersAffected = new WinFormsField("USERS-AFFECTED", "UsersAffected");
    }
}
