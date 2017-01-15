using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PMHCOY09

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PMHCOY09", "FormName");
		//Fields


        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField MenuOldCode = new WinFormsField("MENU-OLD-CODE", "MenuOldCode");
        public static WinFormsField OldDesc = new WinFormsField("OLD-DESC", "OldDesc");
        public static WinFormsField NewCode3 = new WinFormsField("NEW-CODE-3", "NewCode3");
    }
}
