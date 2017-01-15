using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FLTAGT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FLTAGT01", "FormName");
		//Fields


        public static WinFormsField FltagtKey0 = new WinFormsField("FLTAGT-KEY0", "FltagtKey0");
        public static WinFormsField GroupFlag = new WinFormsField("GROUP-FLAG", "GroupFlag");
        public static WinFormsField BrokerCode1 = new WinFormsField("BROKER-CODE-1", "BrokerCode1");
        public static WinFormsField AgentCode1 = new WinFormsField("AGENT-CODE-1", "AgentCode1");
        public static WinFormsField NbrDespatched = new WinFormsField("NBR-DESPATCHED", "NbrDespatched");
        public static WinFormsField PoolLimit = new WinFormsField("POOL-LIMIT", "PoolLimit");
        public static WinFormsField AgentDescription = new WinFormsField("AGENT-DESCRIPTION", "AgentDescription");
        public static WinFormsField NumberApplications = new WinFormsField("NUMBER-APPLICATIONS", "NumberApplications");
        public static WinFormsField NumberShares = new WinFormsField("NUMBER-SHARES", "NumberShares");
        public static WinFormsField ClassNumber = new WinFormsField("CLASS-NUMBER", "ClassNumber");
        public static WinFormsField ClassShares = new WinFormsField("CLASS-SHARES", "ClassShares");
        public static WinFormsField AppRangeFrom = new WinFormsField("APP-RANGE-FROM", "AppRangeFrom");
        public static WinFormsField AppRangeTO = new WinFormsField("APP-RANGE-TO", "AppRangeTO");
        public static WinFormsField AlternateRangeFrom = new WinFormsField("ALTERNATE-RANGE-FROM", "AlternateRangeFrom");
        public static WinFormsField AlternateRangeTO = new WinFormsField("ALTERNATE-RANGE-TO", "AlternateRangeTO");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
