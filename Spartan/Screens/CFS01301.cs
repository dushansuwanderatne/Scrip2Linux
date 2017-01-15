using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS01301

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS01301", "FormName");
		//Fields


        public static WinFormsField TAFundInd = new WinFormsField("TA-FUND-IND", "TAFundInd");
        public static WinFormsField ChsctlKey0 = new WinFormsField("CHSCTL-KEY0", "ChsctlKey0");
        public static WinFormsField ProdAicInd = new WinFormsField("PROD-AIC-IND", "ProdAicInd");
        public static WinFormsField ProtocolVersion = new WinFormsField("PROTOCOL-VERSION", "ProtocolVersion");
        public static WinFormsField TransSessKey = new WinFormsField("TRANS-SESS-KEY", "TransSessKey");
        public static WinFormsField ReleaseNumber = new WinFormsField("RELEASE-NUMBER", "ReleaseNumber");
        public static WinFormsField TransMacKey = new WinFormsField("TRANS-MAC-KEY", "TransMacKey");
        public static WinFormsField DestinationUic = new WinFormsField("DESTINATION-UIC", "DestinationUic");
        public static WinFormsField RcvSessKey = new WinFormsField("RCV-SESS-KEY", "RcvSessKey");
        public static WinFormsField Aic = new WinFormsField("AIC", "Aic");
        public static WinFormsField RcvMacKey = new WinFormsField("RCV-MAC-KEY", "RcvMacKey");
        public static WinFormsField ChessKeyFilename = new WinFormsField("CHESS-KEY-FILENAME", "ChessKeyFilename");
        public static WinFormsField ClusterServerPort = new WinFormsField("CLUSTER-SERVER-PORT", "ClusterServerPort");
        public static WinFormsField X25Address = new WinFormsField("X25-ADDRESS", "X25Address");
        public static WinFormsField UseSecurity = new WinFormsField("USE-SECURITY", "UseSecurity");
        public static WinFormsField NextChessConvDate = new WinFormsField("NEXT-CHESS-CONV-DATE", "NextChessConvDate");
        public static WinFormsField CutoffTransTime = new WinFormsField("CUTOFF-TRANS-TIME", "CutoffTransTime");
        public static WinFormsField FilterBusinessDate = new WinFormsField("FILTER-BUSINESS-DATE", "FilterBusinessDate");
        public static WinFormsField TrnsrvTimeCycle = new WinFormsField("TRNSRV-TIME-CYCLE", "TrnsrvTimeCycle");
        public static WinFormsField ChessConvWeekend = new WinFormsField("CHESS-CONV-WEEKEND", "ChessConvWeekend");
        public static WinFormsField FilterMsgTypes = new WinFormsField("FILTER-MSG-TYPES", "FilterMsgTypes");
        public static WinFormsField CoyCodes1to20 = new WinFormsField("COY-CODES-1TO20", "CoyCodes1to20");
        public static WinFormsField CoyCodes21to40 = new WinFormsField("COY-CODES-21TO40", "CoyCodes21to40");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
