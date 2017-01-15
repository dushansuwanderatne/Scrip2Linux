using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEP05200

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEP05200", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField Comment1 = new WinFormsField("COMMENT1", "Comment1");
        public static WinFormsField Comment2 = new WinFormsField("COMMENT2", "Comment2");
        public static WinFormsField Comment3 = new WinFormsField("COMMENT3", "Comment3");
        public static WinFormsField Comment4 = new WinFormsField("COMMENT4", "Comment4");
        public static WinFormsField Comment5 = new WinFormsField("COMMENT5", "Comment5");
        public static WinFormsField Comment6 = new WinFormsField("COMMENT6", "Comment6");
        public static WinFormsField Comment7 = new WinFormsField("COMMENT7", "Comment7");
    }
}
