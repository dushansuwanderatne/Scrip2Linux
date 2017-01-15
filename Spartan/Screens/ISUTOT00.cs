using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISUTOT00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISUTOT00", "FormName");
		//Fields


        public static WinFormsField IsutotKey0 = new WinFormsField("ISUTOT-KEY0", "IsutotKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
