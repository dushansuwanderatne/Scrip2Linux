using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FSTHIS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FSTHIS01", "FormName");
		//Fields


        public static WinFormsField FsthisKey0 = new WinFormsField("FSTHIS-KEY0", "FsthisKey0");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField FastTORun = new WinFormsField("FAST-TO-RUN", "FastTORun");
        public static WinFormsField CrtTrnCount = new WinFormsField("CRT-TRN-COUNT", "CrtTrnCount");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField CrtTransNumber = new WinFormsField("CRT-TRANS-NUMBER", "CrtTransNumber");
        public static WinFormsField FromTOFlag = new WinFormsField("FROM-TO-FLAG", "FromTOFlag");
        public static WinFormsField TranSequence = new WinFormsField("TRAN-SEQUENCE", "TranSequence");
        public static WinFormsField UnitsTraded = new WinFormsField("UNITS-TRADED", "UnitsTraded");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField TradingHolderID = new WinFormsField("TRADING-HOLDER-ID", "TradingHolderID");
        public static WinFormsField TradeReference = new WinFormsField("TRADE-REFERENCE", "TradeReference");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
