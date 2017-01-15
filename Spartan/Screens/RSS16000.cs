using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS16000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS16000", "FormName");
		//Fields


        public static WinFormsField ReportingPhase = new WinFormsField("REPORTING PHASE", "ReportingPhase");
        public static WinFormsField ReportingYear = new WinFormsField("REPORTING YEAR", "ReportingYear");
        public static WinFormsField DepartmentCode = new WinFormsField("DEPARTMENT CODE", "DepartmentCode");
        public static WinFormsField AdvertisingCost = new WinFormsField("ADVERTISING COST", "AdvertisingCost");
        public static WinFormsField IncorporatedComment = new WinFormsField("INCORPORATED COMMENT", "IncorporatedComment");
        public static WinFormsField FileRecipient = new WinFormsField("FILE RECIPIENT", "FileRecipient");
        public static WinFormsField AggregatePayments = new WinFormsField("AGGREGATE PAYMENTS", "AggregatePayments");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
