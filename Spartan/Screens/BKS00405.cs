using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BKS00405

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BKS00405", "FormName");
		//Fields


        public static WinFormsField PropertyName = new WinFormsField("PROPERTY-NAME", "PropertyName");
        public static WinFormsField PropertyID = new WinFormsField("PROPERTY-ID", "PropertyID");
        public static WinFormsField DescLine = new WinFormsField("DESC-LINE", "DescLine");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
