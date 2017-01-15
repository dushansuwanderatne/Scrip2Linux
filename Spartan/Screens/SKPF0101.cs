using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SKPF0101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SKPF0101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TFIntOrd = new WinFormsField("TF-INT-ORD", "TFIntOrd");
        public static WinFormsField TFFNOrd = new WinFormsField("TF-FN-ORD", "TFFNOrd");
        public static WinFormsField TFIntSP = new WinFormsField("TF-INT-SP", "TFIntSP");
        public static WinFormsField TFFNSP = new WinFormsField("TF-FN-SP", "TFFNSP");
        public static WinFormsField TDIntOrd = new WinFormsField("TD-INT-ORD", "TDIntOrd");
        public static WinFormsField TDFNOrd = new WinFormsField("TD-FN-ORD", "TDFNOrd");
        public static WinFormsField TDIntSP = new WinFormsField("TD-INT-SP", "TDIntSP");
        public static WinFormsField TDFNSP = new WinFormsField("TD-FN-SP", "TDFNSP");
        public static WinFormsField DivdetIntMM = new WinFormsField("DIVDET-INT-MM", "DivdetIntMM");
        public static WinFormsField DivdetIntYY = new WinFormsField("DIVDET-INT-YY", "DivdetIntYY");
        public static WinFormsField DivdetFNMM = new WinFormsField("DIVDET-FN-MM", "DivdetFNMM");
        public static WinFormsField DivdetFNYY = new WinFormsField("DIVDET-FN-YY", "DivdetFNYY");
        public static WinFormsField ReportHead = new WinFormsField("REPORT-HEAD", "ReportHead");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
