using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BKS00403

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BKS00403", "FormName");
		//Fields


        public static WinFormsField PropertyName = new WinFormsField("PROPERTY-NAME", "PropertyName");
        public static WinFormsField ParentPropertyID = new WinFormsField("PARENT-PROPERTY-ID", "ParentPropertyID");
        public static WinFormsField ChildPropertyID = new WinFormsField("CHILD-PROPERTY-ID", "ChildPropertyID");
        public static WinFormsField DescriptionLine = new WinFormsField("DESCRIPTION-LINE", "DescriptionLine");
    }
}
