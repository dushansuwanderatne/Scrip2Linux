using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ADM00401

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ADM00401", "FormName");
		//Fields


        public static WinFormsField ProjectName = new WinFormsField("PROJECT-NAME", "ProjectName");
        public static WinFormsField AclName = new WinFormsField("ACL-NAME", "AclName");
        public static WinFormsField AdminName = new WinFormsField("ADMIN-NAME", "AdminName");
        public static WinFormsField PRVersion = new WinFormsField("PR-VERSION", "PRVersion");
        public static WinFormsField PRSize = new WinFormsField("PR-SIZE", "PRSize");
        public static WinFormsField PRCommandLevels = new WinFormsField("PR-COMMAND-LEVELS", "PRCommandLevels");
        public static WinFormsField PRProgramInvokes = new WinFormsField("PR-PROGRAM-INVOKES", "PRProgramInvokes");
        public static WinFormsField PRDynamicSegments = new WinFormsField("PR-DYNAMIC-SEGMENTS", "PRDynamicSegments");
        public static WinFormsField PRStaticSegments = new WinFormsField("PR-STATIC-SEGMENTS", "PRStaticSegments");
        public static WinFormsField PRIscSessions = new WinFormsField("PR-ISC-SESSIONS", "PRIscSessions");
        public static WinFormsField PRIscSynchronizers = new WinFormsField("PR-ISC-SYNCHRONIZERS", "PRIscSynchronizers");
        public static WinFormsField PRIscTimers = new WinFormsField("PR-ISC-TIMERS", "PRIscTimers");
        public static WinFormsField OrigAttPntPath1 = new WinFormsField("ORIG-ATT-PNT-PATH-1", "OrigAttPntPath1");
        public static WinFormsField ConfirmDelete = new WinFormsField("CONFIRM-DELETE", "ConfirmDelete");
        public static WinFormsField Response = new WinFormsField("RESPONSE", "Response");
    }
}
