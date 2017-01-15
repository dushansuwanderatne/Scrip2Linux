using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS50899

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS50899", "FormName");
		//Fields


        public static WinFormsField Filename = new WinFormsField("FILENAME", "Filename");
        public static WinFormsField Count = new WinFormsField("COUNT", "Count");
    }
}
