using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class AOS01009

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("AOS01009", "FormName");
		//Fields


        public static WinFormsField AssociatedNameID = new WinFormsField("ASSOCIATED-NAME-ID", "AssociatedNameID");
        public static WinFormsField AssociatedName = new WinFormsField("ASSOCIATED-NAME", "AssociatedName");
        public static WinFormsField ChangeID = new WinFormsField("CHANGE-ID", "ChangeID");
        public static WinFormsField LocalNumber = new WinFormsField("LOCAL-NUMBER", "LocalNumber");
        public static WinFormsField InterDialCode = new WinFormsField("INTER-DIAL-CODE", "InterDialCode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
