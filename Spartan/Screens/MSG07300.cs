using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG07300

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG07300", "FormName");
		//Fields


        public static WinFormsField AsxCode = new WinFormsField("ASX-CODE", "AsxCode");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField CoyUic = new WinFormsField("COY-UIC", "CoyUic");
        public static WinFormsField CompanyStatus = new WinFormsField("COMPANY-STATUS", "CompanyStatus");
        public static WinFormsField StatusDescription = new WinFormsField("STATUS-DESCRIPTION", "StatusDescription");
        public static WinFormsField ConvDate = new WinFormsField("CONV-DATE", "ConvDate");
        public static WinFormsField Pending = new WinFormsField("PENDING", "Pending");
        public static WinFormsField PendingTot = new WinFormsField("PENDING-TOT", "PendingTot");
        public static WinFormsField Post = new WinFormsField("POST", "Post");
        public static WinFormsField PostTot = new WinFormsField("POST-TOT", "PostTot");
        public static WinFormsField ConvPhase = new WinFormsField("CONV-PHASE", "ConvPhase");
        public static WinFormsField ConvPhaseTot = new WinFormsField("CONV-PHASE-TOT", "ConvPhaseTot");
        public static WinFormsField MoreCodes = new WinFormsField("MORE-CODES", "MoreCodes");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
