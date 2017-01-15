using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG06502

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG06502", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField QuotedSecurityInd = new WinFormsField("QUOTED-SECURITY-IND", "QuotedSecurityInd");
        public static WinFormsField IssuingCurInd = new WinFormsField("ISSUING-CUR-IND", "IssuingCurInd");
        public static WinFormsField BasisOFQuotation = new WinFormsField("BASIS-OF-QUOTATION", "BasisOFQuotation");
        public static WinFormsField StampDutyFlag = new WinFormsField("STAMP-DUTY-FLAG", "StampDutyFlag");
        public static WinFormsField MaxApplicationMoney = new WinFormsField("MAX-APPLICATION-MONEY", "MaxApplicationMoney");
        public static WinFormsField MinApplicationMoney = new WinFormsField("MIN-APPLICATION-MONEY", "MinApplicationMoney");
        public static WinFormsField AppCloseDate = new WinFormsField("APP-CLOSE-DATE", "AppCloseDate");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
