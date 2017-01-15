using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SMVP0101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SMVP0101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHead = new WinFormsField("REPORT-HEAD", "ReportHead");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField RepASATRun = new WinFormsField("REP-AS-AT-RUN", "RepASATRun");
        public static WinFormsField Acc1 = new WinFormsField("ACC1", "Acc1");
        public static WinFormsField Rate1 = new WinFormsField("RATE1", "Rate1");
        public static WinFormsField Defer1 = new WinFormsField("DEFER1", "Defer1");
        public static WinFormsField TaxFree1 = new WinFormsField("TAX-FREE1", "TaxFree1");
        public static WinFormsField Redemption1 = new WinFormsField("REDEMPTION1", "Redemption1");
        public static WinFormsField Taxable1 = new WinFormsField("TAXABLE1", "Taxable1");
        public static WinFormsField CapGain1 = new WinFormsField("CAP-GAIN1", "CapGain1");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField OptionalComment = new WinFormsField("OPTIONAL-COMMENT", "OptionalComment");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
