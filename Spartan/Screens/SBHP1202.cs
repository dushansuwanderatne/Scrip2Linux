using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBHP1202

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBHP1202", "FormName");
		//Fields


        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField WarningLine = new WinFormsField("WARNING-LINE", "WarningLine");
        public static WinFormsField ModelPartFlag = new WinFormsField("MODEL-PART-FLAG", "ModelPartFlag");
        public static WinFormsField PerformanceFlag = new WinFormsField("PERFORMANCE-FLAG", "PerformanceFlag");
    }
}
