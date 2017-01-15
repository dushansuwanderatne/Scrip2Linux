using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class AOS01011

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("AOS01011", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField AssociatedID = new WinFormsField("ASSOCIATED-ID", "AssociatedID");
        public static WinFormsField AssociatedDetail = new WinFormsField("ASSOCIATED-DETAIL", "AssociatedDetail");
        public static WinFormsField AssociatedWith = new WinFormsField("ASSOCIATED-WITH", "AssociatedWith");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
    }
}
