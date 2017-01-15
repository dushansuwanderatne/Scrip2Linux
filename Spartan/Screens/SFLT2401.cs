using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SFLT2401

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SFLT2401", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField App1Cls = new WinFormsField("APP1-CLS", "App1Cls");
        public static WinFormsField App2Cls = new WinFormsField("APP2-CLS", "App2Cls");
        public static WinFormsField Alt1Cls = new WinFormsField("ALT1-CLS", "Alt1Cls");
        public static WinFormsField Alt2Cls = new WinFormsField("ALT2-CLS", "Alt2Cls");
        public static WinFormsField RunFrom = new WinFormsField("RUN-FROM", "RunFrom");
        public static WinFormsField RunTO = new WinFormsField("RUN-TO", "RunTO");
        public static WinFormsField PrintUnknown = new WinFormsField("PRINT-UNKNOWN", "PrintUnknown");
        public static WinFormsField PrintHin = new WinFormsField("PRINT-HIN", "PrintHin");
        public static WinFormsField RepHeading = new WinFormsField("REP-HEADING", "RepHeading");
        public static WinFormsField RepDate = new WinFormsField("REP-DATE", "RepDate");
        public static WinFormsField CommissionTOPrint = new WinFormsField("COMMISSION-TO-PRINT", "CommissionTOPrint");
        public static WinFormsField CommissionFrom = new WinFormsField("COMMISSION-FROM", "CommissionFrom");
        public static WinFormsField CommissionTO = new WinFormsField("COMMISSION-TO", "CommissionTO");
        public static WinFormsField CommPerc = new WinFormsField("COMM-PERC", "CommPerc");
        public static WinFormsField FlatFee = new WinFormsField("FLAT-FEE", "FlatFee");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
