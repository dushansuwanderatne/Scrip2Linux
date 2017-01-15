using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENTUSA02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENTUSA02", "FormName");
		//Fields


        public static WinFormsField AccountType = new WinFormsField("ACCOUNT-TYPE", "AccountType");
        public static WinFormsField PreExisting = new WinFormsField("PRE-EXISTING", "PreExisting");
        public static WinFormsField TinStatus = new WinFormsField("TIN-STATUS", "TinStatus");
        public static WinFormsField USIndicia = new WinFormsField("US-INDICIA", "USIndicia");
        public static WinFormsField USTaxCode = new WinFormsField("US-TAX-CODE", "USTaxCode");
        public static WinFormsField Chap3Status = new WinFormsField("CHAP3-STATUS", "Chap3Status");
        public static WinFormsField Chap4FatcaStatus = new WinFormsField("CHAP4-FATCA-STATUS", "Chap4FatcaStatus");
        public static WinFormsField CuringLevel = new WinFormsField("CURING-LEVEL", "CuringLevel");
        public static WinFormsField TaxType = new WinFormsField("TAX-TYPE", "TaxType");
    }
}
