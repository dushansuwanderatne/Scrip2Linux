using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PUBLIC03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PUBLIC03", "FormName");
		//Fields


        public static WinFormsField Password = new WinFormsField("PASSWORD", "Password");
    }
}
