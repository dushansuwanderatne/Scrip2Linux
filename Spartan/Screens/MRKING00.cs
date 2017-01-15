using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MRKING00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MRKING00", "FormName");
		//Fields


        public static WinFormsField MrkingKey0 = new WinFormsField("MRKING-KEY0", "MrkingKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
