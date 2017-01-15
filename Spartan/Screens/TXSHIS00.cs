using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TXSHIS00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TXSHIS00", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField Mts0TxshisKey0 = new WinFormsField("MTS0-TXSHIS-KEY0", "Mts0TxshisKey0");
        public static WinFormsField Mts0EsstrnKey1 = new WinFormsField("MTS0-ESSTRN-KEY1", "Mts0EsstrnKey1");
    }
}
