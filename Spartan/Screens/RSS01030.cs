using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS01030
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS01030", "FormName");
        //Fields
        public static WinFormsField FormatDesc = new WinFormsField("FORMAT-DESC", "FormatDesc");
        public static WinFormsField Cls = new WinFormsField("CLS", "Cls");
        public static WinFormsField Clg = new WinFormsField("CLG", "Clg");
        public static WinFormsField GroupIDX = new WinFormsField("GROUP-ID-X", "GroupIDX");
        public static WinFormsField Reg = new WinFormsField("REG", "Reg");
        public static WinFormsField Plan = new WinFormsField("PLAN", "Plan");
        public static WinFormsField ReportingPeriod = new WinFormsField("REPORTING-PERIOD", "ReportingPeriod");
        public static WinFormsField RunFrom = new WinFormsField("RUN-FROM", "RunFrom");
        public static WinFormsField RunTO = new WinFormsField("RUN-TO", "RunTO");
        public static WinFormsField MandatoryDCInd = new WinFormsField("MANDATORY-DC-IND", "MandatoryDCInd");
        public static WinFormsField MandDCDom = new WinFormsField("MAND-DC-DOM", "MandDCDom");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
