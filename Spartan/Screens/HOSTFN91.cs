using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFN91

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFN91", "FormName");
		//Fields


        public static WinFormsField Lines = new WinFormsField("LINES", "Lines");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
