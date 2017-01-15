using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EISWDL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EISWDL01", "FormName");
		//Fields


        public static WinFormsField EiswdlKey0 = new WinFormsField("EISWDL-KEY0", "EiswdlKey0");
        public static WinFormsField WdlType = new WinFormsField("WDL-TYPE", "WdlType");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField WdlDate = new WinFormsField("WDL-DATE", "WdlDate");
        public static WinFormsField InvProcess = new WinFormsField("INV-PROCESS", "InvProcess");
        public static WinFormsField UnitValue = new WinFormsField("UNIT-VALUE", "UnitValue");
        public static WinFormsField AllotPeriod = new WinFormsField("ALLOT-PERIOD", "AllotPeriod");
        public static WinFormsField SellPrice = new WinFormsField("SELL-PRICE", "SellPrice");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField CertType = new WinFormsField("CERT-TYPE", "CertType");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField VestedInd = new WinFormsField("VESTED-IND", "VestedInd");
        public static WinFormsField CrttrnCount = new WinFormsField("CRTTRN-COUNT", "CrttrnCount");
        public static WinFormsField CertUnitsOff = new WinFormsField("CERT-UNITS-OFF", "CertUnitsOff");
        public static WinFormsField UnitsForfeitRetain = new WinFormsField("UNITS-FORFEIT-RETAIN", "UnitsForfeitRetain");
        public static WinFormsField WdlPeriod = new WinFormsField("WDL-PERIOD", "WdlPeriod");
        public static WinFormsField HolderIdentifierK1 = new WinFormsField("HOLDER-IDENTIFIER-K1", "HolderIdentifierK1");
        public static WinFormsField CoyBF = new WinFormsField("COY-BF", "CoyBF");
        public static WinFormsField CoyBFFR = new WinFormsField("COY-BF-FR", "CoyBFFR");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField CoyContrib = new WinFormsField("COY-CONTRIB", "CoyContrib");
        public static WinFormsField CoyContribFR = new WinFormsField("COY-CONTRIB-FR", "CoyContribFR");
        public static WinFormsField RefNumber = new WinFormsField("REF-NUMBER", "RefNumber");
        public static WinFormsField EmpBF = new WinFormsField("EMP-BF", "EmpBF");
        public static WinFormsField EmpBFFR = new WinFormsField("EMP-BF-FR", "EmpBFFR");
        public static WinFormsField TranSequence = new WinFormsField("TRAN-SEQUENCE", "TranSequence");
        public static WinFormsField EmpContrib = new WinFormsField("EMP-CONTRIB", "EmpContrib");
        public static WinFormsField EmpContribFR = new WinFormsField("EMP-CONTRIB-FR", "EmpContribFR");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
