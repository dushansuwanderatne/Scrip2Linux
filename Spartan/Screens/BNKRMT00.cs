using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BNKRMT00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BNKRMT00", "FormName");
		//Fields


        public static WinFormsField BnkrmtKey0 = new WinFormsField("BNKRMT-KEY0", "BnkrmtKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField BnkrmtKey1 = new WinFormsField("BNKRMT-KEY1", "BnkrmtKey1");
    }
}
