using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PTS00302

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PTS00302", "FormName");
		//Fields


        public static WinFormsField AllocatedTO = new WinFormsField("ALLOCATED-TO", "AllocatedTO");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField Priority = new WinFormsField("PRIORITY", "Priority");
        public static WinFormsField Number = new WinFormsField("NUMBER", "Number");
    }
}
