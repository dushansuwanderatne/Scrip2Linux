using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS04202

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS04202", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField PayMethodFrom = new WinFormsField("PAY-METHOD-FROM", "PayMethodFrom");
        public static WinFormsField PayMethodFromDesc = new WinFormsField("PAY-METHOD-FROM-DESC", "PayMethodFromDesc");
        public static WinFormsField PayStatusFrom = new WinFormsField("PAY-STATUS-FROM", "PayStatusFrom");
        public static WinFormsField PayStatusFromDesc = new WinFormsField("PAY-STATUS-FROM-DESC", "PayStatusFromDesc");
        public static WinFormsField PayStatusUpdt = new WinFormsField("PAY-STATUS-UPDT", "PayStatusUpdt");
        public static WinFormsField PayStatusUpdtDesc = new WinFormsField("PAY-STATUS-UPDT-DESC", "PayStatusUpdtDesc");
        public static WinFormsField PayMethodTO = new WinFormsField("PAY-METHOD-TO", "PayMethodTO");
        public static WinFormsField PayMethodTODesc = new WinFormsField("PAY-METHOD-TO-DESC", "PayMethodTODesc");
        public static WinFormsField PayStatusTO = new WinFormsField("PAY-STATUS-TO", "PayStatusTO");
        public static WinFormsField PayStatusTODesc = new WinFormsField("PAY-STATUS-TO-DESC", "PayStatusTODesc");
        public static WinFormsField TranRvslCode = new WinFormsField("TRAN-RVSL-CODE", "TranRvslCode");
        public static WinFormsField VersionNbr = new WinFormsField("VERSION-NBR", "VersionNbr");
        public static WinFormsField AuditUserid = new WinFormsField("AUDIT-USERID", "AuditUserid");
        public static WinFormsField AuditDate = new WinFormsField("AUDIT-DATE", "AuditDate");
        public static WinFormsField AuditTime = new WinFormsField("AUDIT-TIME", "AuditTime");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1 = new WinFormsField("ACTION-1", "Action1");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
