using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ROLRUL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ROLRUL01", "FormName");
		//Fields


        public static WinFormsField RollupType = new WinFormsField("ROLLUP-TYPE", "RollupType");
        public static WinFormsField SegmentNumber = new WinFormsField("SEGMENT-NUMBER", "SegmentNumber");
        public static WinFormsField GroupNumber = new WinFormsField("GROUP-NUMBER", "GroupNumber");
        public static WinFormsField RuleType = new WinFormsField("RULE-TYPE", "RuleType");
        public static WinFormsField RuleValue = new WinFormsField("RULE-VALUE", "RuleValue");
        public static WinFormsField RuleInd = new WinFormsField("RULE-IND", "RuleInd");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField RolrulKey0 = new WinFormsField("ROLRUL-KEY0", "RolrulKey0");
    }
}
