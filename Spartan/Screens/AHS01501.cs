using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class AHS01501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("AHS01501", "FormName");
		//Fields


        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField LastIdentifier = new WinFormsField("LAST-IDENTIFIER", "LastIdentifier");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
    }
}
