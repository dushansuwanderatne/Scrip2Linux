using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR010AD

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR010AD", "FormName");
		//Fields


        public static WinFormsField ASATDate = new WinFormsField("AS-AT-DATE", "ASATDate");
    }
}
