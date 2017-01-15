using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class IVR01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("IVR01001", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField IvrUserName = new WinFormsField("IVR-USER-NAME", "IvrUserName");
        public static WinFormsField IvrUserDesc = new WinFormsField("IVR-USER-DESC", "IvrUserDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
