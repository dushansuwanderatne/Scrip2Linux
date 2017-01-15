using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS03702

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS03702", "FormName");
		//Fields


        public static WinFormsField AiirReference = new WinFormsField("AIIR-REFERENCE", "AiirReference");
        public static WinFormsField FinYearStart = new WinFormsField("FIN-YEAR-START", "FinYearStart");
        public static WinFormsField FinYearEnd = new WinFormsField("FIN-YEAR-END", "FinYearEnd");
        public static WinFormsField AiirDivInd = new WinFormsField("AIIR-DIV-IND", "AiirDivInd");
        public static WinFormsField AiirUtdInd = new WinFormsField("AIIR-UTD-IND", "AiirUtdInd");
        public static WinFormsField AiirIntInd = new WinFormsField("AIIR-INT-IND", "AiirIntInd");
        public static WinFormsField AiirTdpInd = new WinFormsField("AIIR-TDP-IND", "AiirTdpInd");
        public static WinFormsField AiirFsiInd = new WinFormsField("AIIR-FSI-IND", "AiirFsiInd");
        public static WinFormsField AiirDisInd = new WinFormsField("AIIR-DIS-IND", "AiirDisInd");
        public static WinFormsField AiirFmdInd = new WinFormsField("AIIR-FMD-IND", "AiirFmdInd");
        public static WinFormsField AiirIrbInd = new WinFormsField("AIIR-IRB-IND", "AiirIrbInd");
        public static WinFormsField ShortDescription = new WinFormsField("SHORT-DESCRIPTION", "ShortDescription");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField LongDescription = new WinFormsField("LONG-DESCRIPTION", "LongDescription");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
