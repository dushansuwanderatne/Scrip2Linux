using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRTEXT00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRTEXT00", "FormName");
		//Fields


        public static WinFormsField CrtextKey0 = new WinFormsField("CRTEXT-KEY0", "CrtextKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
