using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class COMPNY01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("COMPNY01", "FormName");
		//Fields


        public static WinFormsField CompanyUfdsel = new WinFormsField("COMPANY-UFDSEL", "CompanyUfdsel");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField ProcessingGroup = new WinFormsField("PROCESSING-GROUP", "ProcessingGroup");
        public static WinFormsField CompanyType = new WinFormsField("COMPANY-TYPE", "CompanyType");
        public static WinFormsField Value = new WinFormsField("VALUE", "Value");
        public static WinFormsField Volume = new WinFormsField("VOLUME", "Volume");
        public static WinFormsField Holders = new WinFormsField("HOLDERS", "Holders");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
