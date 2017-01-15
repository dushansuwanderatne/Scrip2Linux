using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PMHCOY05

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PMHCOY05", "FormName");
		//Fields


        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField OldCode1 = new WinFormsField("OLD-CODE-1", "OldCode1");
        public static WinFormsField OldDesc = new WinFormsField("OLD-DESC", "OldDesc");
        public static WinFormsField DrpType = new WinFormsField("DRP-TYPE", "DrpType");
        public static WinFormsField DrpCategory = new WinFormsField("DRP-CATEGORY", "DrpCategory");
    }
}
