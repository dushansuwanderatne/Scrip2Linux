using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR03003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR03003", "FormName");
		//Fields


        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField ClsGrpCode = new WinFormsField("CLS-GRP-CODE", "ClsGrpCode");
        public static WinFormsField ClsGrpDesc = new WinFormsField("CLS-GRP-DESC", "ClsGrpDesc");
        public static WinFormsField ReconType = new WinFormsField("RECON-TYPE", "ReconType");
        public static WinFormsField ToleranceType = new WinFormsField("TOLERANCE-TYPE", "ToleranceType");
        public static WinFormsField ApprovedIC = new WinFormsField("APPROVED-IC", "ApprovedIC");
        public static WinFormsField ScripIC = new WinFormsField("SCRIP-IC", "ScripIC");
        public static WinFormsField AsxIC = new WinFormsField("ASX-IC", "AsxIC");
        public static WinFormsField CumIC = new WinFormsField("CUM-IC", "CumIC");
        public static WinFormsField LastReconExp = new WinFormsField("LAST-RECON-EXP", "LastReconExp");
        public static WinFormsField LastReconDate = new WinFormsField("LAST-RECON-DATE", "LastReconDate");
        public static WinFormsField LastReconRun = new WinFormsField("LAST-RECON-RUN", "LastReconRun");
        public static WinFormsField StartDate = new WinFormsField("START-DATE", "StartDate");
        public static WinFormsField EndDate = new WinFormsField("END-DATE", "EndDate");
        public static WinFormsField TolAmount = new WinFormsField("TOL-AMOUNT", "TolAmount");
        public static WinFormsField TolDirection = new WinFormsField("TOL-DIRECTION", "TolDirection");
        public static WinFormsField TolReason = new WinFormsField("TOL-REASON", "TolReason");
        public static WinFormsField TolStatus = new WinFormsField("TOL-STATUS", "TolStatus");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ActionName = new WinFormsField("ACTION-NAME", "ActionName");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
