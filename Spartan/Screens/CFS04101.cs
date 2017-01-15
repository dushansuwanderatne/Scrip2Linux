using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS04101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS04101", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField WorkflowTranType = new WinFormsField("WORKFLOW-TRAN-TYPE", "WorkflowTranType");
        public static WinFormsField CurrentInd = new WinFormsField("CURRENT-IND", "CurrentInd");
    }
}
