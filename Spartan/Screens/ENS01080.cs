using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01080

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01080", "FormName");
		//Fields
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField Format = new WinFormsField("FORMAT", "Format");
        public static WinFormsField RunFrom = new WinFormsField("RUN-FROM", "RunFrom");
        public static WinFormsField RunTO = new WinFormsField("RUN-TO", "RunTO");
        public static WinFormsField RepASATRun = new WinFormsField("REP-AS-AT-RUN", "RepASATRun");
        public static WinFormsField DateSequence = new WinFormsField("DATE-SEQUENCE", "DateSequence");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
    }
}
