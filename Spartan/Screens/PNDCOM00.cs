using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PNDCOM00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PNDCOM00", "FormName");
		//Fields


        public static WinFormsField PndcomKey0 = new WinFormsField("PNDCOM-KEY0", "PndcomKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
