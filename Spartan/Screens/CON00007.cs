using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CON00007

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CON00007", "FormName");
		//Fields


        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField OldCode1 = new WinFormsField("OLD-CODE-1", "OldCode1");
        public static WinFormsField NewCode1 = new WinFormsField("NEW-CODE-1", "NewCode1");
        public static WinFormsField NewDesc = new WinFormsField("NEW-DESC", "NewDesc");
    }
}
