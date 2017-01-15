using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    class COYWRN01
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("COYWRN01", "FormName");
        //Menu Fields

        //Sys Info Fields

        //Alpha Numeric Fields
        public static WinFormsField CompanyWarningDesc = new WinFormsField("COMPANY-WARNING-DESC", "CompanyWarningDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField EmailAddress = new WinFormsField("EMAIL-ADDRESS", "EmailAddress");
        public static WinFormsField AdditionalWarnDesc = new WinFormsField("ADDITIONAL-WARN-DESC", "AdditionalWarnDesc");

        //Numeric Fields

    }
}
