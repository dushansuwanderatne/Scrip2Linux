using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS01901

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS01901", "FormName");
		//Fields


        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField CompanyUfd = new WinFormsField("COMPANY-UFD", "CompanyUfd");
        public static WinFormsField FileName = new WinFormsField("FILE-NAME", "FileName");
        public static WinFormsField PrintingHouse = new WinFormsField("PRINTING-HOUSE", "PrintingHouse");
        public static WinFormsField EomReport = new WinFormsField("EOM-REPORT", "EomReport");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SearchClientCode = new WinFormsField("SEARCH-CLIENT-CODE", "SearchClientCode");
        public static WinFormsField SearchCompanyUfd = new WinFormsField("SEARCH-COMPANY-UFD", "SearchCompanyUfd");
        public static WinFormsField SearchFileName = new WinFormsField("SEARCH-FILE-NAME", "SearchFileName");
    }
}
