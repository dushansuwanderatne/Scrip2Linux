using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG06500

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG06500", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchCompany = new WinFormsField("SEARCH-COMPANY", "SearchCompany");
        public static WinFormsField SearchSecurity = new WinFormsField("SEARCH-SECURITY", "SearchSecurity");
    }
}
