using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFN65

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFN65", "FormName");
		//Fields


        public static WinFormsField JobLine = new WinFormsField("JOB-LINE", "JobLine");
        public static WinFormsField JobNumber = new WinFormsField("JOB-NUMBER", "JobNumber");
    }
}
