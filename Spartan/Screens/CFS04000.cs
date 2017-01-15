using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS04000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS04000", "FormName");
		//Fields


        public static WinFormsField GroupCode = new WinFormsField("GROUP-CODE", "GroupCode");
        public static WinFormsField GroupDesc = new WinFormsField("GROUP-DESC", "GroupDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
