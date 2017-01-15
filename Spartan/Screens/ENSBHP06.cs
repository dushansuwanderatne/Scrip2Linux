using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSBHP06

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSBHP06", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField StatementLit = new WinFormsField("STATEMENT-LIT", "StatementLit");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField Reference = new WinFormsField("REFERENCE", "Reference");
        public static WinFormsField OpsInitials = new WinFormsField("OPS-INITIALS", "OpsInitials");
        public static WinFormsField ClassRow1 = new WinFormsField("CLASS-ROW-1", "ClassRow1");
        public static WinFormsField ClassRow2 = new WinFormsField("CLASS-ROW-2", "ClassRow2");
    }
}
