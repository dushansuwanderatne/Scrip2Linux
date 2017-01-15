using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FHK01201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FHK01201", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SofValue = new WinFormsField("SOF-VALUE", "SofValue");
        public static WinFormsField BrokerCodeReqInd = new WinFormsField("BROKER-CODE-REQ-IND", "BrokerCodeReqInd");
        public static WinFormsField SofDesc = new WinFormsField("SOF-DESC", "SofDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
