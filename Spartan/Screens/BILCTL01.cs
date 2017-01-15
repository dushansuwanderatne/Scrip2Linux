using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BILCTL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BILCTL01", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField BilctlKey0 = new WinFormsField("BILCTL-KEY0", "BilctlKey0");
        public static WinFormsField CorpActionCode = new WinFormsField("CORP-ACTION-CODE", "CorpActionCode");
        public static WinFormsField CorpActionDate = new WinFormsField("CORP-ACTION-DATE", "CorpActionDate");
        public static WinFormsField SlrServiceProvider = new WinFormsField("SLR-SERVICE-PROVIDER", "SlrServiceProvider");
        public static WinFormsField SlrServiceCode = new WinFormsField("SLR-SERVICE-CODE", "SlrServiceCode");
        public static WinFormsField SlrOrigSystem = new WinFormsField("SLR-ORIG-SYSTEM", "SlrOrigSystem");
        public static WinFormsField SlrMsgid = new WinFormsField("SLR-MSGID", "SlrMsgid");
        public static WinFormsField OrderNumber = new WinFormsField("ORDER-NUMBER", "OrderNumber");
        public static WinFormsField OpsInitials = new WinFormsField("OPS-INITIALS", "OpsInitials");
    }
}
