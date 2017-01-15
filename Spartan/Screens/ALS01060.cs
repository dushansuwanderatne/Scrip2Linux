using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ALS01060

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ALS01060", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField AltctlNum = new WinFormsField("ALTCTL-NUM", "AltctlNum");
        public static WinFormsField RepDate = new WinFormsField("REP-DATE", "RepDate");
        public static WinFormsField RepHeading = new WinFormsField("REP-HEADING", "RepHeading");
        public static WinFormsField PrintFileName = new WinFormsField("PRINT-FILE-NAME", "PrintFileName");
        public static WinFormsField AllotNumber = new WinFormsField("ALLOT-NUMBER", "AllotNumber");
        public static WinFormsField ConfirmDelete = new WinFormsField("CONFIRM-DELETE", "ConfirmDelete");
    }
}
