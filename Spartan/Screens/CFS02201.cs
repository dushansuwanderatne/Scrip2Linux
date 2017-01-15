using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS02201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS02201", "FormName");
		//Fields


        public static WinFormsField ServiceCode = new WinFormsField("SERVICE-CODE", "ServiceCode");
        public static WinFormsField ServiceDesc = new WinFormsField("SERVICE-DESC", "ServiceDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
