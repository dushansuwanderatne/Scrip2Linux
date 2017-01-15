using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DMP01090

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DMP01090", "FormName");
		//Fields


        public static WinFormsField WarnClass1 = new WinFormsField("WARN-CLASS-1", "WarnClass1");
        public static WinFormsField WarnClass2 = new WinFormsField("WARN-CLASS-2", "WarnClass2");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
