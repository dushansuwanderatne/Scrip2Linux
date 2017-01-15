using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BKS00503

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BKS00503", "FormName");
		//Fields


        public static WinFormsField MappingRuleAvail = new WinFormsField("MAPPING-RULE-AVAIL", "MappingRuleAvail");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
