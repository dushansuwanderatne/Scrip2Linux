using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSSCH00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSSCH00", "FormName");
		//Fields


        public static WinFormsField EssschKey0 = new WinFormsField("ESSSCH-KEY0", "EssschKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
