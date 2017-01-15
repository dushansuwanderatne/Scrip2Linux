using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class XTT4

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("XTT4", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField PlanConcept = new WinFormsField("PLAN-CONCEPT", "PlanConcept");
        public static WinFormsField PlanCategory = new WinFormsField("PLAN-CATEGORY", "PlanCategory");
        public static WinFormsField PlanNOChangeDate = new WinFormsField("PLAN-NO-CHANGE-DATE", "PlanNOChangeDate");
        public static WinFormsField PartOption = new WinFormsField("PART-OPTION", "PartOption");
        public static WinFormsField PartLevel = new WinFormsField("PART-LEVEL", "PartLevel");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HldaddVersion = new WinFormsField("HLDADD-VERSION", "HldaddVersion");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField PrintOption = new WinFormsField("PRINT-OPTION", "PrintOption");
        public static WinFormsField DivSourceOption = new WinFormsField("DIV-SOURCE-OPTION", "DivSourceOption");
        public static WinFormsField Filler2 = new WinFormsField("FILLER2", "Filler2");
        public static WinFormsField Filler1 = new WinFormsField("FILLER1", "Filler1");
        public static WinFormsField Filler3 = new WinFormsField("FILLER3", "Filler3");
    }
}
