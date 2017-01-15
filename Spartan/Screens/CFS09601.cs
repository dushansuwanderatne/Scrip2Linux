using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS09601

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS09601", "FormName");
		//Fields


        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField WorldlinkNumber = new WinFormsField("WORLDLINK-NUMBER", "WorldlinkNumber");
        public static WinFormsField PrincipalNbrFlag = new WinFormsField("PRINCIPAL-NBR-FLAG", "PrincipalNbrFlag");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SearchCompany = new WinFormsField("SEARCH-COMPANY", "SearchCompany");
        public static WinFormsField SearchWorldlink = new WinFormsField("SEARCH-WORLDLINK", "SearchWorldlink");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
    }
}
