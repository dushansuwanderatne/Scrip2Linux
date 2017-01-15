using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELORG01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELORG01", "FormName");
		//Fields


        public static WinFormsField OrigSystem = new WinFormsField("ORIG-SYSTEM", "OrigSystem");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
