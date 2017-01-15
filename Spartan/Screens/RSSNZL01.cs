using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSSNZL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSSNZL01", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField AllCompany = new WinFormsField("ALL-COMPANY", "AllCompany");
        public static WinFormsField Broker = new WinFormsField("BROKER", "Broker");
        public static WinFormsField Reject = new WinFormsField("REJECT", "Reject");
        public static WinFormsField Accept = new WinFormsField("ACCEPT", "Accept");
        public static WinFormsField Compl = new WinFormsField("COMPL", "Compl");
        public static WinFormsField Pend = new WinFormsField("PEND", "Pend");
        public static WinFormsField Held = new WinFormsField("HELD", "Held");
        public static WinFormsField Docreq = new WinFormsField("DOCREQ", "Docreq");
        public static WinFormsField TransTypes = new WinFormsField("TRANS-TYPES", "TransTypes");
        public static WinFormsField VdateFrom = new WinFormsField("VDATE-FROM", "VdateFrom");
        public static WinFormsField VdateTO = new WinFormsField("VDATE-TO", "VdateTO");
        public static WinFormsField PdateFrom = new WinFormsField("PDATE-FROM", "PdateFrom");
        public static WinFormsField PdateTO = new WinFormsField("PDATE-TO", "PdateTO");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
