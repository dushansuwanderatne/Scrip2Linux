using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS03803

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS03803", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField AiirReference = new WinFormsField("AIIR-REFERENCE", "AiirReference");
        public static WinFormsField AiirRefDescr = new WinFormsField("AIIR-REF-DESCR", "AiirRefDescr");
        public static WinFormsField CompTypeCode = new WinFormsField("COMP-TYPE-CODE", "CompTypeCode");
        public static WinFormsField CompTypeDescr = new WinFormsField("COMP-TYPE-DESCR", "CompTypeDescr");
        public static WinFormsField FinYearStart = new WinFormsField("FIN-YEAR-START", "FinYearStart");
        public static WinFormsField FinYearEnd = new WinFormsField("FIN-YEAR-END", "FinYearEnd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
