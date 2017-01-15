using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PTS00301

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PTS00301", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 8", "8");
        public static WinFormsField Number = new WinFormsField("NUMBER", "Number");
        public static WinFormsField AllocatedTO = new WinFormsField("ALLOCATED-TO", "AllocatedTO");
        public static WinFormsField AllocatedBY = new WinFormsField("ALLOCATED-BY", "AllocatedBY");
        public static WinFormsField Allocated = new WinFormsField("ALLOCATED", "Allocated");
        public static WinFormsField Completed = new WinFormsField("COMPLETED", "Completed");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField Priority = new WinFormsField("PRIORITY", "Priority");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        //public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Add = new WinFormsField("ADD", "Add");
    }
}
