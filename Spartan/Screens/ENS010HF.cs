using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS010HF

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS010HF", "FormName");
		//Fields
        public static WinFormsField FilterSearchLimit = new WinFormsField("FILTER-SEARCH-LIMIT", "FilterSearchLimit");
        public static WinFormsField YN = new WinFormsField("YN", "YN");
        public static WinFormsField JointHoldings = new WinFormsField("JOINT-HOLDINGS", "JointHoldings");
        public static WinFormsField DesignatedAccount = new WinFormsField("DESIGNATED-ACCOUNT", "DesignatedAccount");
        public static WinFormsField HsyNoteFlag = new WinFormsField("HSY-NOTE-FLAG", "HsyNoteFlag");
        public static WinFormsField AnnualReport = new WinFormsField("ANNUAL-REPORT", "AnnualReport");
        public static WinFormsField Exception = new WinFormsField("EXCEPTION", "Exception");
        public static WinFormsField HstDividendIntent = new WinFormsField("HST-DIVIDEND-INTENT", "HstDividendIntent");
        public static WinFormsField VariableField = new WinFormsField("VARIABLE-FIELD", "VariableField");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField RunHAQualifier = new WinFormsField("RUN-HA-QUALIFIER", "RunHAQualifier");
        public static WinFormsField RunHolderAdded = new WinFormsField("RUN-HOLDER-ADDED", "RunHolderAdded");
        public static WinFormsField HolderCategory = new WinFormsField("HOLDER-CATEGORY", "HolderCategory");
        public static WinFormsField Hvf = new WinFormsField("HVF", "Hvf");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField HolderGroupCode = new WinFormsField("HOLDER-GROUP-CODE", "HolderGroupCode");
        public static WinFormsField NadMatchString = new WinFormsField("NAD-MATCH-STRING", "NadMatchString");
    }
}
