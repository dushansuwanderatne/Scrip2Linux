using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL06006

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL06006", "FormName");
		//Fields


        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterDesc = new WinFormsField("REGISTER-DESC", "RegisterDesc");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField ChangeAst = new WinFormsField("CHANGE-AST", "ChangeAst");
        public static WinFormsField FromVestingCode = new WinFormsField("FROM-VESTING-CODE", "FromVestingCode");
        public static WinFormsField FromPerformanceCode = new WinFormsField("FROM-PERFORMANCE-CODE", "FromPerformanceCode");
        public static WinFormsField FromVestingDesc = new WinFormsField("FROM-VESTING-DESC", "FromVestingDesc");
        public static WinFormsField FromPerformanceDesc = new WinFormsField("FROM-PERFORMANCE-DESC", "FromPerformanceDesc");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField TOVestingCode = new WinFormsField("TO-VESTING-CODE", "TOVestingCode");
        public static WinFormsField TOVestingDesc = new WinFormsField("TO-VESTING-DESC", "TOVestingDesc");
        public static WinFormsField TOPerformanceCode = new WinFormsField("TO-PERFORMANCE-CODE", "TOPerformanceCode");
        public static WinFormsField TOPerformanceDesc = new WinFormsField("TO-PERFORMANCE-DESC", "TOPerformanceDesc");
    }
}
