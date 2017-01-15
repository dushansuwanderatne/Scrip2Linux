using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LSTLCH00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LSTLCH00", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField LstlchKey0 = new WinFormsField("LSTLCH-KEY0", "LstlchKey0");
    }
}
