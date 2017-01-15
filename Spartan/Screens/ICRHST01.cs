using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICRHST01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICRHST01", "FormName");
		//Fields


        public static WinFormsField CompanyRef = new WinFormsField("COMPANY-REF", "CompanyRef");
        public static WinFormsField GroupID = new WinFormsField("GROUP-ID", "GroupID");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ReconDate = new WinFormsField("RECON-DATE", "ReconDate");
        public static WinFormsField ReconRunNbr = new WinFormsField("RECON-RUN-NBR", "ReconRunNbr");
        public static WinFormsField ReconType = new WinFormsField("RECON-TYPE", "ReconType");
        public static WinFormsField ApprovedICAuth = new WinFormsField("APPROVED-IC-AUTH", "ApprovedICAuth");
        public static WinFormsField ApprovedICExpired = new WinFormsField("APPROVED-IC-EXPIRED", "ApprovedICExpired");
        public static WinFormsField ScripICAmount = new WinFormsField("SCRIP-IC-AMOUNT", "ScripICAmount");
        public static WinFormsField ScripTolAuth = new WinFormsField("SCRIP-TOL-AUTH", "ScripTolAuth");
        public static WinFormsField ScripTolExpired = new WinFormsField("SCRIP-TOL-EXPIRED", "ScripTolExpired");
        public static WinFormsField ScripVarianceInclTol = new WinFormsField("SCRIP-VARIANCE-INCL-TOL", "ScripVarianceInclTol");
        public static WinFormsField ScripVarianceExclTol = new WinFormsField("SCRIP-VARIANCE-EXCL-TOL", "ScripVarianceExclTol");
        public static WinFormsField ScripICReconStatus = new WinFormsField("SCRIP-IC-RECON-STATUS", "ScripICReconStatus");
        public static WinFormsField AsxICAmount = new WinFormsField("ASX-IC-AMOUNT", "AsxICAmount");
        public static WinFormsField AsxTolAuth = new WinFormsField("ASX-TOL-AUTH", "AsxTolAuth");
        public static WinFormsField AsxTolExpired = new WinFormsField("ASX-TOL-EXPIRED", "AsxTolExpired");
        public static WinFormsField AsxVarianceInclTol = new WinFormsField("ASX-VARIANCE-INCL-TOL", "AsxVarianceInclTol");
        public static WinFormsField AsxVarianceExclTol = new WinFormsField("ASX-VARIANCE-EXCL-TOL", "AsxVarianceExclTol");
        public static WinFormsField AsxICReconStatus = new WinFormsField("ASX-IC-RECON-STATUS", "AsxICReconStatus");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
