using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELSRV01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELSRV01", "FormName");
		//Fields
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
