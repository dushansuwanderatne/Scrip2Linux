using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSUNP00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSUNP00", "FormName");
		//Fields


        public static WinFormsField CrsunpKey0 = new WinFormsField("CRSUNP-KEY0", "CrsunpKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
