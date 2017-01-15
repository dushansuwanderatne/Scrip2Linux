using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class AESLAS02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("AESLAS02", "FormName");
		//Fields


        public static WinFormsField AssocAddressID = new WinFormsField("ASSOC-ADDRESS-ID", "AssocAddressID");
        public static WinFormsField AssocAddress = new WinFormsField("ASSOC-ADDRESS", "AssocAddress");
        public static WinFormsField AssocDomicile = new WinFormsField("ASSOC-DOMICILE", "AssocDomicile");
        public static WinFormsField AssocPostcode = new WinFormsField("ASSOC-POSTCODE", "AssocPostcode");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField InputID = new WinFormsField("INPUT-ID", "InputID");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
    }
}
