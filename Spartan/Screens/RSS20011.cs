using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS20011

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS20011", "FormName");
		//Fields


        public static WinFormsField ReportReason = new WinFormsField("REPORT-REASON", "ReportReason");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField CorpAction = new WinFormsField("CORP-ACTION", "CorpAction");
        public static WinFormsField EXDate = new WinFormsField("EX-DATE", "EXDate");
        public static WinFormsField StartDate = new WinFormsField("START-DATE", "StartDate");
        public static WinFormsField EndDate = new WinFormsField("END-DATE", "EndDate");
        public static WinFormsField ASATDate = new WinFormsField("AS-AT-DATE", "ASATDate");
        public static WinFormsField TransClass = new WinFormsField("TRANS-CLASS", "TransClass");
        public static WinFormsField HinParameter = new WinFormsField("HIN-PARAMETER", "HinParameter");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
