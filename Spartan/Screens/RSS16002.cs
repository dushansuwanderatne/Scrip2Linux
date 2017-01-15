using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS16002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS16002", "FormName");
		//Fields


        public static WinFormsField ReportingYear = new WinFormsField("REPORTING-YEAR", "ReportingYear");
        public static WinFormsField EndPeriodCutOff = new WinFormsField("END-PERIOD-CUT-OFF", "EndPeriodCutOff");
        public static WinFormsField GazLodgementDate = new WinFormsField("GAZ-LODGEMENT-DATE", "GazLodgementDate");
        public static WinFormsField SroAsicLodgement = new WinFormsField("SRO-ASIC-LODGEMENT", "SroAsicLodgement");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
