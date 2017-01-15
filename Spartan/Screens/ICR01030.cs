using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR01030

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR01030", "FormName");
		//Fields


        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField ClsGrpCode = new WinFormsField("CLS-GRP-CODE", "ClsGrpCode");
        public static WinFormsField ClsGrpDesc = new WinFormsField("CLS-GRP-DESC", "ClsGrpDesc");
        public static WinFormsField ReconTypeDesc = new WinFormsField("RECON-TYPE-DESC", "ReconTypeDesc");
        public static WinFormsField LastReconDate = new WinFormsField("LAST-RECON-DATE", "LastReconDate");
        public static WinFormsField EndDate = new WinFormsField("END-DATE", "EndDate");
        public static WinFormsField LastReconRun = new WinFormsField("LAST-RECON-RUN", "LastReconRun");
        public static WinFormsField ReconDate = new WinFormsField("RECON-DATE", "ReconDate");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField ApprovedIC = new WinFormsField("APPROVED-IC", "ApprovedIC");
        public static WinFormsField ApprovedICSign = new WinFormsField("APPROVED-IC-SIGN", "ApprovedICSign");
        public static WinFormsField ScripIC = new WinFormsField("SCRIP-IC", "ScripIC");
        public static WinFormsField ScripAuthTol = new WinFormsField("SCRIP-AUTH-TOL", "ScripAuthTol");
        public static WinFormsField ScripAuthTolID = new WinFormsField("SCRIP-AUTH-TOL-I-D", "ScripAuthTolID");
        public static WinFormsField ScripReconStatus = new WinFormsField("SCRIP-RECON-STATUS", "ScripReconStatus");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField FwdAction = new WinFormsField("FWD-ACTION", "FwdAction");
        public static WinFormsField BackAction = new WinFormsField("BACK-ACTION", "BackAction");
        public static WinFormsField DotAction = new WinFormsField("DOT-ACTION", "DotAction");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
