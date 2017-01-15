using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS00243

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS00243", "FormName");
		//Fields


        public static WinFormsField ExtractName = new WinFormsField("EXTRACT-NAME", "ExtractName");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
