using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00600

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00600", "FormName");
		//Fields


        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField IncludeAll = new WinFormsField("INCLUDE-ALL", "IncludeAll");
        public static WinFormsField Res1to20Dsc = new WinFormsField("RES-1TO20-DSC", "Res1to20Dsc");
        public static WinFormsField Res21to40Dsc = new WinFormsField("RES-21TO40-DSC", "Res21to40Dsc");
        public static WinFormsField Res41to60Dsc = new WinFormsField("RES-41TO60-DSC", "Res41to60Dsc");
        public static WinFormsField Res61to80Dsc = new WinFormsField("RES-61TO80-DSC", "Res61to80Dsc");
        public static WinFormsField Res81to99Dsc = new WinFormsField("RES-81TO99-DSC", "Res81to99Dsc");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
