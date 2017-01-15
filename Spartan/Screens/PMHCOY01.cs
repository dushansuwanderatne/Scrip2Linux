using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PMHCOY01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PMHCOY01", "FormName");
		//Fields


        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField OldCode2 = new WinFormsField("OLD-CODE-2", "OldCode2");
        public static WinFormsField OldDesc = new WinFormsField("OLD-DESC", "OldDesc");
        public static WinFormsField NewCode3 = new WinFormsField("NEW-CODE-3", "NewCode3");
    }
}
