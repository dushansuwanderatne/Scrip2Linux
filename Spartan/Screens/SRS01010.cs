using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SRS01010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SRS01010", "FormName");
		//Fields


        public static WinFormsField DumpDate = new WinFormsField("DUMP-DATE", "DumpDate");
        public static WinFormsField DumpFrom = new WinFormsField("DUMP-FROM", "DumpFrom");
        public static WinFormsField DumpTO = new WinFormsField("DUMP-TO", "DumpTO");
        public static WinFormsField NumDays = new WinFormsField("NUM-DAYS", "NumDays");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
