using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR01080

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR01080", "FormName");
		//Fields


        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField ClsGrpCode = new WinFormsField("CLS-GRP-CODE", "ClsGrpCode");
        public static WinFormsField ClsGrpDesc = new WinFormsField("CLS-GRP-DESC", "ClsGrpDesc");
        public static WinFormsField ASATDate = new WinFormsField("AS-AT-DATE", "ASATDate");
        public static WinFormsField LineNOX = new WinFormsField("LINE-NO-X", "LineNOX");
        public static WinFormsField GroupNumber = new WinFormsField("GROUP-NUMBER", "GroupNumber");
        public static WinFormsField GroupDescription = new WinFormsField("GROUP-DESCRIPTION", "GroupDescription");
        public static WinFormsField FirstReconDate = new WinFormsField("FIRST-RECON-DATE", "FirstReconDate");
        public static WinFormsField LastReconDate = new WinFormsField("LAST-RECON-DATE", "LastReconDate");
        public static WinFormsField ReconTypeDesc = new WinFormsField("RECON-TYPE-DESC", "ReconTypeDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField FwdAction = new WinFormsField("FWD-ACTION", "FwdAction");
        public static WinFormsField BackAction = new WinFormsField("BACK-ACTION", "BackAction");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
