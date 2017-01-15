using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS05301

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS05301", "FormName");
		//Fields


        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField ContactID = new WinFormsField("CONTACT-ID", "ContactID");
        public static WinFormsField ContactType = new WinFormsField("CONTACT-TYPE", "ContactType");
        public static WinFormsField ContactAddrL1 = new WinFormsField("CONTACT-ADDR-L1", "ContactAddrL1");
        public static WinFormsField ContactAddrL2 = new WinFormsField("CONTACT-ADDR-L2", "ContactAddrL2");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LitAdd = new WinFormsField("LIT-ADD", "LitAdd");
        public static WinFormsField LitForward = new WinFormsField("LIT-FORWARD", "LitForward");
        public static WinFormsField LitBack = new WinFormsField("LIT-BACK", "LitBack");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
