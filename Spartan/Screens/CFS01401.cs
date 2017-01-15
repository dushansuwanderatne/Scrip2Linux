using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS01401

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS01401", "FormName");
		//Fields


        public static WinFormsField CrsctlKey0 = new WinFormsField("CRSCTL-KEY0", "CrsctlKey0");
        public static WinFormsField UserID = new WinFormsField("USER-ID", "UserID");
        public static WinFormsField SendVolume = new WinFormsField("SEND-VOLUME", "SendVolume");
        public static WinFormsField SendInterval = new WinFormsField("SEND-INTERVAL", "SendInterval");
        public static WinFormsField CutoffTime = new WinFormsField("CUTOFF-TIME", "CutoffTime");
        public static WinFormsField BusinessDate = new WinFormsField("BUSINESS-DATE", "BusinessDate");
        public static WinFormsField Mode = new WinFormsField("MODE", "Mode");
        public static WinFormsField Active = new WinFormsField("ACTIVE", "Active");
        public static WinFormsField OperatorID = new WinFormsField("OPERATOR-ID", "OperatorID");
        public static WinFormsField NTAddress = new WinFormsField("NT-ADDRESS", "NTAddress");
        public static WinFormsField IPPortFromCrest = new WinFormsField("IP-PORT-FROM-CREST", "IPPortFromCrest");
        public static WinFormsField IPPortTOCrest = new WinFormsField("IP-PORT-TO-CREST", "IPPortTOCrest");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
