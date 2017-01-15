using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS01030

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS01030", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField InvestorNumber = new WinFormsField("INVESTOR-NUMBER", "InvestorNumber");
        public static WinFormsField InvestorName1 = new WinFormsField("INVESTOR-NAME1", "InvestorName1");
        public static WinFormsField InvestorName2 = new WinFormsField("INVESTOR-NAME2", "InvestorName2");
        public static WinFormsField InvestorPostcode = new WinFormsField("INVESTOR-POSTCODE", "InvestorPostcode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
    }
}
