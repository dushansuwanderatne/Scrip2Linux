using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS09001
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS09001", "FormName");
        //Fields
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField RepHeading = new WinFormsField("REP-HEADING", "RepHeading");
        public static WinFormsField Cls = new WinFormsField("CLS", "Cls");
        public static WinFormsField ClgCon = new WinFormsField("CLG-CON", "ClgCon");
        public static WinFormsField Level = new WinFormsField("LEVEL", "Level");
        public static WinFormsField Sequence = new WinFormsField("SEQUENCE", "Sequence");
        public static WinFormsField TraderCutOff = new WinFormsField("TRADER-CUT-OFF", "TraderCutOff");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField RunFrom = new WinFormsField("RUN-FROM", "RunFrom");
        public static WinFormsField RunTO = new WinFormsField("RUN-TO", "RunTO");
        public static WinFormsField TransGroupFrom = new WinFormsField("TRANS-GROUP-FROM", "TransGroupFrom");
        public static WinFormsField TransGroupTO = new WinFormsField("TRANS-GROUP-TO", "TransGroupTO");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
