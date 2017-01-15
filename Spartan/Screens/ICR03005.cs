using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR03005

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR03005", "FormName");
		//Fields


        public static WinFormsField StartDate = new WinFormsField("START-DATE", "StartDate");
        public static WinFormsField EndDate = new WinFormsField("END-DATE", "EndDate");
        public static WinFormsField TolAmount = new WinFormsField("TOL-AMOUNT", "TolAmount");
        public static WinFormsField TolDirection = new WinFormsField("TOL-DIRECTION", "TolDirection");
        public static WinFormsField TolReason = new WinFormsField("TOL-REASON", "TolReason");
        public static WinFormsField Confirmation = new WinFormsField("CONFIRMATION", "Confirmation");
    }
}
