using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELDEP01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELDEP01", "FormName");
		//Fields


        public static WinFormsField Depart = new WinFormsField("DEPART", "Depart");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
