using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISS01055

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISS01055", "FormName");
		//Fields


        public static WinFormsField ListingSeq = new WinFormsField("LISTING-SEQ", "ListingSeq");
        public static WinFormsField ListProgName = new WinFormsField("LIST-PROG-NAME", "ListProgName");
        public static WinFormsField PrintHolderID = new WinFormsField("PRINT-HOLDER-ID", "PrintHolderID");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
