using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS10047

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS10047", "FormName");
		//Fields


        public static WinFormsField ProxyMeeting = new WinFormsField("PROXY-MEETING", "ProxyMeeting");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
