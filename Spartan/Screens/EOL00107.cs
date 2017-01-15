using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00107

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00107", "FormName");
		//Fields
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField MenuItemGrt = new WinFormsField("MENU-ITEM-GRT", "GRT. Grant Options", "GrantOptions");
        public static WinFormsField MenuItemInm = new WinFormsField("MENU-ITEM-INM", "INM. Multiple Grants - Health & Integrity Check", "MultipleGrants-Health&IntegrityCheck");
        public static WinFormsField MenuItemUpm = new WinFormsField("MENU-ITEM-UPM", "UPM. Multiple Grants - Bulk Upload Process", "MultipleGrants-BulkUploadProcess");
        public static WinFormsField MenuItemLvp = new WinFormsField("MENU-ITEM-LVP", "LVP. Leaver Processing", "LeaverProcessing");
        public static WinFormsField MenuItemLpc = new WinFormsField("MENU-ITEM-LPC", "LPC. Lapse & Cancellation Processing", "Lapse&CancellationProcessing");
        public static WinFormsField MenuItemRec = new WinFormsField("MENU-ITEM-REC", "REC. Reconstruction Reversal Processing", "ReconstructionReversalProcessing");
        public static WinFormsField MenuItemRev = new WinFormsField("MENU-ITEM-REV", "REV. Bulk Transaction Reversal", "BulkTransactionReversal");
        public static WinFormsField MenuItemRve = new WinFormsField("MENU-ITEM-RVE", "RVE. ESS Option Exercise Reversal", "ESSOptionExerciseReversal");
        public static WinFormsField MenuItemEvt = new WinFormsField("MENU-ITEM-EVT", "EVT. Event Processing", "EventProcessing");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
