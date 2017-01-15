using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR05010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR05010", "FormName");
		//Fields


        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField GroupNumber = new WinFormsField("GROUP-NUMBER", "GroupNumber");
        public static WinFormsField ReconFromDate = new WinFormsField("RECON-FROM-DATE", "ReconFromDate");
        public static WinFormsField ReconTODate = new WinFormsField("RECON-TO-DATE", "ReconTODate");
        public static WinFormsField CurrentInd = new WinFormsField("CURRENT-IND", "CurrentInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
