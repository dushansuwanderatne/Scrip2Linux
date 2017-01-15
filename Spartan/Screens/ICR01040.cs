using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR01040

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR01040", "FormName");
		//Fields


        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField ClsGrpCode = new WinFormsField("CLS-GRP-CODE", "ClsGrpCode");
        public static WinFormsField ClsGrpDesc = new WinFormsField("CLS-GRP-DESC", "ClsGrpDesc");
        public static WinFormsField ReconTypeDesc = new WinFormsField("RECON-TYPE-DESC", "ReconTypeDesc");
        public static WinFormsField LastReconDate = new WinFormsField("LAST-RECON-DATE", "LastReconDate");
        public static WinFormsField ScripICAmount = new WinFormsField("SCRIP-IC-AMOUNT", "ScripICAmount");
        public static WinFormsField LastReconRun = new WinFormsField("LAST-RECON-RUN", "LastReconRun");
        public static WinFormsField AsxICAmount = new WinFormsField("ASX-IC-AMOUNT", "AsxICAmount");
        public static WinFormsField ApprovedICAmount = new WinFormsField("APPROVED-IC-AMOUNT", "ApprovedICAmount");
        public static WinFormsField EndDate = new WinFormsField("END-DATE", "EndDate");
        public static WinFormsField Line = new WinFormsField("LINE", "Line");
        public static WinFormsField StartDate = new WinFormsField("START-DATE", "StartDate");
        public static WinFormsField ApprovedAmt = new WinFormsField("APPROVED-AMT", "ApprovedAmt");
        public static WinFormsField ApprovedAmtID = new WinFormsField("APPROVED-AMT-I-D", "ApprovedAmtID");
        public static WinFormsField NewBalance = new WinFormsField("NEW-BALANCE", "NewBalance");
        public static WinFormsField ReasonCode = new WinFormsField("REASON-CODE", "ReasonCode");
        public static WinFormsField DateModifided = new WinFormsField("DATE-MODIFIDED", "DateModifided");
        public static WinFormsField DateAuthorised = new WinFormsField("DATE-AUTHORISED", "DateAuthorised");
        public static WinFormsField StatusDesc = new WinFormsField("STATUS-DESC", "StatusDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField FwdAction = new WinFormsField("FWD-ACTION", "FwdAction");
        public static WinFormsField BackAction = new WinFormsField("BACK-ACTION", "BackAction");
        public static WinFormsField DotAction = new WinFormsField("DOT-ACTION", "DotAction");
        public static WinFormsField ApprovedICSign = new WinFormsField("APPROVED-IC-SIGN", "ApprovedICSign");
        public static WinFormsField NewBalanceSign = new WinFormsField("NEW-BALANCE-SIGN", "NewBalanceSign");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
