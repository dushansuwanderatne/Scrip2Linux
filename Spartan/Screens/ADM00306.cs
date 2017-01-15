using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ADM00306

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ADM00306", "FormName");
		//Fields


        public static WinFormsField NewUser = new WinFormsField("NEW-USER", "NewUser");
        public static WinFormsField OldUser = new WinFormsField("OLD-USER", "OldUser");
    }
}
