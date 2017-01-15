using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class GHDREF01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("GHDREF01", "FormName");
		//Fields


        public static WinFormsField RefSelLine = new WinFormsField("REF-SEL-LINE", "RefSelLine");
        public static WinFormsField RefDtlLine = new WinFormsField("REF-DTL-LINE", "RefDtlLine");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField InfoMessage = new WinFormsField("INFO-MESSAGE", "InfoMessage");
    }
}
