using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSDIS02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSDIS02", "FormName");
		//Fields


        public static WinFormsField ExtraDetails = new WinFormsField("EXTRA-DETAILS", "ExtraDetails");
    }
}
