using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CON00012

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CON00012", "FormName");
		//Fields


        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField OldCode2 = new WinFormsField("OLD-CODE-2", "OldCode2");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
