using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS01800

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS01800", "FormName");
		//Fields


        public static WinFormsField System = new WinFormsField("SYSTEM", "System");
        public static WinFormsField SubSystem = new WinFormsField("SUB-SYSTEM", "SubSystem");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchSystem = new WinFormsField("SEARCH-SYSTEM", "SearchSystem");
        public static WinFormsField SearchSubSystem = new WinFormsField("SEARCH-SUB-SYSTEM", "SearchSubSystem");
    }
}
