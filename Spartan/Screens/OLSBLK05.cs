using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSBLK05

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSBLK05", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField BulkCode = new WinFormsField("BULK-CODE", "BulkCode");
        public static WinFormsField BulkDescription = new WinFormsField("BULK-DESCRIPTION", "BulkDescription");
        //public static WinFormsField BulkCode = new WinFormsField("BULK-CODE", "BulkCode");
        public static WinFormsField BulkNumber = new WinFormsField("BULK-NUMBER", "BulkNumber");
        public static WinFormsField ContactName = new WinFormsField("CONTACT-NAME", "ContactName");
        public static WinFormsField TelephoneBH = new WinFormsField("TELEPHONE-BH", "TelephoneBH");
        public static WinFormsField TelephoneAH = new WinFormsField("TELEPHONE-AH", "TelephoneAH");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
