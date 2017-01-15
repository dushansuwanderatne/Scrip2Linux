using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS11006
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS11006", "FormName");
        //Fields
        public static WinFormsField ExtractHoldersPI = new WinFormsField("EXTRACT-HOLDERS-PI", "ExtractHoldersPI");
        public static WinFormsField RptDirectCreditInd = new WinFormsField("RPT-DIRECT-CREDIT-IND", "RptDirectCreditInd");
        public static WinFormsField RptDirectCredit = new WinFormsField("RPT-DIRECT-CREDIT", "RptDirectCredit");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
    }
}