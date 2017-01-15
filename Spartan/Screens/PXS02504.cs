using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS02504

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS02504", "FormName");
		//Fields
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RefNumber = new WinFormsField("REF-NUMBER", "RefNumber");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField ResDesc = new WinFormsField("RES-DESC", "ResDesc");
        public static WinFormsField ClassEntitlement = new WinFormsField("CLASS-ENTITLEMENT", "ClassEntitlement");
        public static WinFormsField TotalEntered = new WinFormsField("TOTAL-ENTERED", "TotalEntered");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField Difference = new WinFormsField("DIFFERENCE", "Difference");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
    }
}
