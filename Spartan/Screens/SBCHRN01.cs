using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBCHRN01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBCHRN01", "FormName");
		//Fields


        public static WinFormsField F00b00 = new WinFormsField("F00B00", "F00b00");
        public static WinFormsField InputBatch = new WinFormsField("INPUT-BATCH", "InputBatch");
        public static WinFormsField InputRun = new WinFormsField("INPUT-RUN", "InputRun");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField BatchNumber = new WinFormsField("BATCH-NUMBER", "BatchNumber");
        public static WinFormsField RunDate = new WinFormsField("RUN-DATE", "RunDate");
        public static WinFormsField Comment = new WinFormsField("COMMENT", "Comment");
    }
}
