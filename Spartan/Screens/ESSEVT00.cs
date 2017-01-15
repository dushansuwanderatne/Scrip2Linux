using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSEVT00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSEVT00", "FormName");
		//Fields


        public static WinFormsField EventType = new WinFormsField("EVENT-TYPE", "EventType");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField EventCode = new WinFormsField("EVENT-CODE", "EventCode");
        public static WinFormsField EventDate = new WinFormsField("EVENT-DATE", "EventDate");
    }
}
