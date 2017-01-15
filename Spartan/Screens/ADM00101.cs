using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ADM00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ADM00101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField VersionNumber = new WinFormsField("VERSION-NUMBER", "VersionNumber");
        public static WinFormsField UseSystemDefaults = new WinFormsField("USE-SYSTEM-DEFAULTS", "UseSystemDefaults");
        public static WinFormsField UseProjects = new WinFormsField("USE-PROJECTS", "UseProjects");
        public static WinFormsField UseSrvrAttributes = new WinFormsField("USE-SRVR-ATTRIBUTES", "UseSrvrAttributes");
        public static WinFormsField PrefixPathname = new WinFormsField("PREFIX-PATHNAME", "PrefixPathname");
        public static WinFormsField PasswordMaxLength = new WinFormsField("PASSWORD-MAX-LENGTH", "PasswordMaxLength");
        public static WinFormsField PasswordMinLength = new WinFormsField("PASSWORD-MIN-LENGTH", "PasswordMinLength");
        public static WinFormsField PasswordLifetime = new WinFormsField("PASSWORD-LIFETIME", "PasswordLifetime");
        public static WinFormsField CompGenPassword = new WinFormsField("COMP-GEN-PASSWORD", "CompGenPassword");
        public static WinFormsField InitialPassword = new WinFormsField("INITIAL-PASSWORD", "InitialPassword");
        public static WinFormsField SpecifyPassword = new WinFormsField("SPECIFY-PASSWORD", "SpecifyPassword");
        public static WinFormsField PasswordRequired = new WinFormsField("PASSWORD-REQUIRED", "PasswordRequired");
        public static WinFormsField VerifyPWFormat = new WinFormsField("VERIFY-PW-FORMAT", "VerifyPWFormat");
        public static WinFormsField CreateOrigin = new WinFormsField("CREATE-ORIGIN", "CreateOrigin");
        public static WinFormsField ForcePassword = new WinFormsField("FORCE-PASSWORD", "ForcePassword");
        public static WinFormsField SpecifyOrigin = new WinFormsField("SPECIFY-ORIGIN", "SpecifyOrigin");
        public static WinFormsField VerifyOrigin = new WinFormsField("VERIFY-ORIGIN", "VerifyOrigin");
        public static WinFormsField CommandLevels = new WinFormsField("COMMAND-LEVELS", "CommandLevels");
        public static WinFormsField ProgramInvocations = new WinFormsField("PROGRAM-INVOCATIONS", "ProgramInvocations");
        public static WinFormsField DynamicSegments = new WinFormsField("DYNAMIC-SEGMENTS", "DynamicSegments");
        public static WinFormsField StaticSegments = new WinFormsField("STATIC-SEGMENTS", "StaticSegments");
        public static WinFormsField UseV2Encryption = new WinFormsField("USE-V2-ENCRYPTION", "UseV2Encryption");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
