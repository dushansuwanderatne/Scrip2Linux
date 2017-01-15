using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR03001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR03001", "FormName");
		//Fields


        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField ClsGrpCode = new WinFormsField("CLS-GRP-CODE", "ClsGrpCode");
        public static WinFormsField ClsGrpDesc = new WinFormsField("CLS-GRP-DESC", "ClsGrpDesc");
        public static WinFormsField ReconType = new WinFormsField("RECON-TYPE", "ReconType");
        public static WinFormsField ApprovedIC = new WinFormsField("APPROVED-IC", "ApprovedIC");
        public static WinFormsField ScripIC = new WinFormsField("SCRIP-IC", "ScripIC");
        public static WinFormsField AsxIC = new WinFormsField("ASX-IC", "AsxIC");
        public static WinFormsField LastReconExp = new WinFormsField("LAST-RECON-EXP", "LastReconExp");
        public static WinFormsField LastReconDate = new WinFormsField("LAST-RECON-DATE", "LastReconDate");
        public static WinFormsField LastReconRun = new WinFormsField("LAST-RECON-RUN", "LastReconRun");
        public static WinFormsField LineNOX = new WinFormsField("LINE-NO-X", "LineNOX");
        public static WinFormsField ToleranceType = new WinFormsField("TOLERANCE-TYPE", "ToleranceType");
        public static WinFormsField ToleranceAmount = new WinFormsField("TOLERANCE-AMOUNT", "ToleranceAmount");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
