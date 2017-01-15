using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS00510

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS00510", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SecurityGroup = new WinFormsField("SECURITY-GROUP", "SecurityGroup");
        public static WinFormsField SecurableDesc = new WinFormsField("SECURABLE-DESC", "SecurableDesc");
    }
}
