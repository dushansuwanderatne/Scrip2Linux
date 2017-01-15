using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS25010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS25010", "FormName");
		//Fields


        public static WinFormsField NightlyRunInd = new WinFormsField("NIGHTLY-RUN-IND", "NightlyRunInd");
    }
}
