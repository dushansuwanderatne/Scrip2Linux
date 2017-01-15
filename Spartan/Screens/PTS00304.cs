using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PTS00304

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PTS00304", "FormName");
		//Fields


        public static WinFormsField Number = new WinFormsField("NUMBER", "Number");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField AllocatedTO = new WinFormsField("ALLOCATED-TO", "AllocatedTO");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
