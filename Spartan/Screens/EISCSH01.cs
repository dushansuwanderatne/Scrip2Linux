using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EISCSH01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EISCSH01", "FormName");
		//Fields


        public static WinFormsField EiscshKey0 = new WinFormsField("EISCSH-KEY0", "EiscshKey0");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField InvProcess = new WinFormsField("INV-PROCESS", "InvProcess");
        public static WinFormsField TranCount = new WinFormsField("TRAN-COUNT", "TranCount");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField ReferenceNbr = new WinFormsField("REFERENCE-NBR", "ReferenceNbr");
        public static WinFormsField AllotPeriod = new WinFormsField("ALLOT-PERIOD", "AllotPeriod");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField EmployeeContrib = new WinFormsField("EMPLOYEE-CONTRIB", "EmployeeContrib");
        public static WinFormsField CompanyContrib = new WinFormsField("COMPANY-CONTRIB", "CompanyContrib");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
