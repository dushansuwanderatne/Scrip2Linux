using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TESTER

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TESTER", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Warnings = new WinFormsField("WARNINGS", "Warnings");
        public static WinFormsField Method = new WinFormsField("METHOD", "Method");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField Certificate = new WinFormsField("CERTIFICATE", "Certificate");
        public static WinFormsField NameKey = new WinFormsField("NAME-KEY", "NameKey");
        public static WinFormsField PayKey = new WinFormsField("PAY-KEY", "PayKey");
    }
}
