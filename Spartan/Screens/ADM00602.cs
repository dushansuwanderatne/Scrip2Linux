using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ADM00602

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ADM00602", "FormName");
		//Fields


        public static WinFormsField UserName = new WinFormsField("USER-NAME", "UserName");
        public static WinFormsField ConfirmDelete = new WinFormsField("CONFIRM-DELETE", "ConfirmDelete");
    }
}
