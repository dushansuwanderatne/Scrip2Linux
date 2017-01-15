using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEYT0190

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEYT0190", "FormName");
		//Fields


        public static WinFormsField Desc1 = new WinFormsField("DESC1", "Desc1");
        public static WinFormsField Desc2 = new WinFormsField("DESC2", "Desc2");
        public static WinFormsField Desc3 = new WinFormsField("DESC3", "Desc3");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Desc4 = new WinFormsField("DESC4", "Desc4");
    }
}
