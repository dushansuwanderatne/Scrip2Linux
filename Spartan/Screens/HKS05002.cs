using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS05002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS05002", "FormName");
		//Fields


        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField EffectiveFromDate = new WinFormsField("EFFECTIVE-FROM-DATE", "EffectiveFromDate");
        public static WinFormsField MerPercentage = new WinFormsField("MER-PERCENTAGE", "MerPercentage");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1 = new WinFormsField("ACTION-1", "Action1");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField Action2 = new WinFormsField("ACTION-2", "Action2");
        public static WinFormsField LitChange = new WinFormsField("LIT-CHANGE", "LitChange");
        public static WinFormsField LitDelete = new WinFormsField("LIT-DELETE", "LitDelete");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
