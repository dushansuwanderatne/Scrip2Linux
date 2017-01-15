using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG08001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG08001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Isin = new WinFormsField("ISIN", "Isin");
        public static WinFormsField SSCompanyDetails = new WinFormsField("SS-COMPANY-DETAILS", "SSCompanyDetails");
        public static WinFormsField CompanyNameKey = new WinFormsField("COMPANY-NAME-KEY", "CompanyNameKey");
        public static WinFormsField SecurityAbbrevDesc = new WinFormsField("SECURITY-ABBREV-DESC", "SecurityAbbrevDesc");
        public static WinFormsField LseEvent = new WinFormsField("LSE-EVENT", "LseEvent");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
