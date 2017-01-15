using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ADM00305

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ADM00305", "FormName");
		//Fields


        public static WinFormsField AclGroupName = new WinFormsField("ACL-GROUP-NAME", "AclGroupName");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
