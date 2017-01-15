using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS03804

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS03804", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField FromHolderID = new WinFormsField("FROM-HOLDER-ID", "FromHolderID");
        public static WinFormsField RecordDate = new WinFormsField("RECORD-DATE", "RecordDate");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField CorporateAction = new WinFormsField("CORPORATE-ACTION", "CorporateAction");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField CumBalance = new WinFormsField("CUM-BALANCE", "CumBalance");
        public static WinFormsField TOHolderID = new WinFormsField("TO-HOLDER-ID", "TOHolderID");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
