using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01011

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01011", "FormName");
		//Fields


        public static WinFormsField EnteredExpiryDate = new WinFormsField("ENTERED-EXPIRY-DATE", "EnteredExpiryDate");
        public static WinFormsField GrantStartDate = new WinFormsField("GRANT-START-DATE", "GrantStartDate");
        public static WinFormsField ExpiresAfterMonths = new WinFormsField("EXPIRES-AFTER-MONTHS", "ExpiresAfterMonths");
        public static WinFormsField ExpiresAfterDays = new WinFormsField("EXPIRES-AFTER-DAYS", "ExpiresAfterDays");
        public static WinFormsField CalcExpiryDate = new WinFormsField("CALC-EXPIRY-DATE", "CalcExpiryDate");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
