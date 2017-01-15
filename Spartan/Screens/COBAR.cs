using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class COBAR

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("COBAR", "FormName");
		//Fields


        public static WinFormsField Description1 = new WinFormsField("DESCRIPTION1", "Description1");
        public static WinFormsField Description2 = new WinFormsField("DESCRIPTION2", "Description2");
        public static WinFormsField Accept = new WinFormsField("ACCEPT", "Accept");
    }
}
