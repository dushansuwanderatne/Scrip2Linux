using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01100", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField MailUnclaimedDate = new WinFormsField("MAIL-UNCLAIMED-DATE", "MailUnclaimedDate");
        public static WinFormsField Format5 = new WinFormsField("FORMAT-5", "Format5");
        public static WinFormsField Format7 = new WinFormsField("FORMAT-7", "Format7");
        public static WinFormsField Format10 = new WinFormsField("FORMAT-10", "Format10");
        public static WinFormsField Format11 = new WinFormsField("FORMAT-11", "Format11");
        public static WinFormsField Format12 = new WinFormsField("FORMAT-12", "Format12");
        public static WinFormsField Format14 = new WinFormsField("FORMAT-14", "Format14");
        public static WinFormsField Format15 = new WinFormsField("FORMAT-15", "Format15");
        public static WinFormsField Format16 = new WinFormsField("FORMAT-16", "Format16");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
