using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class REGCOM00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("REGCOM00", "FormName");
		//Fields


        public static WinFormsField RegcomKey0 = new WinFormsField("REGCOM-KEY0", "RegcomKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
