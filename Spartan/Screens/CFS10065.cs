using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS10065

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS10065", "FormName");
		//Fields


        public static WinFormsField Header = new WinFormsField("HEADER", "Header");
        public static WinFormsField NBSubmitted = new WinFormsField("NB-SUBMITTED", "NBSubmitted");
        public static WinFormsField NBRejected = new WinFormsField("NB-REJECTED", "NBRejected");
        public static WinFormsField Coy = new WinFormsField("COY", "Coy");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Rsp = new WinFormsField("RSP", "Rsp");
        public static WinFormsField Queue = new WinFormsField("QUEUE", "Queue");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
    }
}
