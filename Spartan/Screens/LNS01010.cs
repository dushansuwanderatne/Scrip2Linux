using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS01010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS01010", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField LinkType = new WinFormsField("LINK-TYPE", "LinkType");
        public static WinFormsField InvestorNumber = new WinFormsField("INVESTOR-NUMBER", "InvestorNumber");
        public static WinFormsField InvestorName1 = new WinFormsField("INVESTOR-NAME1", "InvestorName1");
        public static WinFormsField InvestorName2 = new WinFormsField("INVESTOR-NAME2", "InvestorName2");
        public static WinFormsField CompanyUfd = new WinFormsField("COMPANY-UFD", "CompanyUfd");
        public static WinFormsField CompanyDescription = new WinFormsField("COMPANY-DESCRIPTION", "CompanyDescription");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HistRef = new WinFormsField("HIST-REF", "HistRef");
        public static WinFormsField HistDate = new WinFormsField("HIST-DATE", "HistDate");
        public static WinFormsField CurrentFlag = new WinFormsField("CURRENT-FLAG", "CurrentFlag");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
