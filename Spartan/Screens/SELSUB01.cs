using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELSUB01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELSUB01", "FormName");
		//Fields


        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField CompanyDesc = new WinFormsField("COMPANY-DESC", "CompanyDesc");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
