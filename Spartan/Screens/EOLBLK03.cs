using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOLBLK03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOLBLK03", "FormName");
		//Fields


        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterDescription = new WinFormsField("REGISTER-DESCRIPTION", "RegisterDescription");
        public static WinFormsField ReleaseType = new WinFormsField("RELEASE-TYPE", "ReleaseType");
        public static WinFormsField Dot = new WinFormsField("DOT", "Dot");
        public static WinFormsField ReleaseDesc = new WinFormsField("RELEASE-DESC", "ReleaseDesc");
        public static WinFormsField DefaultRelType = new WinFormsField("DEFAULT-REL-TYPE", "DefaultRelType");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField InputFilename = new WinFormsField("INPUT-FILENAME", "InputFilename");
        public static WinFormsField IncludeResidue = new WinFormsField("INCLUDE-RESIDUE", "IncludeResidue");
        public static WinFormsField IncludeDiv = new WinFormsField("INCLUDE-DIV", "IncludeDiv");
        public static WinFormsField CheckRetentionDates = new WinFormsField("CHECK-RETENTION-DATES", "CheckRetentionDates");
        public static WinFormsField ReleaseAllReg = new WinFormsField("RELEASE-ALL-REG", "ReleaseAllReg");
        public static WinFormsField ReleaseMode = new WinFormsField("RELEASE-MODE", "ReleaseMode");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
