using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR02005

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR02005", "FormName");
		//Fields


        public static WinFormsField StartDate = new WinFormsField("START-DATE", "StartDate");
        public static WinFormsField AppAmount = new WinFormsField("APP-AMOUNT", "AppAmount");
        public static WinFormsField AppDirection = new WinFormsField("APP-DIRECTION", "AppDirection");
        public static WinFormsField AppReason = new WinFormsField("APP-REASON", "AppReason");
        public static WinFormsField Confirmation = new WinFormsField("CONFIRMATION", "Confirmation");
    }
}
