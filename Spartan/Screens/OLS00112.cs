using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS00112

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS00112", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ProcessAction = new WinFormsField("PROCESS-ACTION", "ProcessAction");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField DateTOApply = new WinFormsField("DATE-TO-APPLY", "DateTOApply");
        public static WinFormsField ApplyAction = new WinFormsField("APPLY-ACTION", "ApplyAction");
        public static WinFormsField LodgementDate = new WinFormsField("LODGEMENT-DATE", "LodgementDate");
        public static WinFormsField NewTransNumber = new WinFormsField("NEW-TRANS-NUMBER", "NewTransNumber");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
