using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISUCDE00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISUCDE00", "FormName");
		//Fields


        public static WinFormsField IsucdeKey0 = new WinFormsField("ISUCDE-KEY0", "IsucdeKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
