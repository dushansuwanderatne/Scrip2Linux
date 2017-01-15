using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DMU01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DMU01001", "FormName");
		//Fields


        public static WinFormsField DmuctlKey0 = new WinFormsField("DMUCTL-KEY0", "DmuctlKey0");
        public static WinFormsField ActionDesc = new WinFormsField("ACTION-DESC", "ActionDesc");
        public static WinFormsField AcceptBuy = new WinFormsField("ACCEPT-BUY", "AcceptBuy");
        public static WinFormsField ClassFrom = new WinFormsField("CLASS-FROM", "ClassFrom");
        public static WinFormsField ClassTO = new WinFormsField("CLASS-TO", "ClassTO");
        public static WinFormsField PartialSale = new WinFormsField("PARTIAL-SALE", "PartialSale");
        public static WinFormsField AttackPriority = new WinFormsField("ATTACK-PRIORITY", "AttackPriority");
        public static WinFormsField DefensePriority = new WinFormsField("DEFENSE-PRIORITY", "DefensePriority");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ActionFirst = new WinFormsField("ACTION-FIRST", "ActionFirst");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
