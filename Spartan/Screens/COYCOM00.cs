using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class COYCOM00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("COYCOM00", "FormName");
		//Fields


        public static WinFormsField CoycomKey0 = new WinFormsField("COYCOM-KEY0", "CoycomKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
