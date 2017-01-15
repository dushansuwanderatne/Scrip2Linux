using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class AOS010WA

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("AOS010WA", "FormName");
		//Fields


        public static WinFormsField AssocDesc1 = new WinFormsField("ASSOC-DESC-1", "AssocDesc1");
        public static WinFormsField AssocID1 = new WinFormsField("ASSOC-ID-1", "AssocID1");
        public static WinFormsField AssocDesc2 = new WinFormsField("ASSOC-DESC-2", "AssocDesc2");
        public static WinFormsField AssocID2 = new WinFormsField("ASSOC-ID-2", "AssocID2");
        public static WinFormsField AssocDesc3 = new WinFormsField("ASSOC-DESC-3", "AssocDesc3");
        public static WinFormsField AssocID3 = new WinFormsField("ASSOC-ID-3", "AssocID3");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField Identifier = new WinFormsField("IDENTIFIER", "Identifier");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
    }
}
