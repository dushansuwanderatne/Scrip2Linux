using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CNTROL00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CNTROL00", "FormName");
		//Fields


        public static WinFormsField CntrolKey0 = new WinFormsField("CNTROL-KEY0", "CntrolKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
