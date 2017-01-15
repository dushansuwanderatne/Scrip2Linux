using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSDIV20

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSDIV20", "FormName");
		//Fields
        public static WinFormsField USObligation = new WinFormsField("US-OBLIGATION", "USObligation");
        public static WinFormsField TaxResidency = new WinFormsField("TAX-RESIDENCY", "TaxResidency");
        public static WinFormsField TaxQuoted = new WinFormsField("TAX-QUOTED", "TaxQuoted");
        public static WinFormsField USAccountType = new WinFormsField("US-ACCOUNT-TYPE", "USAccountType");
        public static WinFormsField USPreExistingInd = new WinFormsField("US-PRE-EXISTING-IND", "USPreExistingInd");
        public static WinFormsField USChapter3Status = new WinFormsField("US-CHAPTER3-STATUS", "USChapter3Status");
        public static WinFormsField USChapter4Status = new WinFormsField("US-CHAPTER4-STATUS", "USChapter4Status");
        public static WinFormsField USTaxTypeUsedCode = new WinFormsField("US-TAX-TYPE-USED-CODE", "USTaxTypeUsedCode");
    }
}
