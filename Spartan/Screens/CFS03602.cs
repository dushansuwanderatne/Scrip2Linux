using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS03602

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS03602", "FormName");
		//Fields


        public static WinFormsField LegalEntityCode = new WinFormsField("LEGAL-ENTITY-CODE", "LegalEntityCode");
        public static WinFormsField LegalEntityName = new WinFormsField("LEGAL-ENTITY-NAME", "LegalEntityName");
        public static WinFormsField ActiveFromDate = new WinFormsField("ACTIVE-FROM-DATE", "ActiveFromDate");
        public static WinFormsField ActiveTODate = new WinFormsField("ACTIVE-TO-DATE", "ActiveTODate");
        public static WinFormsField IntermediaryOnlInd = new WinFormsField("INTERMEDIARY-ONL-IND", "IntermediaryOnlInd");
        public static WinFormsField EmailAddress = new WinFormsField("EMAIL ADDRESS", "EmailAddress");
        public static WinFormsField BusinessCountry = new WinFormsField("BUSINESS-COUNTRY", "BusinessCountry");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ActionFirst = new WinFormsField("ACTION-FIRST", "ActionFirst");
        public static WinFormsField ActionEnquire = new WinFormsField("ACTION-ENQUIRE", "ActionEnquire");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
    }
}
