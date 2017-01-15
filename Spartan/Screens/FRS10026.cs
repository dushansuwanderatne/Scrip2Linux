using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS10026

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS10026", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField AuditOutput = new WinFormsField("AUDIT-OUTPUT", "AuditOutput");
        public static WinFormsField RecordOriginalSrn = new WinFormsField("RECORD-ORIGINAL-SRN", "RecordOriginalSrn");
        public static WinFormsField HolderIncrement = new WinFormsField("HOLDER-INCREMENT", "HolderIncrement");
        public static WinFormsField Format = new WinFormsField("FORMAT", "Format");
        public static WinFormsField FormatTfn = new WinFormsField("FORMAT-TFN", "FormatTfn");
        public static WinFormsField CompanyTO = new WinFormsField("COMPANY-TO", "CompanyTO");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}