using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BKS01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BKS01001", "FormName");
		//Fields


        public static WinFormsField PropertyID = new WinFormsField("PROPERTY-ID", "PropertyID");
        public static WinFormsField PropertyName = new WinFormsField("PROPERTY-NAME", "PropertyName");
        public static WinFormsField PropertyDescLine = new WinFormsField("PROPERTY-DESC-LINE", "PropertyDescLine");
        public static WinFormsField PropertyType = new WinFormsField("PROPERTY-TYPE", "PropertyType");
        public static WinFormsField ValueTypeInd = new WinFormsField("VALUE-TYPE-IND", "ValueTypeInd");
        public static WinFormsField PropertyDescInd = new WinFormsField("PROPERTY-DESC-IND", "PropertyDescInd");
        public static WinFormsField PropertyParentID = new WinFormsField("PROPERTY-PARENT-ID", "PropertyParentID");
        public static WinFormsField ValueSize = new WinFormsField("VALUE-SIZE", "ValueSize");
        public static WinFormsField PropertyProtected = new WinFormsField("PROPERTY-PROTECTED", "PropertyProtected");
        public static WinFormsField ValueDecimals = new WinFormsField("VALUE-DECIMALS", "ValueDecimals");
        public static WinFormsField UsageInd = new WinFormsField("USAGE-IND", "UsageInd");
        public static WinFormsField NumberOFOccurences = new WinFormsField("NUMBER-OF-OCCURENCES", "NumberOFOccurences");
        public static WinFormsField SpecialValidationInd = new WinFormsField("SPECIAL-VALIDATION-IND", "SpecialValidationInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ActionFirst = new WinFormsField("ACTION-FIRST", "ActionFirst");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SearchPropertyID = new WinFormsField("SEARCH-PROPERTY-ID", "SearchPropertyID");
        public static WinFormsField SystemInfoDate5 = new WinFormsField("SYSTEM-INFO-DATE-5", "9", "9");
    }
}
