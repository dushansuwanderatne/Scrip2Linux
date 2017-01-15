using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS05001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS05001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField StatementStartDate = new WinFormsField("STATEMENT-START-DATE", "StatementStartDate");
        public static WinFormsField StatementEndDate = new WinFormsField("STATEMENT-END-DATE", "StatementEndDate");
    }
}
