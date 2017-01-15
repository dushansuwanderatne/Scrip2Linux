using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BKS00802

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BKS00802", "FormName");
		//Fields


        public static WinFormsField Select = new WinFormsField("SELECT", "Select");
        public static WinFormsField PropertyName = new WinFormsField("PROPERTY-NAME", "PropertyName");
        public static WinFormsField PropertyID = new WinFormsField("PROPERTY-ID", "PropertyID");
        public static WinFormsField PropertyValue = new WinFormsField("PROPERTY-VALUE", "PropertyValue");
        public static WinFormsField PropertyType = new WinFormsField("PROPERTY-TYPE", "PropertyType");
        public static WinFormsField ActionFields = new WinFormsField("ACTION-FIELDS", "ActionFields");
        public static WinFormsField ScreenTitle = new WinFormsField("SCREEN-TITLE", "ScreenTitle");
        public static WinFormsField FieldTitle = new WinFormsField("FIELD-TITLE", "FieldTitle");
        public static WinFormsField SelectionTitle = new WinFormsField("SELECTION-TITLE", "SelectionTitle");
    }
}
