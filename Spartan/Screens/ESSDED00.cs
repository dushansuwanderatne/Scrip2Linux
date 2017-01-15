using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSDED00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSDED00", "FormName");
		//Fields


        public static WinFormsField EssdedKey0 = new WinFormsField("ESSDED-KEY0", "EssdedKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
