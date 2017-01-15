using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS07902

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS07902", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField AsxTakeoverCode = new WinFormsField("ASX-TAKEOVER-CODE", "AsxTakeoverCode");
        public static WinFormsField ScripTakeoverNumber = new WinFormsField("SCRIP-TAKEOVER-NUMBER", "ScripTakeoverNumber");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField BrokerCommissionCode = new WinFormsField("BROKER-COMMISSION-CODE", "BrokerCommissionCode");
        public static WinFormsField DistinctPortionInd = new WinFormsField("DISTINCT-PORTION-IND", "DistinctPortionInd");
        public static WinFormsField AsxTakeoverDesc = new WinFormsField("ASX-TAKEOVER-DESC", "AsxTakeoverDesc");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField BrokerCommissionDesc = new WinFormsField("BROKER-COMMISSION-DESC", "BrokerCommissionDesc");
        public static WinFormsField Warnings = new WinFormsField("WARNINGS", "Warnings");
        public static WinFormsField ActionField = new WinFormsField("ACTION-FIELD", "ActionField");
        public static WinFormsField TransactionDate = new WinFormsField("TRANSACTION-DATE", "TransactionDate");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField BrokerDesc = new WinFormsField("BROKER-DESC", "BrokerDesc");
        public static WinFormsField Ols07902ReferenceTotr = new WinFormsField("OLS07902-REFERENCE-TOTR", "Ols07902ReferenceTotr");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
