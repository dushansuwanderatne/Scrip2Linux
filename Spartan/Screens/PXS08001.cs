using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS08001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS08001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField RefNum = new WinFormsField("REF-NUM", "RefNum");
        public static WinFormsField LodgDate = new WinFormsField("LODG-DATE", "LodgDate");
        public static WinFormsField Holder = new WinFormsField("HOLDER", "Holder");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
