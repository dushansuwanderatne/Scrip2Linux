using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS13100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS13100", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField CompanySelInd = new WinFormsField("COMPANY-SEL-IND", "CompanySelInd");
        public static WinFormsField Company1TO10 = new WinFormsField("COMPANY-1-TO-10", "Company1TO10");
        public static WinFormsField Company11TO20 = new WinFormsField("COMPANY-11-TO-20", "Company11TO20");
        public static WinFormsField PrintSamplesInd = new WinFormsField("PRINT-SAMPLES-IND", "PrintSamplesInd");
    }
}
