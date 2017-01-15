using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01014

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01014", "FormName");
		//Fields
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField CrtTransNumber = new WinFormsField("CRT-TRANS-NUMBER", "CrtTransNumber");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField HolderIDOff = new WinFormsField("HOLDER-ID-OFF", "HolderIDOff");
        public static WinFormsField HolderIDON = new WinFormsField("HOLDER-ID-ON", "HolderIDON");
        public static WinFormsField AddressLineOff = new WinFormsField("ADDRESS-LINE-OFF", "AddressLineOff");
        public static WinFormsField AddressLineON = new WinFormsField("ADDRESS-LINE-ON", "AddressLineON");
        public static WinFormsField BrokerOff = new WinFormsField("BROKER-OFF", "BrokerOff");
        public static WinFormsField ReferenceOff = new WinFormsField("REFERENCE-OFF", "ReferenceOff");
        public static WinFormsField BrokerON = new WinFormsField("BROKER-ON", "BrokerON");
        public static WinFormsField ReferenceON = new WinFormsField("REFERENCE-ON", "ReferenceON");
        public static WinFormsField Lines6 = new WinFormsField("6-LINES", "6Lines");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField AgentOff = new WinFormsField("AGENT-OFF", "AgentOff");
        public static WinFormsField AgentON = new WinFormsField("AGENT-ON", "AgentON");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
