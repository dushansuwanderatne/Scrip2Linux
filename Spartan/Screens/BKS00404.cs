using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BKS00404

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BKS00404", "FormName");
		//Fields


        public static WinFormsField Select = new WinFormsField("SELECT", "Select");
        public static WinFormsField PropertyName = new WinFormsField("PROPERTY-NAME", "PropertyName");
        public static WinFormsField PropertyID = new WinFormsField("PROPERTY-ID", "PropertyID");
        public static WinFormsField PropertyDesc = new WinFormsField("PROPERTY-DESC", "PropertyDesc");
        public static WinFormsField PropertySpecial = new WinFormsField("PROPERTY-SPECIAL", "PropertySpecial");
        public static WinFormsField ActionFields = new WinFormsField("ACTION-FIELDS", "ActionFields");
    }
}
