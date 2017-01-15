using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS01610

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS01610", "FormName");
		//Fields


        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField CompanyDir = new WinFormsField("COMPANY-DIR", "CompanyDir");
        public static WinFormsField CompanyClass = new WinFormsField("COMPANY-CLASS", "CompanyClass");
        public static WinFormsField IsinNumber = new WinFormsField("ISIN-NUMBER", "IsinNumber");
        public static WinFormsField Origin1to13 = new WinFormsField("ORIGIN-1TO13", "Origin1to13");
        public static WinFormsField Comment1to13 = new WinFormsField("COMMENT-1TO13", "Comment1to13");
        public static WinFormsField Origin14to26 = new WinFormsField("ORIGIN-14TO26", "Origin14to26");
        public static WinFormsField Comment14to26 = new WinFormsField("COMMENT-14TO26", "Comment14to26");
    }
}
