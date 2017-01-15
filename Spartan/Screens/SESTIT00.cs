using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SESTIT00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SESTIT00", "FormName");
		//Fields


        public static WinFormsField SestotKey0 = new WinFormsField("SESTOT-KEY0", "SestotKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
