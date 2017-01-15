using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01052

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01052", "FormName");
		//Fields
        public static WinFormsField HolderONDate = new WinFormsField("HOLDER-ON-DATE", "HolderONDate");
        public static WinFormsField HolderAddedDate = new WinFormsField("HOLDER-ADDED-DATE", "HolderAddedDate");
        public static WinFormsField HolderOffDate = new WinFormsField("HOLDER-OFF-DATE", "HolderOffDate");
        public static WinFormsField HolderVersionNbr = new WinFormsField("HOLDER-VERSION-NBR", "HolderVersionNbr");
        public static WinFormsField FltBatchNumber = new WinFormsField("FLT-BATCH-NUMBER", "FltBatchNumber");
        public static WinFormsField RunLastChange = new WinFormsField("RUN-LAST-CHANGE", "RunLastChange");
        public static WinFormsField HolderCrtDumprun = new WinFormsField("HOLDER-CRT-DUMPRUN", "HolderCrtDumprun");
        public static WinFormsField HolderPayDumprun = new WinFormsField("HOLDER-PAY-DUMPRUN", "HolderPayDumprun");
        public static WinFormsField HolderTO = new WinFormsField("HOLDER-TO", "HolderTO");
        public static WinFormsField HolderFrom = new WinFormsField("HOLDER-FROM", "HolderFrom");
    }
}
