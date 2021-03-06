using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSHLD00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSHLD00", "FormName");
		//Fields


        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField EsshldKey1 = new WinFormsField("ESSHLD-KEY1", "EsshldKey1");
        public static WinFormsField ContractUsan = new WinFormsField("CONTRACT-USAN", "ContractUsan");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
