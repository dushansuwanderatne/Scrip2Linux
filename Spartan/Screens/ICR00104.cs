using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR00104

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR00104", "FormName");
		//Fields


        public static WinFormsField LineNbrX = new WinFormsField("LINE-NBR-X", "LineNbrX");
        public static WinFormsField CompanyUfd = new WinFormsField("COMPANY-UFD", "CompanyUfd");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField FirstReconDate = new WinFormsField("FIRST-RECON-DATE", "FirstReconDate");
        public static WinFormsField LastReconDate = new WinFormsField("LAST-RECON-DATE", "LastReconDate");
        public static WinFormsField ActionX = new WinFormsField("ACTION-X", "ActionX");
    }
}
