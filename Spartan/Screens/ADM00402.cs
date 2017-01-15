using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ADM00402

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ADM00402", "FormName");
		//Fields


        public static WinFormsField ProjectName = new WinFormsField("PROJECT-NAME", "ProjectName");
        public static WinFormsField DefAclName = new WinFormsField("DEF-ACL-NAME", "DefAclName");
        public static WinFormsField AdminName = new WinFormsField("ADMIN-NAME", "AdminName");
        public static WinFormsField DRCommandLevels = new WinFormsField("DR-COMMAND-LEVELS", "DRCommandLevels");
        public static WinFormsField DRProgramInvokes = new WinFormsField("DR-PROGRAM-INVOKES", "DRProgramInvokes");
        public static WinFormsField DRDynamicSegments = new WinFormsField("DR-DYNAMIC-SEGMENTS", "DRDynamicSegments");
        public static WinFormsField DRStaticSegments = new WinFormsField("DR-STATIC-SEGMENTS", "DRStaticSegments");
        public static WinFormsField DRIscSessions = new WinFormsField("DR-ISC-SESSIONS", "DRIscSessions");
        public static WinFormsField DRIscSynchronizers = new WinFormsField("DR-ISC-SYNCHRONIZERS", "DRIscSynchronizers");
        public static WinFormsField DRIscTimers = new WinFormsField("DR-ISC-TIMERS", "DRIscTimers");
        public static WinFormsField OrigAttPntPath1 = new WinFormsField("ORIG-ATT-PNT-PATH-1", "OrigAttPntPath1");
        public static WinFormsField Response = new WinFormsField("RESPONSE", "Response");
        public static WinFormsField ConfirmDelete = new WinFormsField("CONFIRM-DELETE", "ConfirmDelete");
    }
}
