using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS00701

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS00701", "FormName");
		//Fields


        public static WinFormsField HoltypCode = new WinFormsField("HOLTYP-CODE", "HoltypCode");
        public static WinFormsField HoltypDesc = new WinFormsField("HOLTYP-DESC", "HoltypDesc");
        public static WinFormsField HoltypCoyInd = new WinFormsField("HOLTYP-COY-IND", "HoltypCoyInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
