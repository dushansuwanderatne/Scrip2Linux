using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSRCT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSRCT01", "FormName");
		//Fields


        public static WinFormsField CrsrctKey0 = new WinFormsField("CRSRCT-KEY0", "CrsrctKey0");
        public static WinFormsField ReconType = new WinFormsField("RECON-TYPE", "ReconType");
        public static WinFormsField ASATRun = new WinFormsField("AS-AT-RUN", "ASATRun");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RunFrom = new WinFormsField("RUN-FROM", "RunFrom");
        public static WinFormsField BusinessDate = new WinFormsField("BUSINESS-DATE", "BusinessDate");
        public static WinFormsField NextBusinessDate = new WinFormsField("NEXT-BUSINESS-DATE", "NextBusinessDate");
        public static WinFormsField Isin = new WinFormsField("ISIN", "Isin");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
