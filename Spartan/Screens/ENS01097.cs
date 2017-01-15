using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01097

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01097", "FormName");
		//Fields


        public static WinFormsField ISStartDate = new WinFormsField("IS-START-DATE", "ISStartDate");
        public static WinFormsField ISEndDate = new WinFormsField("IS-END-DATE", "ISEndDate");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
