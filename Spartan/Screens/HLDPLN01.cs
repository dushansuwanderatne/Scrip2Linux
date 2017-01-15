using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HLDPLN01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HLDPLN01", "FormName");
		//Fields


        public static WinFormsField HldplnKey0 = new WinFormsField("HLDPLN-KEY0", "HldplnKey0");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField PlanConcept = new WinFormsField("PLAN-CONCEPT", "PlanConcept");
        public static WinFormsField PlanCategory = new WinFormsField("PLAN-CATEGORY", "PlanCategory");
        public static WinFormsField LCRunNumber = new WinFormsField("LC-RUN-NUMBER", "LCRunNumber");
        public static WinFormsField LCTransNumber = new WinFormsField("LC-TRANS-NUMBER", "LCTransNumber");
        public static WinFormsField PendingRunNumber = new WinFormsField("PENDING-RUN-NUMBER", "PendingRunNumber");
        public static WinFormsField ParticipationOption = new WinFormsField("PARTICIPATION-OPTION", "ParticipationOption");
        public static WinFormsField PendingTransNumber = new WinFormsField("PENDING-TRANS-NUMBER", "PendingTransNumber");
        public static WinFormsField ParticipationLevel = new WinFormsField("PARTICIPATION-LEVEL", "ParticipationLevel");
        public static WinFormsField PendingDate = new WinFormsField("PENDING-DATE", "PendingDate");
        public static WinFormsField ApplicationDate = new WinFormsField("APPLICATION-DATE", "ApplicationDate");
        public static WinFormsField PendingPartOption = new WinFormsField("PENDING-PART-OPTION", "PendingPartOption");
        public static WinFormsField VariationDate = new WinFormsField("VARIATION-DATE", "VariationDate");
        public static WinFormsField PendingPartLevel = new WinFormsField("PENDING-PART-LEVEL", "PendingPartLevel");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
