using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DSSAIC01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DSSAIC01", "FormName");
		//Fields


        public static WinFormsField ReportPrefix = new WinFormsField("REPORT-PREFIX", "ReportPrefix");
        public static WinFormsField RpdFilename = new WinFormsField("RPD-FILENAME", "RpdFilename");
        public static WinFormsField RpdDescription = new WinFormsField("RPD-DESCRIPTION", "RpdDescription");
        public static WinFormsField RegDetails = new WinFormsField("REG-DETAILS", "RegDetails");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField OrderLocationInd = new WinFormsField("ORDER-LOCATION-IND", "OrderLocationInd");
        public static WinFormsField DisplaySourceInd = new WinFormsField("DISPLAY-SOURCE-IND", "DisplaySourceInd");
    }
}
