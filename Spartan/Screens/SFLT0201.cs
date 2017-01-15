using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SFLT0201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SFLT0201", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField BrokerDesc = new WinFormsField("BROKER-DESC", "BrokerDesc");
        public static WinFormsField AgentCode = new WinFormsField("AGENT-CODE", "AgentCode");
        public static WinFormsField AgentDescription = new WinFormsField("AGENT-DESCRIPTION", "AgentDescription");
        public static WinFormsField GroupFlag = new WinFormsField("GROUP-FLAG", "GroupFlag");
        public static WinFormsField PoolLimit = new WinFormsField("POOL-LIMIT", "PoolLimit");
        public static WinFormsField AppRangeFrom = new WinFormsField("APP-RANGE-FROM", "AppRangeFrom");
        public static WinFormsField AppRangeTO = new WinFormsField("APP-RANGE-TO", "AppRangeTO");
        public static WinFormsField AlternateRangeFrom = new WinFormsField("ALTERNATE-RANGE-FROM", "AlternateRangeFrom");
        public static WinFormsField AlternateRangeTO = new WinFormsField("ALTERNATE-RANGE-TO", "AlternateRangeTO");
        public static WinFormsField AppRangeFrom3 = new WinFormsField("APP-RANGE-FROM-3", "AppRangeFrom3");
        public static WinFormsField AppRangeTO3 = new WinFormsField("APP-RANGE-TO-3", "AppRangeTO3");
        public static WinFormsField NumberApplications = new WinFormsField("NUMBER-APPLICATIONS", "NumberApplications");
        public static WinFormsField NumberShares = new WinFormsField("NUMBER-SHARES", "NumberShares");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ActionEnquire = new WinFormsField("ACTION-ENQUIRE", "ActionEnquire");
        public static WinFormsField SearchBroker = new WinFormsField("SEARCH-BROKER", "SearchBroker");
        public static WinFormsField SearchAgent = new WinFormsField("SEARCH-AGENT", "SearchAgent");
        public static WinFormsField ConfirmDelete = new WinFormsField("CONFIRM-DELETE", "ConfirmDelete");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
