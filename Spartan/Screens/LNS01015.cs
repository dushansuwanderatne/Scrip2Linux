using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS01015

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS01015", "FormName");
		//Fields


        public static WinFormsField HolderName1 = new WinFormsField("HOLDER-NAME-1", "HolderName1");
        public static WinFormsField HolderName2 = new WinFormsField("HOLDER-NAME-2", "HolderName2");
    }
}
