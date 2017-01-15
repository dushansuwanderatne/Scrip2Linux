using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS10018

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS10018", "FormName");
		//Fields


        public static WinFormsField MenuItemS = new WinFormsField("MENU-ITEM-S", "S. Special Date Lost", "SpecialDateLost");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReturnMail = new WinFormsField("RETURN-MAIL", "ReturnMail");
        public static WinFormsField SpecDateFrom = new WinFormsField("SPEC-DATE-FROM", "SpecDateFrom");
        public static WinFormsField SpecDateTO = new WinFormsField("SPEC-DATE-TO", "SpecDateTO");
        public static WinFormsField RunLscFrom = new WinFormsField("RUN-LSC-FROM", "RunLscFrom");
        public static WinFormsField RunLscTO = new WinFormsField("RUN-LSC-TO", "RunLscTO");
        public static WinFormsField DfhFrom = new WinFormsField("DFH-FROM", "DfhFrom");
        public static WinFormsField DfhTO = new WinFormsField("DFH-TO", "DfhTO");
        public static WinFormsField OffDateFrom = new WinFormsField("OFF-DATE-FROM", "OffDateFrom");
        public static WinFormsField OffDateTO = new WinFormsField("OFF-DATE-TO", "OffDateTO");
        public static WinFormsField AddDateFrom = new WinFormsField("ADD-DATE-FROM", "AddDateFrom");
        public static WinFormsField AddDateTO = new WinFormsField("ADD-DATE-TO", "AddDateTO");
        public static WinFormsField StaticTransType = new WinFormsField("STATIC-TRANS-TYPE", "StaticTransType");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
