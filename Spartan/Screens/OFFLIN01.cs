using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OFFLIN01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OFFLIN01", "FormName");
		//Fields


        public static WinFormsField Key = new WinFormsField("KEY", "Key");
        public static WinFormsField Surname = new WinFormsField("SURNAME", "Surname");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
