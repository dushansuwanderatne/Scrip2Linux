using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LSTHBH00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LSTHBH00", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField LsthbhKey0 = new WinFormsField("LSTHBH-KEY0", "LsthbhKey0");
    }
}
