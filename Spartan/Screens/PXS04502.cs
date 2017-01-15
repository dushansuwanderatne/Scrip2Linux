using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS04502

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS04502", "FormName");
		//Fields


        public static WinFormsField ResolutionLine = new WinFormsField("RESOLUTION-LINE", "ResolutionLine");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
