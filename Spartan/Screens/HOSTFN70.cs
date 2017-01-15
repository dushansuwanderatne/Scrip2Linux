using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFN70

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFN70", "FormName");
		//Fields


        public static WinFormsField FromFN = new WinFormsField("FROM-FN", "FromFN");
        public static WinFormsField TOFN = new WinFormsField("TO-FN", "TOFN");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
