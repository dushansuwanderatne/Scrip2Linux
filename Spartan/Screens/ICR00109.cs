using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR00109

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR00109", "FormName");
		//Fields


        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField SelUfd = new WinFormsField("SEL-UFD", "SelUfd");
        public static WinFormsField CoynameFilter = new WinFormsField("COYNAME-FILTER", "CoynameFilter");
    }
}
