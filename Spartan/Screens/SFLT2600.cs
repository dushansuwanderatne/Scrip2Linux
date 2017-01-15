using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SFLT2600

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SFLT2600", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField AllotmentClass1 = new WinFormsField("ALLOTMENT-CLASS-1", "AllotmentClass1");
        public static WinFormsField AllotmentClass2 = new WinFormsField("ALLOTMENT-CLASS-2", "AllotmentClass2");
        public static WinFormsField IssuerConvReqdInd = new WinFormsField("ISSUER-CONV-REQD-IND", "IssuerConvReqdInd");
        public static WinFormsField HolderNumberFrom = new WinFormsField("HOLDER-NUMBER-FROM", "HolderNumberFrom");
        public static WinFormsField HolderNumberTO = new WinFormsField("HOLDER-NUMBER-TO", "HolderNumberTO");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
