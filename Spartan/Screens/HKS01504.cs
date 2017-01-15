using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01504

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01504", "FormName");
		//Fields


        public static WinFormsField ChangeNoticeOption = new WinFormsField("CHANGE-NOTICE-OPTION", "ChangeNoticeOption");
        public static WinFormsField LostSrnAcknowlege = new WinFormsField("LOST-SRN-ACKNOWLEGE", "LostSrnAcknowlege");
        public static WinFormsField DividendAcknowlege = new WinFormsField("DIVIDEND-ACKNOWLEGE", "DividendAcknowlege");
        public static WinFormsField DrpBspAcknowlege = new WinFormsField("DRP-BSP-ACKNOWLEGE", "DrpBspAcknowlege");
        public static WinFormsField UrrAdviceFormat = new WinFormsField("URR-ADVICE-FORMAT", "UrrAdviceFormat");
        public static WinFormsField NewshnOption = new WinFormsField("NEWSHN-OPTION", "NewshnOption");
        public static WinFormsField NsnFormatNumber = new WinFormsField("NSN-FORMAT-NUMBER", "NsnFormatNumber");
        public static WinFormsField NspForRetradesInd = new WinFormsField("NSP-FOR-RETRADES-IND", "NspForRetradesInd");
        public static WinFormsField EmailFailAck = new WinFormsField("EMAIL-FAIL-ACK", "EmailFailAck");
        public static WinFormsField EmailFailCount = new WinFormsField("EMAIL-FAIL-COUNT", "EmailFailCount");
        public static WinFormsField EmailAckReqdInd = new WinFormsField("EMAIL-ACK-REQD-IND", "EmailAckReqdInd");
        public static WinFormsField PoaAckReqdInd = new WinFormsField("POA-ACK-REQD-IND", "PoaAckReqdInd");
        public static WinFormsField CharityAckReqdInd = new WinFormsField("CHARITY-ACK-REQD-IND", "CharityAckReqdInd");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
