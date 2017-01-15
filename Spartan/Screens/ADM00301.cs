using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ADM00301

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ADM00301", "FormName");
		//Fields


        public static WinFormsField UserName = new WinFormsField("USER-NAME", "UserName");
        public static WinFormsField AclName = new WinFormsField("ACL-NAME", "AclName");
        public static WinFormsField ProjectName = new WinFormsField("PROJECT-NAME", "ProjectName");
        public static WinFormsField AssumedProjectFlag = new WinFormsField("ASSUMED-PROJECT-FLAG", "AssumedProjectFlag");
        public static WinFormsField AssumedProject = new WinFormsField("ASSUMED-PROJECT", "AssumedProject");
        public static WinFormsField CommandLevels = new WinFormsField("COMMAND-LEVELS", "CommandLevels");
        public static WinFormsField ProgramInvokes = new WinFormsField("PROGRAM-INVOKES", "ProgramInvokes");
        public static WinFormsField DynamicSegments = new WinFormsField("DYNAMIC-SEGMENTS", "DynamicSegments");
        public static WinFormsField StaticSegments = new WinFormsField("STATIC-SEGMENTS", "StaticSegments");
        public static WinFormsField UserPassword = new WinFormsField("USER-PASSWORD", "UserPassword");
        public static WinFormsField LastPasswordChange = new WinFormsField("LAST-PASSWORD-CHANGE", "LastPasswordChange");
        public static WinFormsField PasswordLifetime = new WinFormsField("PASSWORD-LIFETIME", "PasswordLifetime");
        public static WinFormsField InitAttPntPath1 = new WinFormsField("INIT-ATT-PNT-PATH-1", "InitAttPntPath1");
        public static WinFormsField ConfirmDelete = new WinFormsField("CONFIRM-DELETE", "ConfirmDelete");
        public static WinFormsField DayOFTheWeek = new WinFormsField("DAY-OF-THE-WEEK", "DayOFTheWeek");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField Time = new WinFormsField("TIME", "Time");
        public static WinFormsField Response = new WinFormsField("RESPONSE", "Response");
    }
}
