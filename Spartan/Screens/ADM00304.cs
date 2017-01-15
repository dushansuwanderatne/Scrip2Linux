using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ADM00304

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ADM00304", "FormName");
		//Fields


        public static WinFormsField ProjectName = new WinFormsField("PROJECT-NAME", "ProjectName");
        public static WinFormsField Response = new WinFormsField("RESPONSE", "Response");
    }
}
