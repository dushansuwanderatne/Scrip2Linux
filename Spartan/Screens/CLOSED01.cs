using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CLOSED01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CLOSED01", "FormName");
		//Fields


        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField CompanyNoticeLine = new WinFormsField("COMPANY-NOTICE-LINE", "CompanyNoticeLine");
    }
}
